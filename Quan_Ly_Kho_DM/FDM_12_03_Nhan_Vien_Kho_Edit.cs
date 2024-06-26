﻿using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_12_03_Nhan_Vien_Kho_Edit : FBase
    {
        private CDM_Nhan_Vien_Kho m_objData = new();

        public FDM_12_03_Nhan_Vien_Kho_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Nhan_Vien_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_127_NVK_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_Nhan_Vien_Kho.Text = m_objData.Ma_NV;
            txtTen_Nhan_Vien_Kho.Text = m_objData.Ten_NV;
            radioGroup1.EditValue = m_objData.Gioi_Tinh;
            txtSDT.Text = m_objData.Dien_Thoai;
            txtDia_Chi.Text = m_objData.Dia_Chi;
            txtCCCD.Text = m_objData.CCCD;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

        }

        protected override void Add_Data()
        {
            CDM_Nhan_Vien_Kho_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Kho_ID = g_lngKho_ID;
            m_objData.Ma_NV = txtMa_Nhan_Vien_Kho.Text;
            m_objData.Ten_NV = txtTen_Nhan_Vien_Kho.Text;
            m_objData.Gioi_Tinh = CUtility.Convert_To_String(radioGroup1.EditValue);
            m_objData.Dien_Thoai = txtSDT.Text;
            m_objData.Dia_Chi = txtDia_Chi.Text;
            m_objData.CCCD = txtCCCD.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_127_NVK_sp_ins_Insert(m_objData);

            CCache_Nhan_Vien_Kho.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CDM_Nhan_Vien_Kho_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_NV = txtMa_Nhan_Vien_Kho.Text;
            m_objData.Ten_NV = txtTen_Nhan_Vien_Kho.Text;
            m_objData.Gioi_Tinh = CUtility.Convert_To_String(radioGroup1.EditValue);
            m_objData.Dien_Thoai = txtSDT.Text;
            m_objData.Dia_Chi = txtDia_Chi.Text;
            m_objData.CCCD = txtCCCD.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_127_NVK_sp_upd_Update(m_objData);

            CCache_Nhan_Vien_Kho.Update_Data(m_objData);

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