using Quan_Ly_Kho_Xuat_Kho.Xuat_Kho;

namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_001_03_Ke_Hoach_Xuat_Edit : FBase
    {
        private CXNK_Xuat_Kho m_objData = new();
        private List<CXNK_Xuat_Kho_Raw_Data> m_arrRaw = new();
        private List<CDM_NCC> m_arrNCC = new();
        public FXNK_001_03_Ke_Hoach_Xuat_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {
            g_grdData = grdData; // Tham chiếu

            g_arrCol_Hiden.Add("So_Phieu_Xuat");
            g_arrCol_Hiden.Add("Xuat_Kho_ID");
            g_arrCol_Hiden.Add("San_Pham_ID");

            g_dicCol_Name.Add("So_Luong", "Số Lượng");
            g_dicCol_Name.Add("Don_Gia", "Đơn Giá");
            g_dicCol_Name.Add("Tri_Gia", "Trị Giá");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");
            g_dicCol_Name.Add("Ma_SP", "Mã Sản Phẩm");
            g_dicCol_Name.Add("Ten_SP", "Tên Sản Phẩm");

            g_dicCol_Size.Add("So_Luong", 100);
            g_dicCol_Size.Add("Don_Gia", 100);
            g_dicCol_Size.Add("Tri_Gia", 100);
            g_dicCol_Size.Add("Ghi_Chu", 400);
            g_dicCol_Size.Add("Ma_SP", 200);
            g_dicCol_Size.Add("Ten_SP", 300);

            g_dicCol_Index.Add("Ma_SP", 1);
            g_dicCol_Index.Add("Ten_SP", 2);

            Disable_Default_Col();

            m_arrNCC = CCache_NCC.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            FControl_NCC_Combo.Load_Combo(cbbNXD, m_arrNCC, "Auto_ID", "NCC_Combo");
        }

        protected override void Load_Data()
        {
            Format_Grid(m_arrRaw);
        }

        protected override void Add_Data()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Xuat_Kho_Controller v_objCtrlData = new();
            CXNK_Xuat_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                //Map data
                m_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
                m_objData.Kho_ID = g_lngKho_ID;
                m_objData.So_Phieu_Xuat = txtSo_Phieu_Xuat.Text;
                m_objData.Ngay_Xuat_Kho = dtmNgay_Xuat_kho.Value;
                m_objData.NXD_ID = CUtility.Convert_To_Int64(cbbNXD.SelectedValue);
                m_objData.Ghi_Chu = txtGhi_Chu.Text;
                m_objData.Trang_Thai_XK_ID = (int)ETrang_Thai_Xuat_Kho.New;
                m_objData.Details = m_arrRaw.ToList();

                m_objData.Last_Updated_By = User_Name;
                m_objData.Last_Updated_By_Function = Function_Code;

                CXuat_Kho_Common.Auto_Tao_Phieu(v_conn, v_trans, v_objCtrlData, v_objCtrlRaw_Data, m_objData);

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
                if (v_conn != null)
                    v_conn.Close();

                if (v_trans != null)
                    v_trans.Dispose();

            }
        }

        protected override void Closed_Form()
        {
            Close();
        }

        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FXNK_001_03_Them_Detail_Xuat_Kho_Edit v_objEdit_Detail = new();
            v_objEdit_Detail.p_arrPara_Raw_Data = m_arrRaw;
            v_objEdit_Detail.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit_Detail.g_lngKho_ID = g_lngKho_ID;
            v_objEdit_Detail.ShowDialog();
        }
    }
}