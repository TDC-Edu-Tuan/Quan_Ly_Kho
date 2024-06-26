﻿

using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;

namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_001_01_Ke_Hoach_Nhap_List : UCBase
    {
        private List<CXNK_Nhap_Kho> m_arrData = new();

        public FXNK_001_01_Ke_Hoach_Nhap_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = true;
            g_bIs_Updated_Permission = true;
            g_bIs_Deleted_Permission = true;
            g_bIs_Print_Permission = true;


            // Chuyển đổi mã màu hex thành màu Color
            Color navColor = ColorTranslator.FromHtml("#d8bfd8");

            // Đặt màu nền cho panel2
            panel2.BackColor = navColor;
        }

        protected override void Load_Init()
        {
            dtmFrom.Value = CUtility_Date.Convert_To_Dau_Ngay(DateTime.Now.AddDays(-15));
            dtmTo.Value = CUtility_Date.Convert_To_Cuoi_Ngay(DateTime.Now);

            g_grdData = grdData; //Để tham chiếu tới export excel
            Disable_Default_Col();

            g_arrCol_Hiden.Add("NCC_ID");
            g_arrCol_Hiden.Add("Trang_Thai_Nhap_Kho_ID");
            //g_arrCol_Hiden.Add("Trang_Thai_Nhap_Kho_Text");

            g_dicCol_Name.Add("Ma_NCC", "Mã NCC");
            g_dicCol_Name.Add("Ten_NCC", "Tên NCC");
            g_dicCol_Name.Add("So_Phieu_Nhap", "Số Phiếu Nhập");
            g_dicCol_Name.Add("Ngay_Nhap_Kho", "Ngày Nhập Kho");
            g_dicCol_Name.Add("Tong_SL", "Tổng SL");
            g_dicCol_Name.Add("Tong_Tri_Gia", "Tổng Trị Giá");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");
            g_dicCol_Name.Add("Trang_Thai_Nhap_Kho_Text", "Trạng Thái");


            g_dicCol_Size.Add("So_Phieu_Nhap", 200);
            g_dicCol_Size.Add("Ma_NCC", 100);
            g_dicCol_Size.Add("Ten_NCC", 200);
            g_dicCol_Size.Add("Ngay_Nhap_Kho", 100);
            g_dicCol_Size.Add("Tong_SL", 50);
            g_dicCol_Size.Add("Tong_Tri_Gia", 50);
            g_dicCol_Size.Add("Ghi_Chu", 300);

            g_dicCol_Index.Add("Ma_NCC", 5);
            g_dicCol_Index.Add("Ten_NCC", 6);

            FControl_Chu_Hang_User_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_User_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");
            cbbChu_Hang.SelectedValue = g_lngChu_Hang_ID;
            cbbKho.SelectedValue = g_lngKho_ID;
        }

        protected override void Load_Data()
        {
            CXNK_Nhap_Kho_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_718_NK_sp_sel_List_By_Created_And_Trang_Thai(g_lngChu_Hang_ID, g_lngKho_ID, (int)ETrang_Thai_Nhap_Kho.New, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

            string v_strSettings_Icon_Path = CUtility.Find_File_In_Solution("settings.png");
            Image v_objSetting_Icon = Image.FromFile(v_strSettings_Icon_Path);
            DataGridViewImageColumn v_objSet_Col = new();
            Add_Button_Column("btnUpdate_Detail_Phieu_Nhap", v_objSet_Col, 2, v_objSetting_Icon);
            g_grdData.Columns["btnUpdate_Detail_Phieu_Nhap"].Visible = g_bIs_Updated_Permission;
            g_grdData.Columns["btnUpdate_Detail_Phieu_Nhap"].HeaderText = "Chi tiết";
            Col_Custom(g_grdData.Columns["btnUpdate_Detail_Phieu_Nhap"]);
        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            if (p_lngAuto_ID == CConst.INT_VALUE_NULL)
            {
                FXNK_001_03_Ke_Hoach_Nhap_Edit v_objEdit = new();
                v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
                v_objEdit.g_lngKho_ID = g_lngKho_ID;
                v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
                v_objEdit.User_Name = User_Name;
                v_objEdit.Function_Code = Function_Code;

                v_objEdit.ShowDialog();
            }
            else
            {
                FXNK_001_03_Update_Info_Phieu_Nhap_Edit v_objEdit = new();
                v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
                v_objEdit.g_lngKho_ID = g_lngKho_ID;
                v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
                v_objEdit.User_Name = User_Name;
                v_objEdit.Function_Code = Function_Code;

                v_objEdit.ShowDialog();
            }
        }

        //Hàm đc gọi khi ấn vào nút view
        protected override void Open_View_Data(long p_lngAuto_ID)
        {
            FXNK_001_02_Ke_Hoach_Nhap_View v_objView = new();
            v_objView.g_lngAuto_ID = p_lngAuto_ID;
            v_objView.User_Name = User_Name;
            v_objView.Function_Code = Function_Code;
            v_objView.Show();
        }

        protected override void Import_Excel_Entry(CExcel_Controller v_objCtrlExcel, ref int p_iCount_Success, ref int p_iCount_Error)
        {
            CDM_Nhan_Vien_Kho_Controller v_objCtrData = new();

            StringBuilder v_sbError = new StringBuilder();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            try
            {
                DataTable v_dt = v_objCtrlExcel.List_Range_Value_To_End(0, "A2", "H");

                // Loại mấy dòng trống
                for (int v_i = v_dt.Rows.Count - 1; v_i >= 0; v_i--)
                    if (v_dt.Rows[v_i][0].ToString().Trim() == "")
                        v_dt.Rows.RemoveAt(v_i);

                int v_iCount = 1;

                foreach (DataRow v_row in v_dt.Rows)
                {
                    v_iCount++;

                    //tao ket noi transaction
                    v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                    v_conn.Open();
                    v_trans = v_conn.BeginTransaction();

                    try
                    {
                        CDM_Nhan_Vien_Kho v_objData = new CDM_Nhan_Vien_Kho();
                        v_objData.Kho_ID = g_lngKho_ID;
                        v_objData.Ma_NV = CUtility.Convert_To_String(v_row[0]);
                        v_objData.Ten_NV = CUtility.Convert_To_String(v_row[1]);
                        v_objData.Gioi_Tinh = CUtility.Convert_To_String(v_row[2]);
                        v_objData.Dia_Chi = CUtility.Convert_To_String(v_row[3]);
                        v_objData.Dien_Thoai = CUtility.Convert_To_String(v_row[4]);
                        v_objData.CCCD = CUtility.Convert_To_String(v_row[5]);
                        v_objData.Ghi_Chu = CUtility.Convert_To_String(v_row[6]);
                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        v_objData.Auto_ID = v_objCtrData.FQ_127_NVK_sp_ins_Insert(v_conn, v_trans, v_objData);
                        p_iCount_Success++;
                        v_trans.Commit();

                        CCache_Nhan_Vien_Kho.Add_Data(v_objData);
                    }

                    catch (Exception ex)
                    {
                        v_sbError.AppendLine("Dòng" + " " + v_iCount.ToString() + " " + "có lỗi" + ": " + ex.Message);
                        if (v_trans != null)
                            v_trans.Rollback();
                    }

                    finally
                    {
                        if (v_trans != null)
                            v_trans.Dispose();

                        if (v_conn != null)
                            v_conn.Close();
                    }
                }

                p_iCount_Error = v_dt.Rows.Count - p_iCount_Success;
                if (v_sbError.ToString() != "")
                    throw new(v_sbError.ToString());
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void Tim_Kiem_By_Key()
        {
            string v_strKey_Word = txtNoi_Dung_Tim_Kiem.Text;
            List<CXNK_Nhap_Kho> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.So_Phieu_Nhap.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)
                                                         || it.Ma_NCC.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_NCC.ToLower().Contains(v_strKey_Word)
                                                         || it.Trang_Thai_Nhap_Kho_Text.ToLower().Contains(v_strKey_Word)
                                                         || it.Tong_SL.ToString().ToLower().Contains(v_strKey_Word)
                                                         || it.Tong_Tri_Gia.ToString().ToLower().Contains(v_strKey_Word)

             ).ToList();
            }
            grdData.DataSource = v_arrData_Temp;
        }

        protected override void Combobox_Selected_Index_Changed()
        {
            g_lngChu_Hang_ID = CUtility.Convert_To_Int64(cbbChu_Hang.SelectedValue);
            g_lngKho_ID = CUtility.Convert_To_Int64(cbbKho.SelectedValue);
        }

        protected override void Delete_Data(long p_lngAuto_ID)
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Nhap_Kho_Controller v_objCtrlNK = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlNK_Raw = new();

            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                CNhap_Kho_Common.Xoa_Phieu_Nhap(v_conn, v_trans, v_objCtrlNK, v_objCtrlNK_Raw, p_lngAuto_ID, User_Name, Function_Code);

                v_trans.Commit();
            }
            catch (Exception ex)
            {
                if (v_trans != null)
                    v_trans.Rollback();
                throw ex;
            }
            finally
            {
                if (v_trans != null)
                    v_trans.Dispose();

                if (v_conn != null)
                    v_conn.Close();
            }
        }

        private void Open_Update_Detail(long p_lngAuto_ID)
        {
            FXNK_001_03_Update_NK_Details_Edit v_objEdit = new();
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.g_lngKho_ID = g_lngKho_ID;
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit.ShowDialog();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem cột được click 
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy giá trị của cột Auto_ID từ hàng được click
                long v_lngAuto_ID = CUtility.Convert_To_Int64(g_grdData.Rows[e.RowIndex].Cells["Auto_ID"].Value);

                string v_strCol_Name = g_grdData.Columns[e.ColumnIndex].Name;

                switch (v_strCol_Name)
                {
                    case "btnUpdate_Detail_Phieu_Nhap":
                        Open_Update_Detail(v_lngAuto_ID);
                        break;
                }
                if (v_lngAuto_ID != CConst.INT_VALUE_NULL)
                    Load_Data();
            }
        }

        protected override void Open_Print_Data(long p_lngAuto_ID)
        {
            rptNK_Phieu_Nhap_Hang v_report = new();
            v_report.Parameters["Auto_ID"].Value = p_lngAuto_ID;
            v_report.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            XtraReport1 v_report = new();
            long[] v_arrNK_ID = g_dicCheck.Values.ToArray();
            v_report.Parameters["p_arrNhap_kho_ID"].Value = v_arrNK_ID;
            v_report.Parameters["p_arrNhap_kho_ID"].Visible = false;

            v_report.ShowPreviewDialog();
        }

        private void btnNhap_Hang_Click(object sender, EventArgs e)
        {
            Start_Loading();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Nhap_Kho_Controller v_objCtrlData = new();
            CXNK_Nhap_Kho v_objData = new();
            long v_iCount_Success = CConst.INT_VALUE_NULL;
            string v_strError = CConst.STR_VALUE_NULL;
            string v_strRes = CConst.STR_VALUE_NULL;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                long[] v_arrNK_ID = g_dicCheck.Values.ToArray();

                if (v_arrNK_ID.Count() == CConst.INT_VALUE_NULL)
                    throw new Exception("Vui lòng chọn phiếu.");

                for (int i = 0; i < v_arrNK_ID.Length; i++)
                {
                    try
                    {
                        v_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(v_conn, v_trans, v_arrNK_ID[i]);

                        if (v_objData == null)
                            throw new Exception($"Phiếu nhập không tồn tại");

                        if (v_objData.Trang_Thai_Nhap_Kho_ID != (int)ETrang_Thai_Nhap_Kho.New)
                            throw new Exception($"Phiếu nhập [{v_objData.So_Phieu_Nhap}] khác trạng thái kế hoạch");

                        //Gửi mail cho ncc là hàng đã được nhập
                        CDM_NCC v_objNCC = CCache_NCC.Get_Data_By_ID(v_objData.NCC_ID);
                        CDM_Kho v_objKho = CCache_Kho.Get_Data_By_ID(g_lngKho_ID);
                        CDM_Chu_Hang v_objCH = CCache_Chu_Hang.Get_Data_By_ID(g_lngChu_Hang_ID);

                        if (v_objNCC != null && v_objCH != null && v_objKho != null)
                        {
                            DateTime v_dtmStart = DateTime.Now;
                            string v_strSubject = "[Quản Lý Kho] xác nhận. \n";
                            string v_strMess = $"Hàng của bạn đã được nhập vào kho {v_objKho.Ma_Kho} với chủ hàng {v_objCH.Ma_CH}. \n";
                            string v_strAttach = "";

                            if (v_objNCC.Email != CConst.STR_VALUE_NULL)
                            {
                                if (CUtility.Send_Mail_Use_SMTP(v_objNCC.Email, v_strSubject, v_strMess, v_strAttach))
                                {
                                    v_strRes = $"Gửi mail thành công cho nhà cung cấp {v_objNCC.Ma_NCC}";
                                    CLogger.Save_Trace_Log("SendMail", Function_Code, "btnNhap_Hang_Click", "", (DateTime.Now - v_dtmStart).TotalSeconds);
                                }
                            }

                            if (v_objCH.Email != CConst.STR_VALUE_NULL)
                            {
                                if (CUtility.Send_Mail_Use_SMTP(v_objCH.Email, v_strSubject, v_strMess, v_strAttach))
                                {
                                    v_strRes = "Gửi mail thành công cho chủ hàng";
                                    CLogger.Save_Trace_Log("SendMail", Function_Code, "btnNhap_Hang_Click", "", (DateTime.Now - v_dtmStart).TotalSeconds);
                                }
                            }
                        }


                        v_objData.Trang_Thai_Nhap_Kho_ID = (int)ETrang_Thai_Nhap_Kho.Da_Nhan;
                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        v_objCtrlData.FQ_718_NK_sp_upd_Update_Status_NK(v_conn, v_trans, v_objData);

                        v_iCount_Success++;
                    }
                    catch (Exception ex)
                    {
                        v_strError += ex.Message + "\n";
                    }
                }

                if (v_strError != CConst.STR_VALUE_NULL)
                    throw new Exception(v_strError);

                v_trans.Commit();

                End_Loading();
                v_strRes += $"Nhập kho với {v_iCount_Success} phiếu thành công.";
                FCommonFunction.Show_Message_Box("Thông báo", v_strRes, (int)EMessage_Type.Success);
                Load_Data();
            }
            catch (Exception ex)
            {

                if (v_trans != null)
                    v_trans.Rollback();

                End_Loading();
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);

            }
            finally
            {
                if (v_conn != null)
                    v_conn.Close();

                if (v_trans != null)
                    v_trans.Dispose();
            }
        }
    }
}

