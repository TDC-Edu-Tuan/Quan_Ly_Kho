using Quan_Ly_Kho_Data_Access.Controller.Xuat_Kho;
using Quan_Ly_Kho_Data_Access.Data.Xuat_kho;

namespace Quan_Ly_Kho_Xuat_Kho.Xuat_Kho
{
    public partial class FXNK_001_03_Update_Info_Phieu_Xuat_Edit : FBase
    {
        private CXNK_Xuat_Kho m_objData = new();
        private List<CDM_NCC> m_arrNCC = new();

        public FXNK_001_03_Update_Info_Phieu_Xuat_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {

            m_arrNCC = CCache_NCC.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            FControl_NCC_Combo.Load_Combo(cbbNXD, m_arrNCC, "Auto_ID", "NCC_Combo");
        }

        protected override void Load_Data()
        {
            CXNK_Xuat_Kho_Controller v_objCtrlData = new();
            CXNK_Xuat_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

            m_objData = v_objCtrlData.FQ_728_XK_sp_sel_Get_By_ID(g_lngAuto_ID);
            m_objData.Details = v_objCtrlRaw_Data.FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID(m_objData.Auto_ID);

            txtSo_Phieu_Xuat.Text = m_objData.So_Phieu_Xuat;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
            cbbNXD.SelectedValue = m_objData.NXD_ID;
            dtmNgay_Xuat_Kho.Value = m_objData.Ngay_Xuat_Kho.Value;

            g_bIs_Update = true;
        }

        protected override void Update_Data()
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
                m_objData.So_Phieu_Xuat = txtSo_Phieu_Xuat.Text;
                m_objData.Ngay_Xuat_Kho = dtmNgay_Xuat_Kho.Value;
                m_objData.NXD_ID = CUtility.Convert_To_Int64(cbbNXD.SelectedValue);
                m_objData.Ghi_Chu = txtGhi_Chu.Text;
                m_objData.Trang_Thai_XK_ID = (int)ETrang_Thai_Xuat_Kho.New;
                m_objData.Last_Updated_By = User_Name;
                m_objData.Last_Updated_By_Function = Function_Code;

                CXuat_Kho_Common.Update_Data_Phieu_Xuat(v_conn, v_trans, v_objCtrlData, v_objCtrlRaw_Data, m_objData);

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