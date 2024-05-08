using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_04_02_Day_Ke_View : FBase
    {
        private CDM_Day_Ke m_objData = new();

        public FDM_04_02_Day_Ke_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Day_Ke_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_109_DK_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Đặt giá trị và thuộc tính ReadOnly cho các TextBox
            txtMa_Day_Ke.Text = m_objData.Ma_Ke;
            txtMa_Day_Ke.ReadOnly = true;

            txtTen_Ke.Text = m_objData.Ten_Ke;
            txtTen_Ke.ReadOnly = true;

            txtGhi_Chu.Text = m_objData.Ghi_Chu;
            txtGhi_Chu.ReadOnly = true;


            Created.Text = CUtility.Convert_DateTime_To_String(m_objData.Created);
            Created_By.Text = m_objData.Created_By;
            Created_By_Function.Text = m_objData.Created_By_Function;

            Last_Updated.Text = CUtility.Convert_DateTime_To_String(m_objData.Last_Updated);
            Last_Updated_By.Text = m_objData.Last_Updated_By;
            Last_Updated_By_Function.Text = m_objData.Last_Updated_By_Function;
        }
    }
}
