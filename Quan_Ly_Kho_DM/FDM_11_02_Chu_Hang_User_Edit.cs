using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_11_02_Chu_Hang_User_Edit : FBase
    {
        private List<CDM_Chu_Hang_User> m_arrData = new();
        private CDM_Chu_Hang_User m_objData = new();

        public FDM_11_02_Chu_Hang_User_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Chu_Hang_User_Controller v_objCtrlData = new();
            m_arrData = v_objCtrlData.FQ_107_CHU_sp_sel_List_Thanh_Vien_Khac_By_Chu_Hang_ID(g_lngChu_Hang_ID);

            FControl_Chu_Hang_User_Combo.Load_Combo(cbbCH_User, m_arrData, "Thanh_Vien_ID", "Ma_Dang_Nhap");
        }

        protected override void Add_Data()
        {
            CDM_Chu_Hang_User_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
            m_objData.Thanh_Vien_ID = CUtility.Convert_To_Int64(cbbCH_User.SelectedValue);
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_107_CHU_sp_ins_Insert(m_objData);

            CCache_Chu_Hang_User.Add_Data(m_objData);
        }

        protected override void Closed_Form()
        {
            Close();
        }

        private void cbbCH_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}