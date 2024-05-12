using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_06_02_NCC_View : FBase
    {
        private CDM_NCC m_objData = new();

        public FDM_06_02_NCC_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_NCC_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_123_N_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Đặt giá trị và thuộc tính ReadOnly cho các TextBox
            txtMa_NCC.Text = m_objData.Ma_NCC;
            txtMa_NCC.ReadOnly = true;

            txtTen_NCC.Text = m_objData.Ten_NCC;
            txtTen_NCC.ReadOnly = true;

            txtDia_Chi_NCC.Text = m_objData.Dia_Chi;
            txtDia_Chi_NCC.ReadOnly = true;

            txtSDT.Text = m_objData.Dien_Thoai;
            txtSDT.ReadOnly = true;

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
