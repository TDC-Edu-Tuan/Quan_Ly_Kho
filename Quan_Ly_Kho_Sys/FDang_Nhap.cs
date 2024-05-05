using DevExpress.XtraEditors;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Text;

namespace Quan_Ly_Kho_Sys
{
    public partial class FDang_Nhap : XtraForm
    {
        private CSys_Thanh_Vien m_objThanh_Vien = new();

        public FDang_Nhap()
        {
            InitializeComponent();
            txtPassword.Properties.PasswordChar = '•';
        }

        private void FDang_Nhap_Load(object sender, EventArgs e)
        {
            if (CSystem.Thanh_Vien != null && CSystem.State == (int)EStatus_Type.Closed_And_Reload)
            {
                m_objThanh_Vien = CSystem.Thanh_Vien;
            }

            txtUser_Name.Text = m_objThanh_Vien.Ma_Dang_Nhap.Trim().ToLower();
            txtPassword.Text = m_objThanh_Vien.Mat_Khau.Trim().ToLower();
            lblMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CSys_Thanh_Vien_Controller v_objCtrlThanh_Vien = new();
            StringBuilder v_sbError = new();

            try
            {
                #region Kiểm tra lỗi
                if (txtUser_Name.Text.Trim().ToLower() == CConst.STR_VALUE_NULL)
                    v_sbError.AppendLine("Mã đăng nhập không được để trống.");

                if (txtPassword.Text.Trim() == CConst.STR_VALUE_NULL)
                    v_sbError.AppendLine("Mật khẩu không được để trống.");

                CSys_Thanh_Vien v_objData = v_objCtrlThanh_Vien.FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap(txtUser_Name.Text.Trim());

                if (v_objData == null)
                    v_sbError.AppendLine("Mã đăng nhập không tồn tại.");

                else if (v_objData.Mat_Khau.Equals(txtPassword.Text.Trim()) == false)
                    v_sbError.AppendLine("Mật khẩu không đúng.");

                if (v_sbError.ToString() != CConst.STR_VALUE_NULL)
                    throw new Exception(v_sbError.ToString());

                #endregion

                CSystem.Thanh_Vien = v_objData;

                Close();

                CSystem.State = (int)EStatus_Type.Success;//Trả về trạng thái thành công
            }
            catch (Exception ex)
            {
                FCommonFunction.Set_Error_Label_Message(lblMessage, ex.Message);
                lblMessage.Refresh();
            }

        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void FDang_Nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kiểm tra nếu thành viên null tức là chưa được gán trên sự kiện login -> ấn thoát chương trình
            if (CSystem.Thanh_Vien == null) //Kiểm tra 
            {
                if (FCommonFunction.Show_Message_Box("Thông báo", "Bạn có muốn thoát chương trình", (int)EMessage_Type.Question) == DialogResult.Yes)
                {
                    CSystem.State = (int)EStatus_Type.Closed;
                }
            }
        }
    }
}