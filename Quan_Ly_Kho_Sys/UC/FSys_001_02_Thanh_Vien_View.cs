using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Sys;

namespace Quan_Ly_Kho_DM
{
    public partial class FSys_001_02_Thanh_Vien_View : FBase
    {
        private CSys_Thanh_Vien m_objData = new();

        public FSys_001_02_Thanh_Vien_View()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CSys_Thanh_Vien_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_531_TV_sp_sel_Get_By_ID(g_lngAuto_ID);
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            txtMa_Dang_Nhap.Text = m_objData.Ma_Dang_Nhap;
            txtHo_Ten.Text = m_objData.Ho_Ten;
            txtGioi_Tinh.Text = m_objData.Gioi_Tinh;
            txtSDT.Text = m_objData.SDT;
            txtEmail.Text = m_objData.Email;
            txtNhom_Thanh_Vien.Text = m_objData.Nhom_Thanh_Vien_Text;

            Created.Text = CUtility.Convert_DateTime_To_String(m_objData.Created);
            Created_By.Text = m_objData.Created_By;
            Created_By_Function.Text = m_objData.Created_By_Function;

            Last_Updated.Text = CUtility.Convert_DateTime_To_String(m_objData.Last_Updated);
            Last_Updated_By.Text = m_objData.Last_Updated_By;
            Last_Updated_By_Function.Text = m_objData.Last_Updated_By_Function;
        }
    }
}
