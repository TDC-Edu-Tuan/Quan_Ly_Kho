using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_08_03_Kho_Edit : FBase
    {
        private CDM_Kho m_objData = new();

        public FDM_08_03_Kho_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_114_K_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_Kho.Text = m_objData.Ma_Kho;
            txtTen_Kho.Text = m_objData.Ten_Kho;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

        }

        protected override void Add_Data()
        {
            CDM_Kho_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_Kho = txtMa_Kho.Text;
            m_objData.Ten_Kho = txtTen_Kho.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_114_K_sp_ins_Insert(m_objData);

            CCache_Kho.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CDM_Kho_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_Kho = txtMa_Kho.Text;
            m_objData.Ten_Kho = txtTen_Kho.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_114_K_sp_upd_Update(m_objData);

            CCache_Kho.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}