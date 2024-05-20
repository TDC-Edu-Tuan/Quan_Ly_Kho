using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Ton_Kho;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Ton_Kho.Ton_Kho
{
    public partial class FXNK_001_02_Hieu_Chinh_Lo_Hang : FBase
    {
        private CXNK_Ton_Kho m_objData = new();
        private List<CDM_San_Pham> m_arrSP = new();

        public FXNK_001_02_Hieu_Chinh_Lo_Hang()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {
            m_arrSP = CCache_San_Pham.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            FControl_San_Pham_Combo.Load_Combo(cbbSan_Pham, m_arrSP, "Auto_ID", "San_Pham_Combo");
        }

        protected override void Load_Data()
        {
            CXNK_Ton_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_722_TK_sp_sel_Get_By_ID(g_lngAuto_ID);

            g_bIs_Update = true;

            txtSL.Text = m_objData.So_Luong.ToString();
            cbbSan_Pham.SelectedValue = m_objData.San_Pham_ID;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
        }

        protected override void Update_Data()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                m_objData.San_Pham_ID = CUtility.Convert_To_Int64(cbbSan_Pham.SelectedValue);
                m_objData.Ghi_Chu = txtGhi_Chu.Text;
                m_objData.Last_Updated_By = User_Name;
                m_objData.Last_Updated_By_Function = Function_Code;


                CTon_Kho_Common.Update_Ton_Kho(v_conn, v_trans, m_objData);

                v_trans.Commit();
            }
            catch (Exception ex)
            {
                if (v_trans != null) { v_trans.Rollback(); }

                throw ex;

            }
            finally
            {
                if (v_trans != null) { v_trans.Dispose(); }

                if (v_conn != null) { v_conn.Close(); }


            }
        }
        protected override void Closed_Form()
        {
            Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
