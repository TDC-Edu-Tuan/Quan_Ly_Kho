using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_03_03_San_Pham_Edit : FBase
    {
        private CDM_San_Pham m_objData = new();
        private List<CDM_Don_Vi_Tinh> m_arrDVT = new();
        private List<CDM_Loai_San_Pham> m_arrLSP = new();


        public FDM_03_03_San_Pham_Edit()
        {
            InitializeComponent();

        }

        protected override void Load_Init()
        {
            m_arrLSP = CCache_Loai_San_Pham.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            m_arrDVT = CCache_Don_Vi_Tinh.List_Data();

            FControl_LSP_Combo.Load_Combo(cbbLSP, m_arrLSP, "Auto_ID", "LSP_Combo");
            FControl_Don_Vi_Tinh_Combo.Load_Combo(cbbDVT, m_arrDVT, "Auto_ID", "Ten_Don_Vi_Tinh");
        }

        protected override void Load_Data()
        {

            CDM_San_Pham_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_165_SP_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_SP.Text = m_objData.Ma_SP;
            txtTen_SP.Text = m_objData.Ma_SP;

            txtGhi_Chu.Text = m_objData.Ghi_Chu;

            cbbDVT.SelectedValue = m_objData.DVT_ID;
            cbbLSP.SelectedValue = m_objData.LSP_ID;
        }

        protected override void Add_Data()
        {
            CDM_San_Pham_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
            m_objData.Ma_SP = txtMa_SP.Text;
            m_objData.Ten_SP = txtTen_SP.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            m_objData.DVT_ID = CUtility.Convert_To_Int64(cbbDVT.SelectedValue);
            m_objData.LSP_ID = CUtility.Convert_To_Int64(cbbLSP.SelectedValue);

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_165_SP_sp_ins_Insert(m_objData);
            m_objData = v_objCtrlData.FQ_165_SP_sp_sel_Get_By_ID(g_lngKho_ID);

            CCache_San_Pham.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {

            CDM_San_Pham_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_SP = txtMa_SP.Text;
            m_objData.Ten_SP = txtTen_SP.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            m_objData.DVT_ID = CUtility.Convert_To_Int64(cbbDVT.SelectedValue);
            m_objData.LSP_ID = CUtility.Convert_To_Int64(cbbLSP.SelectedValue);

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_165_SP_sp_upd_Update(m_objData);
            m_objData = v_objCtrlData.FQ_165_SP_sp_sel_Get_By_ID(g_lngKho_ID);

            CCache_San_Pham.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}