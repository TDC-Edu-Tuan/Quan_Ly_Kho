﻿using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Controller.Xuat_Kho;
using Quan_Ly_Kho_Data_Access.Data.Xuat_kho;
using Quan_Ly_Kho_Xuat_Kho.Xuat_Kho;

namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_001_01_Ke_Hoach_Xuat_List : UCBase
    {
        private List<CXNK_Xuat_Kho> m_arrData = new();

        public FXNK_001_01_Ke_Hoach_Xuat_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = true;
            g_bIs_Updated_Permission = true;
            g_bIs_Deleted_Permission = true;
            g_bIs_Print_Permission = false;


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

            g_arrCol_Hiden.Add("NXD_ID");
            g_arrCol_Hiden.Add("Trang_Thai_XK_ID");
            //g_arrCol_Hiden.Add("Trang_Thai_Xuat_Kho_Text");

            g_dicCol_Name.Add("Ma_NXD", "Mã NXD");
            g_dicCol_Name.Add("Ten_NXD", "Tên NXD");
            g_dicCol_Name.Add("So_Phieu_Xuat", "Số Phiếu Xuất");
            g_dicCol_Name.Add("Ngay_Xuat_Kho", "Ngày Xuất Kho");
            g_dicCol_Name.Add("Tong_SL", "Tổng SL");
            g_dicCol_Name.Add("Tong_Tri_Gia", "Tổng Trị Giá");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");
            g_dicCol_Name.Add("Trang_Thai_XK_Text", "Trạng Thái");


            g_dicCol_Size.Add("So_Phieu_Xuat", 200);
            g_dicCol_Size.Add("Ma_NXD", 100);
            g_dicCol_Size.Add("Ten_NXD", 200);
            g_dicCol_Size.Add("Ngay_Xuat_Kho", 100);
            g_dicCol_Size.Add("Tong_SL", 50);
            g_dicCol_Size.Add("Tong_Tri_Gia", 50);
            g_dicCol_Size.Add("Ghi_Chu", 300);

            g_dicCol_Index.Add("Ma_NXD", 5);
            g_dicCol_Index.Add("Ten_NXD", 6);

            FControl_Chu_Hang_User_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_User_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");
            cbbChu_Hang.SelectedValue = g_lngChu_Hang_ID;
            cbbKho.SelectedValue = g_lngKho_ID;
        }

        protected override void Load_Data()
        {
            CXNK_Xuat_Kho_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_728_XK_sp_sel_List_By_Created_Trang_Thai_XK_ID(g_lngChu_Hang_ID, g_lngKho_ID, (int)ETrang_Thai_Xuat_Kho.New, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

            string v_strSettings_Icon_Path = CUtility.Find_File_In_Solution("settings.png");
            Image v_objSetting_Icon = Image.FromFile(v_strSettings_Icon_Path);
            DataGridViewImageColumn v_objSet_Col = new();
            Add_Button_Column("btnUpdate_Detail_Phieu_Xuat", v_objSet_Col, 2, v_objSetting_Icon);
            g_grdData.Columns["btnUpdate_Detail_Phieu_Xuat"].Visible = g_bIs_Updated_Permission;
            g_grdData.Columns["btnUpdate_Detail_Phieu_Xuat"].HeaderText = "Chi tiết";
            Col_Custom(g_grdData.Columns["btnUpdate_Detail_Phieu_Xuat"]);
        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            if (p_lngAuto_ID == CConst.INT_VALUE_NULL)
            {
                FXNK_001_03_Ke_Hoach_Xuat_Edit v_objEdit = new();
                v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
                v_objEdit.g_lngKho_ID = g_lngKho_ID;
                v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
                v_objEdit.User_Name = User_Name;
                v_objEdit.Function_Code = Function_Code;

                v_objEdit.ShowDialog();
            }
            else
            {
                FXNK_001_03_Update_Info_Phieu_Xuat_Edit v_objEdit = new();
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
            FXNK_001_02_Ke_Hoach_Xuat_View v_objView = new();
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
            List<CXNK_Xuat_Kho> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.So_Phieu_Xuat.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)
                                                         || it.Ma_NXD.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_NXD.ToLower().Contains(v_strKey_Word)
                                                         || it.Trang_Thai_XK_Text.ToLower().Contains(v_strKey_Word)
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

            CXNK_Xuat_Kho_Controller v_objCtrlNK = new();
            CXNK_Xuat_Kho_Raw_Data_Controller v_objCtrlNK_Raw = new();

            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                 CXuat_Kho_Common.Xoa_Phieu_Xuat(v_conn, v_trans, v_objCtrlNK, v_objCtrlNK_Raw, p_lngAuto_ID, User_Name, Function_Code);

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
            FXNK_001_03_Update_XK_Details_Edit v_objEdit = new();
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
                    case "btnUpdate_Detail_Phieu_Xuat":
                        Open_Update_Detail(v_lngAuto_ID);
                        break;
                }
                if (v_lngAuto_ID != CConst.INT_VALUE_NULL)
                    Load_Data();
            }
        }

        protected override void Open_Print_Data(long p_lngAuto_ID)
        {
            //rptNK_Phieu_Xuat_Hang v_report = new();
            //v_report.Parameters["Auto_ID"].Value = p_lngAuto_ID;
            //v_report.ShowPreviewDialog();

        }



        private void btnIn_Click(object sender, EventArgs e)
        {
            //XtraReport1 v_report = new();
            //long[] v_arrNK_ID = g_dicCheck.Values.ToArray();
            //v_report.Parameters["p_arrXuat_kho_ID"].Value = v_arrNK_ID;
            //v_report.ShowPreviewDialog();
        }

        private void btnPick_Hang_Click(object sender, EventArgs e)
        {
            Start_Loading();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Xuat_Kho_Controller v_objCtrlData = new();
            CXNK_Xuat_Kho_Raw_Data_Controller v_objCtrlRawData = new();
            CXNK_Ton_Kho_Controller v_oblCtrl_TK = new();
            CXNK_Xuat_Kho v_objData = new();
            long v_iCount_Success = CConst.INT_VALUE_NULL;
            string v_strError = "";
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
                        v_objData = v_objCtrlData.FQ_728_XK_sp_sel_Get_By_ID(v_conn, v_trans, v_arrNK_ID[i]);

                        if (v_objData == null)
                            throw new Exception($"Phiếu xuất không tồn tại");

                        if (v_objData.Trang_Thai_XK_ID != (int)ETrang_Thai_Xuat_Kho.New)
                            throw new Exception($"Phiếu xuất [{v_objData.So_Phieu_Xuat}] khác trạng thái kế hoạch");

                         v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;
                        v_objData.Details = v_objCtrlRawData.FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID(v_conn, v_trans, v_arrNK_ID[i]);
                     
                        CXuat_Kho_Common.Xuat_Kho_To_NXD_By_XK_ID(v_conn, v_trans, v_objCtrlData, v_objCtrlRawData, v_oblCtrl_TK,v_objData);

                        v_objData.Trang_Thai_XK_ID = (int)ETrang_Thai_Xuat_Kho.Shipped;
                        v_objCtrlData.FQ_728_NK_sp_upd_Update_Status_XK(v_conn, v_trans, v_objData);

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

                FCommonFunction.Show_Message_Box("Thông báo", $"Xuất hàng với {v_iCount_Success} phiếu thành công.", (int)EMessage_Type.Success);
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

