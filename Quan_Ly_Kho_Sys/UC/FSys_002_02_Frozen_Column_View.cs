using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Sys;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Sys
{
    public partial class FSys_002_02_Frozen_Column_View : FBase
    {
        private CSys_Frozen_Column m_objData = new();

        public FSys_002_02_Frozen_Column_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CSys_Frozen_Column_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_513_FC_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            txtMa_Chuc_Nang.Text = m_objData.Ma_Chuc_Nang;
            txtFrozen_Col.Text = m_objData.Ten_Cot_Frozen;
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
