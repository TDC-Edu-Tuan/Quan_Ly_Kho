using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_10_03_Chu_Hang_Edit : FBase
    {
        private CDM_Chu_Hang m_objData = new();

        public FDM_10_03_Chu_Hang_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Chu_Hang_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_104_CH_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_Chu_Hang.Text = m_objData.Ma_CH;
            txtTen_Chu_Hang.Text = m_objData.Ten_CH;
            txtEmail.Text = m_objData.Email;
            txtSDT.Text = m_objData.SDT;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;


        }

        protected override void Add_Data()
        {
            CDM_Chu_Hang_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_CH = txtMa_Chu_Hang.Text;
            m_objData.Ten_CH = txtTen_Chu_Hang.Text;
            m_objData.Email = txtEmail.Text;
            m_objData.SDT = txtSDT.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_104_CH_sp_ins_Insert(m_objData);

            CCache_Chu_Hang.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CDM_Chu_Hang_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_CH = txtMa_Chu_Hang.Text;
            m_objData.Ten_CH = txtTen_Chu_Hang.Text;
            m_objData.Email = txtEmail.Text;
            m_objData.SDT = txtSDT.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_104_CH_sp_upd_Update(m_objData);

            CCache_Chu_Hang.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}