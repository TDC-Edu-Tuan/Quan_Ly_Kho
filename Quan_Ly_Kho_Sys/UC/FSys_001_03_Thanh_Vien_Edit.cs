using DevExpress.XtraEditors;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;

namespace Quan_Ly_Kho_DM
{
    public partial class FSys_001_03_Thanh_Vien_Edit : FBase
    {
        private CSys_Thanh_Vien m_objData = new();
        private string m_strMat_Khau = CConst.STR_VALUE_NULL;
        public FSys_001_03_Thanh_Vien_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {
            List<CEnum_Combo> v_arrNhom_Thanh_Vien = new() {
                new CEnum_Combo() {Value = (int)ENhom_Thanh_Vien.Quan_Tri,Text ="Quản trị" } ,
                new CEnum_Combo() {Value = (int)ENhom_Thanh_Vien.Data,Text ="Data" } ,
                new CEnum_Combo() {Value = (int)ENhom_Thanh_Vien.Nhap_Hang,Text ="Nhập Hàng" } ,
                new CEnum_Combo() {Value = (int)ENhom_Thanh_Vien.Xuat_Kho,Text ="Xuất Kho" } ,
                new CEnum_Combo() {Value = (int)ENhom_Thanh_Vien.Dev,Text ="Dev" } ,
            };

            FControl_Enum_Combo.Load_Combo(cbbNhom_Thanh_Vien, v_arrNhom_Thanh_Vien, "Value", "Text");
        }

        protected override void Load_Data()
        {
            CSys_Thanh_Vien_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_531_TV_sp_sel_Get_By_ID(g_lngAuto_ID);

            if (m_objData.Ma_Dang_Nhap == "admin")
                m_objData = null;

            if (m_objData == null)
            {
                Text = "Thêm mới";
                m_objData = new();
            }
            else
            {
                Text = "Chỉnh sửa";
                g_bIs_Update = true;
            }

            txtMa_Dang_Nhap.Text = m_objData.Ma_Dang_Nhap;
            m_strMat_Khau = txtMat_Khau.Text = m_objData.Mat_Khau;
            radioGroup1.EditValue = m_objData.Gioi_Tinh;
            txtSDT.Text = m_objData.SDT;
            txtHo_Ten.Text = m_objData.Ho_Ten;
            txtEmail.Text = m_objData.Email;
            cbbNhom_Thanh_Vien.SelectedValue = m_objData.Nhom_Thanh_Vien_ID;
        }

        protected override void Add_Data()
        {
            CSys_Thanh_Vien_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_Dang_Nhap = txtMa_Dang_Nhap.Text;

            m_objData.Mat_Khau = CUtility.MD5_Encrypt(txtMat_Khau.Text);

            m_objData.Gioi_Tinh = CUtility.Convert_To_String(radioGroup1.EditValue);
            m_objData.SDT = txtSDT.Text;
            m_objData.Ho_Ten = txtHo_Ten.Text;
            m_objData.Email = txtEmail.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_531_TV_sp_ins_Insert(m_objData);

            CCache_Thanh_Vien.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CSys_Thanh_Vien_Controller v_objCtrlData = new();

            //Gán lại dữ liệu

            //Nếu mật khẩu khác đã được nhập
           
            m_objData.Ma_Dang_Nhap = txtMa_Dang_Nhap.Text;

            if (m_strMat_Khau != CUtility.MD5_Encrypt(txtMat_Khau.Text))
                m_objData.Mat_Khau = CUtility.MD5_Encrypt(txtMat_Khau.Text);

            m_objData.Gioi_Tinh = CUtility.Convert_To_String(radioGroup1.EditValue);
            m_objData.SDT = txtSDT.Text;
            m_objData.Ho_Ten = txtHo_Ten.Text;
            m_objData.Email = txtEmail.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_531_TV_sp_upd_Update(m_objData);

            CCache_Thanh_Vien.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}