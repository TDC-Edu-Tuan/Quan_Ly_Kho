﻿using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_09_02_Kho_User_Edit : FBase
    {
        private List<CDM_Kho_User> m_arrData = new();
        private CDM_Kho_User m_objData = new();

        public FDM_09_02_Kho_User_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Kho_User_Controller v_objCtrlData = new();
            m_arrData = v_objCtrlData.FQ_117_KU_sp_sel_List_Thanh_Vien_Khac_By_Kho_ID(g_lngKho_ID);

            FControl_Kho_User_Combo.Load_Combo(cbbKho_User, m_arrData, "Thanh_Vien_ID", "Ma_Dang_Nhap");
        }

        protected override void Add_Data()
        {
            CDM_Kho_User_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Kho_ID = g_lngKho_ID;
            m_objData.Thanh_Vien_ID = CUtility.Convert_To_Int64(cbbKho_User.SelectedValue);
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_117_KU_sp_ins_Insert(m_objData);

            CCache_Kho_User.Add_Data(m_objData);
        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}