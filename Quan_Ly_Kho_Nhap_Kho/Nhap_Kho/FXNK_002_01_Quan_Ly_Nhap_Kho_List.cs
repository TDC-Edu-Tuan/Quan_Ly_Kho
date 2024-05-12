namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_002_01_Quan_Ly_Nhap_Kho_List : UCBase
    {
        private List<CXNK_Nhap_Kho> m_arrData = new();

        public FXNK_002_01_Quan_Ly_Nhap_Kho_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = true;
            g_bIs_Updated_Permission = true;
            g_bIs_Deleted_Permission = true;
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
            m_arrData = v_ctrlData.FQ_718_NK_sp_sel_List_By_Created(g_lngChu_Hang_ID, g_lngKho_ID, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

            string v_strSettings_Icon_Path = CUtility.Find_File_In_Solution("tranfer.png");
            Image v_objSetting_Icon = Image.FromFile(v_strSettings_Icon_Path);
            DataGridViewImageColumn v_objSet_Col = new();
            Add_Button_Column("btnChuyen_Hang", v_objSet_Col, 2, v_objSetting_Icon);
            g_grdData.Columns["btnChuyen_Hang"].Visible = g_bIs_Updated_Permission;
            g_grdData.Columns["btnChuyen_Hang"].HeaderText = "Chuyển hàng";
            Col_Custom(g_grdData.Columns["btnChuyen_Hang"]);
        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FXNK_001_03_Update_Info_Phieu_Nhap_Edit v_objEdit = new();
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.g_lngKho_ID = g_lngKho_ID;
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;

            v_objEdit.ShowDialog();
        }

        //Hàm đc gọi khi ấn vào nút view
        protected override void Open_View_Data(long p_lngAuto_ID)
        {
            FXNK_001_02_Ke_Hoach_Nhap_View v_objView = new();
            v_objView.g_lngAuto_ID = p_lngAuto_ID;
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

        private void Chuyen_Hang_Vao_Ton(long p_lngAuto_ID)
        {
            FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke v_objEdit = new();
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.g_lngKho_ID = g_lngKho_ID;
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
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
                    case "btnChuyen_Hang":
                        Chuyen_Hang_Vao_Ton(v_lngAuto_ID);
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

        //private void btnIn_Click(object sender, EventArgs e)
        //{
        //    XtraReport1 v_report = new();
        //    long[] v_arrNK_ID = g_dicCheck.Values.ToArray();
        //    v_report.Parameters["p_arrNhap_kho_ID"].Value = v_arrNK_ID;
        //    v_report.ShowPreviewDialog();
        //}
    }
}

