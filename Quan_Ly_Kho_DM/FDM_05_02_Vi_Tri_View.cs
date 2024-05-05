using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_05_02_Vi_Tri_View : FBase
    {
        private CDM_Vi_Tri m_objData = new();

        public FDM_05_02_Vi_Tri_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Vi_Tri_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_175_VT_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            txtMa_Vi_Tri.Text = m_objData.Ma_Vi_Tri;
            txtTen_Vi_Tri.Text = m_objData.Ten_Vi_Tri;
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
