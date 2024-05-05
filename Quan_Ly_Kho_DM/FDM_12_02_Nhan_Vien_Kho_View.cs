using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_12_02_Nhan_Vien_Kho_View : FBase
    {
        private CDM_Nhan_Vien_Kho m_objData = new();

        public FDM_12_02_Nhan_Vien_Kho_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Nhan_Vien_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_127_NVK_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            txtMa_Nhan_Vien_Kho.Text = m_objData.Ma_NV;
            txtTen_Nhan_Vien_Kho.Text = m_objData.Ten_NV;
            txtGioi_Tinh.Text = m_objData.Gioi_Tinh;
            txtSDT.Text = m_objData.Dien_Thoai;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
            txtDia_Chi.Text = m_objData.Dia_Chi;
            txtCCCD.Text = m_objData.Ghi_Chu;

            Created.Text = CUtility.Convert_DateTime_To_String(m_objData.Created);
            Created_By.Text = m_objData.Created_By;
            Created_By_Function.Text = m_objData.Created_By_Function;

            Last_Updated.Text = CUtility.Convert_DateTime_To_String(m_objData.Last_Updated);
            Last_Updated_By.Text = m_objData.Last_Updated_By;
            Last_Updated_By_Function.Text = m_objData.Last_Updated_By_Function;
        }
    }
}
