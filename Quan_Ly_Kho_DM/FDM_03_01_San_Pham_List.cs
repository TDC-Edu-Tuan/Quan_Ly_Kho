using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;
using System.Text;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_03_01_San_Pham_List : UCBase
    {
        private List<CDM_San_Pham> m_arrData = new();

        public FDM_03_01_San_Pham_List()
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
            g_arrCol_Hiden.Add("DVT_ID");
            g_arrCol_Hiden.Add("LSP_ID");

            g_dicCol_Name.Add("Ma_SP", "Mã SP");
            g_dicCol_Name.Add("Ten_SP", "Tên SP");
            g_dicCol_Name.Add("Ma_LSP", "Mã LSP");
            g_dicCol_Name.Add("Ten_LSP", "Tên LSP");
            g_dicCol_Name.Add("Ten_Don_Vi_Tinh", "DVT");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");

            g_dicCol_Size.Add("Ma_SP", 200);
            g_dicCol_Size.Add("Ten_SP", 300);
            g_dicCol_Size.Add("Ma_LSP", 200);
            g_dicCol_Size.Add("Ten_LSP", 300);
            g_dicCol_Size.Add("Ten_Don_Vi_Tinh", 300);
            g_dicCol_Size.Add("Ghi_Chu", 500);


            FControl_Chu_Hang_User_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_User_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");

            cbbChu_Hang.SelectedValue = g_lngChu_Hang_ID;
            cbbKho.SelectedValue = g_lngKho_ID;
        }

        protected override void Load_Data()
        {
            CDM_San_Pham_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_165_SP_sp_sel_List_By_Created(g_lngChu_Hang_ID, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FDM_03_03_San_Pham_Edit v_objEdit = new();
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;

            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.ShowDialog();
        }

        //Hàm đc gọi khi ấn vào nút view
        protected override void Open_View_Data(long p_lngAuto_ID)
        {
            FDM_03_02_San_Pham_View v_objView = new();
            v_objView.g_lngAuto_ID = p_lngAuto_ID;
            v_objView.Show();
        }

        protected override void Import_Excel_Entry(CExcel_Controller v_objCtrlExcel, ref int p_iCount_Success, ref int p_iCount_Error)
        {
            CDM_San_Pham_Controller v_objCtrData = new();
            CDM_Don_Vi_Tinh v_objDVT = new();
            CDM_Loai_San_Pham v_objLSP = new();
            StringBuilder v_sbError = new StringBuilder();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            try
            {
                DataTable v_dt = v_objCtrlExcel.List_Range_Value_To_End(0, "A2", "F");

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
                        CDM_San_Pham v_objData = new CDM_San_Pham();
                        v_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
                        v_objData.Ma_SP = CUtility.Convert_To_String(v_row[0]);
                        v_objData.Ten_SP = CUtility.Convert_To_String(v_row[1]);

                        string v_strDVT = CUtility.Convert_To_String(v_row[2]);
                        if (v_strDVT == CConst.STR_VALUE_NULL)
                            throw new Exception("Đơn vị tính không được rỗng");

                        v_objDVT = CCache_Don_Vi_Tinh.Get_Data_By_Code(v_strDVT);
                        if (v_objDVT == null)
                            throw new Exception("Đơn vị tính không tồn tại");

                        string v_strLSP = CUtility.Convert_To_String(v_row[3]);

                        if (v_strLSP == CConst.STR_VALUE_NULL)
                            throw new Exception("Loại sản phẩm không được rỗng");

                        v_objLSP = CCache_Loai_San_Pham.Get_Data_By_Code(g_lngChu_Hang_ID, v_strLSP);
                        if (v_objDVT == null)
                            throw new Exception("Loại sản phẩm không tồn tại");

                        v_objData.DVT_ID = v_objDVT.Auto_ID;
                        v_objData.LSP_ID = v_objLSP.Auto_ID;

                        v_objData.Ghi_Chu = CUtility.Convert_To_String(v_row[4]);
                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        v_objData.Auto_ID = v_objCtrData.FQ_165_SP_sp_ins_Insert(v_conn, v_trans, v_objData);

                        v_objData = v_objCtrData.FQ_165_SP_sp_sel_Get_By_ID(v_conn, v_trans, v_objData.Auto_ID);

                        p_iCount_Success++;

                        v_trans.Commit();

                        CCache_San_Pham.Add_Data(v_objData);
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
            List<CDM_San_Pham> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.Ma_LSP.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_LSP.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_Don_Vi_Tinh.ToLower().Contains(v_strKey_Word)
                                                         || it.Ma_SP.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_SP.ToLower().Contains(v_strKey_Word)



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
            CDM_San_Pham_Controller v_objCtrlData = new();
            v_objCtrlData.FQ_165_SP_sp_del_Delete_By_ID(p_lngAuto_ID, User_Name, Function_Code);

            CCache_San_Pham.Delete_Data(p_lngAuto_ID);
        }
    }
}
