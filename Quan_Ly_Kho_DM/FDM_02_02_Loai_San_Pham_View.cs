using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_02_02_Loai_San_Pham_View : FBase
    {
        private CDM_Loai_San_Pham m_objData = new();

        public FDM_02_02_Loai_San_Pham_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Loai_San_Pham_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_122_LSP_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            txtMa_LSP.Text = m_objData.Ma_LSP;
            txtTen_LSP.Text = m_objData.Ten_LSP;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

            Created.Text = CUtility.Convert_DateTime_To_String(m_objData.Created);
            Created_By.Text = m_objData.Created_By;
            Created_By_Function.Text = m_objData.Created_By_Function;

            Last_Updated.Text = CUtility.Convert_DateTime_To_String(m_objData.Last_Updated);
            Last_Updated_By.Text = m_objData.Last_Updated_By;
            Last_Updated_By_Function.Text = m_objData.Last_Updated_By_Function;
        }
    }
}
