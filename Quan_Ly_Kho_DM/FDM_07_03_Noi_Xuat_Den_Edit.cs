using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_07_03_Noi_Xuat_Den_Edit : FBase
    {
        private CDM_Noi_Xuat_Den m_objData = new();

        public FDM_07_03_Noi_Xuat_Den_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Data()
        {
            CDM_Noi_Xuat_Den_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_130_NXD_sp_sel_Get_By_ID(g_lngAuto_ID);

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

            txtMa_Noi_Xuat_Den.Text = m_objData.Ma_NXD;
            txtTen_Noi_Xuat_Den.Text = m_objData.Ten_NXD;
            txtDia_Chi.Text = m_objData.Dia_Chi;
            txtSDT.Text = m_objData.Dien_Thoai;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;


        }

        protected override void Add_Data()
        {
            CDM_Noi_Xuat_Den_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
            m_objData.Ma_NXD = txtMa_Noi_Xuat_Den.Text;
            m_objData.Ten_NXD = txtTen_Noi_Xuat_Den.Text;
            m_objData.Dia_Chi = txtDia_Chi.Text;
            m_objData.Dien_Thoai = txtSDT.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Add dữ liệu vào csdl
            m_objData.Auto_ID = g_lngAuto_ID = v_objCtrlData.FQ_130_NXD_sp_ins_Insert(m_objData);

            CCache_Noi_Xuat_Den.Add_Data(m_objData);
        }

        protected override void Update_Data()
        {
            CDM_Noi_Xuat_Den_Controller v_objCtrlData = new();

            //Gán lại dữ liệu
            m_objData.Ma_NXD = txtMa_Noi_Xuat_Den.Text;
            m_objData.Ten_NXD = txtTen_Noi_Xuat_Den.Text;
            m_objData.Dia_Chi = txtDia_Chi.Text;
            m_objData.Dien_Thoai = txtSDT.Text;
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            //Update dữ liệu vào csdl
            v_objCtrlData.FQ_130_NXD_sp_upd_Update(m_objData);

            CCache_Noi_Xuat_Den.Update_Data(m_objData);

        }

        protected override void Closed_Form()
        {
            Close();
        }
    }
}