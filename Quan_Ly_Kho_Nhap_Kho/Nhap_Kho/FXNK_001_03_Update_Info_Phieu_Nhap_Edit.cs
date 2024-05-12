namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    public partial class FXNK_001_03_Update_Info_Phieu_Nhap_Edit : FBase
    {
        private CXNK_Nhap_Kho m_objData = new();
        private List<CDM_NCC> m_arrNCC = new();

        public FXNK_001_03_Update_Info_Phieu_Nhap_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {

            m_arrNCC = CCache_NCC.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            FControl_NCC_Combo.Load_Combo(cbbNCC, m_arrNCC, "Auto_ID", "NCC_Combo");
        }

        protected override void Load_Data()
        {
            CXNK_Nhap_Kho_Controller v_objCtrlData = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

            m_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(g_lngAuto_ID);
            m_objData.Details = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(m_objData.Auto_ID);

            txtSo_Phieu_Nhap.Text = m_objData.So_Phieu_Nhap;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
            cbbNCC.SelectedValue = m_objData.NCC_ID;
            dtmNgay_Nhap_Kho.Value = m_objData.Ngay_Nhap_Kho.Value;

            g_bIs_Update = true;
        }

        protected override void Update_Data()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Nhap_Kho_Controller v_objCtrlData = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                //Map data
                m_objData.So_Phieu_Nhap = txtSo_Phieu_Nhap.Text;
                m_objData.Ngay_Nhap_Kho = dtmNgay_Nhap_Kho.Value;
                m_objData.NCC_ID = CUtility.Convert_To_Int64(cbbNCC.SelectedValue);
                m_objData.Ghi_Chu = txtGhi_Chu.Text;
                m_objData.Trang_Thai_Nhap_Kho_ID = (int)ETrang_Thai_Nhap_Kho.New;
                m_objData.Last_Updated_By = User_Name;
                m_objData.Last_Updated_By_Function = Function_Code;

                CNhap_Kho_Common.Update_Data_Phieu_Nhap(v_conn, v_trans, v_objCtrlData, v_objCtrlRaw_Data, m_objData);

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

    }
}