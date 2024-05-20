using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;

namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    public partial class FXNK_001_03_Update_NK_Details_Edit : FBase
    {

        private List<CXNK_Nhap_Kho_Raw_Data> m_arrData = new();

        public FXNK_001_03_Update_NK_Details_Edit()
        {
            InitializeComponent();
        }
        protected override void Load_Init()
        {
            g_grdData = grdData;

            g_arrCol_Hiden.Add("btnCheck");
            g_arrCol_Hiden.Add("Nhap_Kho_ID");
            g_arrCol_Hiden.Add("San_Pham_ID");

            Disable_Default_Col();
            g_bIs_Deleted_Permission = true;
            g_bIs_Updated_Permission = true;

            g_dicCol_Name.Add("So_Luong", "Số Lượng");
            g_dicCol_Name.Add("So_Phieu_Nhap", "Số Phiếu");
            g_dicCol_Name.Add("Don_Gia", "Đơn Giá");
            g_dicCol_Name.Add("Tri_Gia", "Trị Giá");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");
            g_dicCol_Name.Add("Ma_SP", "Mã Sản Phẩm");
            g_dicCol_Name.Add("Ten_SP", "Tên Sản Phẩm");

            g_dicCol_Size.Add("So_Luong", 100);
            g_dicCol_Size.Add("So_Phieu_Nhap", 200);
            g_dicCol_Size.Add("Don_Gia", 100);
            g_dicCol_Size.Add("Tri_Gia", 100);
            g_dicCol_Size.Add("Ghi_Chu", 300);
            g_dicCol_Size.Add("Ma_SP", 200);
            g_dicCol_Size.Add("Ten_SP", 200);

            g_dicCol_Index.Add("Ma_SP", 1);
            g_dicCol_Index.Add("Ten_SP", 2);
            g_dicCol_Index.Add("So_Phieu_Nhap", 3);
            g_dicCol_Index.Add("So_Luong", 4);
            g_dicCol_Index.Add("Don_Gia", 5);
            g_dicCol_Index.Add("Tri_Gia", 6);
        }
        protected override void Load_Data()
        {
            CXNK_Nhap_Kho_Raw_Data_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(g_lngAuto_ID);

            Format_Grid(m_arrData);
        }

        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            CXNK_Nhap_Kho_Controller v_objCtrlNK = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlNK_Raw = new();

            FXNK_001_03_Chinh_Sua_Detail_ASN_Edit v_objEdit_Detail = new();
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                v_objEdit_Detail.p_lngNhap_Kho_ID = g_lngAuto_ID;
                v_objEdit_Detail.g_lngAuto_ID = p_lngAuto_ID;
                v_objEdit_Detail.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
                v_objEdit_Detail.g_lngKho_ID = g_lngKho_ID;
                v_objEdit_Detail.User_Name = User_Name;
                v_objEdit_Detail.Function_Code = Function_Code;

                v_objEdit_Detail.ShowDialog();

                CXNK_Nhap_Kho v_objNhap_Kho = v_objCtrlNK.FQ_718_NK_sp_sel_Get_By_ID(v_conn, v_trans, g_lngAuto_ID);
                if (v_objNhap_Kho != null)
                {
                    v_objNhap_Kho.Details = v_objCtrlNK_Raw.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(v_objNhap_Kho.Auto_ID);
                    CNhap_Kho_Common.Updated_Total_Phieu_Nhap(v_conn, v_trans, v_objCtrlNK, v_objNhap_Kho);
                }

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
                if (v_trans != null) v_trans.Dispose();
                if (v_conn != null) v_conn.Close();
            }
        }

        protected override void Delete_Data(long p_lngAuto_ID)
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            CXNK_Nhap_Kho_Controller v_objCtrlNK = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlNK_Raw = new();
            CXNK_Ton_Kho_Controller v_objTK = new();
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                CNhap_Kho_Common.Xoa_Details_Phieu_Nhap(v_conn, v_trans, v_objCtrlNK, v_objCtrlNK_Raw, v_objTK, p_lngAuto_ID, User_Name, Function_Code);

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
                if (v_trans != null) v_trans.Dispose();
                if (v_conn != null) v_conn.Close();
            }
        }
    }
}
