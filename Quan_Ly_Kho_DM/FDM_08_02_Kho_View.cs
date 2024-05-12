using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_08_02_Kho_View : FBase
    {
        private CDM_Kho m_objData = new();

        public FDM_08_02_Kho_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_114_K_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Gán giá trị từ đối tượng m_objData vào các TextBox tương ứng và đặt thuộc tính ReadOnly
            txtMa_Kho.Text = m_objData.Ma_Kho;
            txtMa_Kho.ReadOnly = true;

            txtTen_Kho.Text = m_objData.Ten_Kho;
            txtTen_Kho.ReadOnly = true;

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
