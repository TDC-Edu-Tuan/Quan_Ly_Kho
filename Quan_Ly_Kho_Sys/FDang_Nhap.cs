using DevExpress.XtraEditors;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Sys
{
    public partial class FDang_Nhap : XtraForm
    {
        private CSys_Thanh_Vien m_objThanh_Vien = new();

        public FDang_Nhap()
        {
            InitializeComponent();
        }

        private void FDang_Nhap_Load(object sender, EventArgs e)
        {
            txtUser_Name.Text = m_objThanh_Vien.Ma_Dang_Nhap;
            txtPassword.Text = m_objThanh_Vien.Mat_Khau;
            lblMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CSys_Thanh_Vien_Controller v_objCtrlThanh_Vien = new();
            StringBuilder v_sbError = new();

            try
            {
                #region Kiểm tra lỗi
                if (txtUser_Name.Text == CConst.STR_VALUE_NULL)
                    v_sbError.AppendLine("Mã đăng nhập không được để trống.");

                if (txtPassword.Text == CConst.STR_VALUE_NULL)
                    v_sbError.AppendLine("Mật khẩu không được để trống.");

                CSys_Thanh_Vien v_objData = v_objCtrlThanh_Vien.FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap(txtUser_Name.Text);

                if (v_objData == null)
                    v_sbError.AppendLine("Mã đăng nhập không tồn tại.");

                else if (v_objData.Mat_Khau.Equals(txtPassword.Text) == false)
                    v_sbError.AppendLine("Mật khẩu không đúng.");

                if (v_sbError.ToString() != CConst.STR_VALUE_NULL)
                    throw new Exception(v_sbError.ToString());

                #endregion

                //Gán cho obj
                m_objThanh_Vien.Ma_Dang_Nhap = v_objData.Ma_Dang_Nhap;
                m_objThanh_Vien.Mat_Khau = v_objData.Mat_Khau;

                CSystem.Thanh_Vien = v_objData;

                Close();
            }
            catch (Exception ex)
            {
                FCommonFunction.Set_Error_Label_Message(lblMessage, ex.Message);
                lblMessage.Refresh();
            }

        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            btnLogin_Click(sender,e);
        }
    }
}