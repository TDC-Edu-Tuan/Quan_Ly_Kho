using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Utility;


namespace Quan_Ly_Kho_DM
{
    public partial class FDM_03_02_San_Pham_View : FBase
    {
        private CDM_San_Pham m_objData = new();

        public FDM_03_02_San_Pham_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_San_Pham_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_165_SP_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Đặt giá trị và thuộc tính ReadOnly cho các TextBox
            txtMa_SP.Text = m_objData.Ma_SP;
            txtMa_SP.ReadOnly = true;

            txtTen_SP.Text = m_objData.Ten_SP;
            txtTen_SP.ReadOnly = true;

            txtDVT.Text = m_objData.Ten_Don_Vi_Tinh;
            txtDVT.ReadOnly = true;

            txtMa_LSP.Text = m_objData.Ma_LSP;
            txtMa_LSP.ReadOnly = true;

            txtTen_LSP.Text = m_objData.Ten_LSP;
            txtTen_LSP.ReadOnly = true;

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
