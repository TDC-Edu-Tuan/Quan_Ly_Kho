using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Sys;
using Quan_Ly_Kho_Data_Access.Data.Sys;

namespace Quan_Ly_Kho_Sys
{
    public partial class FSys_002_03_Frozen_Column_Edit : FBase
    {
        private CSys_Frozen_Column m_objData = new();
        public FSys_002_03_Frozen_Column_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {

        }

        protected override void Load_Data()
        {
            CSys_Frozen_Column_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_513_FC_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_Chuc_Nang.Text = m_objData.Ma_Chuc_Nang;
            txtCol_Frozen.Text = m_objData.Ten_Cot_Frozen;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
        }

        protected override void Add_Data()
        {
            CSys_Frozen_Column_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_Chuc_Nang = txtMa_Chuc_Nang.Text;
            m_objData.Ten_Cot_Frozen = txtCol_Frozen.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_513_FC_sp_ins_Insert(m_objData);

            CCache_Frozen_Column.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CSys_Frozen_Column_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_Chuc_Nang = txtMa_Chuc_Nang.Text;
            m_objData.Ten_Cot_Frozen = txtCol_Frozen.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_513_FC_sp_upd_Update(m_objData);

            CCache_Frozen_Column.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}