using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_07_02_Noi_Xuat_Den_View : FBase
    {
        private CDM_Noi_Xuat_Den m_objData = new();

        public FDM_07_02_Noi_Xuat_Den_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Noi_Xuat_Den_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_130_NXD_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Gán giá trị từ đối tượng m_objData vào các TextBox tương ứng và đặt thuộc tính ReadOnly
            txtMa_Noi_Xuat_Den.Text = m_objData.Ma_NXD;
            txtMa_Noi_Xuat_Den.ReadOnly = true;

            txtTen_Noi_Xuat_Den.Text = m_objData.Ten_NXD;
            txtTen_Noi_Xuat_Den.ReadOnly = true;

            txtDia_Chi_Noi_Xuat_Den.Text = m_objData.Dia_Chi;
            txtDia_Chi_Noi_Xuat_Den.ReadOnly = true;

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
