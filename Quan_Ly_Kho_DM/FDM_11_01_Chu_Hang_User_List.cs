using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;
using System.Data;
using System.Text;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_11_01_Chu_Hang_User_List : UCBase
    {
        private List<CDM_Chu_Hang_User> m_arrData = new();
        private List<CDM_Chu_Hang> m_arrCH = new();
        public FDM_11_01_Chu_Hang_User_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = false;
            g_bIs_Updated_Permission = false;
            g_bIs_Deleted_Permission = true;

            // Chuyển đổi mã màu hex thành màu Color
            Color navColor = ColorTranslator.FromHtml("#d8bfd8");

            // Đặt màu nền cho panel2
            panel2.BackColor = navColor;
        }

        protected override void Load_Init()
        {
            dtmFrom.Value = CUtility_Date.Convert_To_Dau_Ngay(DateTime.Now.AddDays(-999));
            dtmTo.Value = CUtility_Date.Convert_To_Cuoi_Ngay(DateTime.Now);

            g_grdData = grdData; //Để tham chiếu tới export excel
            Disable_Default_Col();

            g_arrCol_Hiden.Add("Chu_Hang_Combo");
            g_arrCol_Hiden.Add("Thanh_Vien_ID");

            g_arrCol_Hiden.Add("Ten_CH");
            g_arrCol_Hiden.Add("Ma_CH");

            g_dicCol_Name.Add("Ma_CH", "Mã Chủ Hàng");

            g_dicCol_Name.Add("Ten_CH", "Tên Chủ Hàng");
            g_dicCol_Name.Add("Ma_Dang_Nhap", "Mã Đăng Nhập");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");

            g_dicCol_Size.Add("Ma_CH", 200);
            g_dicCol_Size.Add("Ten_CH", 300);
            g_dicCol_Size.Add("Ma_Dang_Nhap", 100);
            g_dicCol_Size.Add("Ghi_Chu", 500);


            FControl_Chu_Hang_User_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_User_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");

            cbbChu_Hang.SelectedValue = g_lngChu_Hang_ID;
            cbbKho.SelectedValue = g_lngKho_ID;
            m_arrCH = CCache_Chu_Hang.List_Data();

            FControl_Chu_Hang_Combo.Load_Combo(cbbCH_User, m_arrCH, "Auto_ID", "Chu_Hang_Combo");
        }

        protected override void Load_Data()
        {
            CDM_Chu_Hang_User_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_107_CHU_sp_sel_List_By_Created(g_lngChu_Hang_ID, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

            grdData.DataSource = m_arrData;


        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FDM_11_02_Chu_Hang_User_Edit v_objEdit = new();
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.ShowDialog();
        }

        protected override void Import_Excel_Entry(CExcel_Controller v_objCtrlExcel, ref int p_iCount_Success, ref int p_iCount_Error)
        {
            CDM_Chu_Hang_User_Controller v_objCtrData = new();

            CDM_Chu_Hang v_objCH = new();
            CSys_Thanh_Vien v_objTV = new();

            StringBuilder v_sbError = new StringBuilder();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            try
            {
                DataTable v_dt = v_objCtrlExcel.List_Range_Value_To_End(0, "A2", "B");

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
                        CDM_Chu_Hang_User v_objData = new CDM_Chu_Hang_User();

                        string v_strMa_Dang_Nhap = CUtility.Convert_To_String(v_row[0]);

                        v_strMa_Dang_Nhap = v_strMa_Dang_Nhap.Trim();
                        if (v_strMa_Dang_Nhap == CConst.STR_VALUE_NULL)
                            throw new("Mã đăng nhập không được để trống");

                        v_objTV = CCache_Thanh_Vien.Get_Data_By_Code(v_strMa_Dang_Nhap);
                        if (v_objTV == CConst.OBJ_VALUE_NULL)
                            throw new("Mã đăng nhập không tồn tại");

                        string v_strMa_CH = CUtility.Convert_To_String(v_row[1]);

                        v_strMa_CH = v_strMa_CH.Trim();
                        if (v_strMa_CH == CConst.STR_VALUE_NULL)
                            throw new("Mã chủ hàng không được để trống");

                        v_objCH = CCache_Chu_Hang.Get_Data_By_Code(v_strMa_CH);
                        if (v_objCH == CConst.OBJ_VALUE_NULL)
                            throw new("Mã chủ hàng không tồn tại");

                        v_objData.Chu_Hang_ID = v_objCH.Auto_ID;
                        v_objData.Thanh_Vien_ID = v_objTV.Auto_ID;

                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        v_objData.Auto_ID = v_objCtrData.FQ_107_CHU_sp_ins_Insert(v_conn, v_trans, v_objData);

                        v_objCtrData.FQ_107_CHU_sp_sel_Get_By_ID(v_conn, v_trans, v_objData.Auto_ID);

                        p_iCount_Success++;
                        v_trans.Commit();

                        CCache_Chu_Hang_User.Add_Data(v_objData);
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
            List<CDM_Chu_Hang_User> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.Ma_Dang_Nhap.ToLower().Contains(v_strKey_Word)).ToList();
            }
            grdData.DataSource = v_arrData_Temp;
        }

        protected override void Combobox_Selected_Index_Changed()
        {
            g_lngChu_Hang_ID = CUtility.Convert_To_Int64(cbbChu_Hang.SelectedValue);
            g_lngKho_ID = CUtility.Convert_To_Int64(cbbKho.SelectedValue);
        }

        private void cbbCH_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_lngChu_Hang_ID = CUtility.Convert_To_Int64(cbbCH_User.SelectedValue);
            Load_Data();
        }

        protected override void Delete_Data(long p_lngAuto_ID)
        {
            CDM_Chu_Hang_User_Controller v_objCtrlData = new();
            v_objCtrlData.FQ_107_CHU_sp_del_Delete_By_ID(p_lngAuto_ID, User_Name, Function_Code);

            CCache_Chu_Hang_User.Delete_Data(p_lngAuto_ID);
        }
    }
}
