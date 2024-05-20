using Quan_Ly_Kho_Data_Access.Data.Xuat_kho;

namespace Quan_Ly_Kho_Xuat_Kho.Xuat_Kho
{
    public partial class FXNK_001_03_Them_Detail_Xuat_Kho_Edit : FBase
    {
        public List<CXNK_Xuat_Kho_Raw_Data> p_arrPara_Raw_Data { get; set; }

        private List<CDM_San_Pham> m_arrSP = new();

        private CXNK_Xuat_Kho_Raw_Data m_objData = new();

        public FXNK_001_03_Them_Detail_Xuat_Kho_Edit()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {
            m_arrSP = CCache_San_Pham.List_Data_By_Chu_Hang_ID(g_lngChu_Hang_ID);
            FControl_San_Pham_Combo.Load_Combo(cbbSan_Pham, m_arrSP, "Auto_ID", "San_Pham_Combo");
        }

        protected override void Load_Data()
        {
            m_objData = p_arrPara_Raw_Data.FirstOrDefault(it => it.Auto_ID == g_lngAuto_ID);

            if (m_objData == null)
            {
                m_objData = new();
                Text = "Thêm mới";
            }
            else
            {
                g_bIs_Update = true;
                Text = "Hiệu chỉnh";
            }

            cbbSan_Pham.SelectedValue = m_objData.San_Pham_ID;
            txtDon_Gia.Text = CUtility.Convert_To_String(m_objData.Don_Gia);
            txtSL.Text = CUtility.Convert_To_String(m_objData.So_Luong);
            txtGhi_Chu.Text = m_objData.Ghi_Chu;
        }

        protected override void Add_Data()
        {
            m_objData.Auto_ID = CUtility.Create_Rand_ID(8);
            m_objData.San_Pham_ID = CUtility.Convert_To_Int64(cbbSan_Pham.SelectedValue);
            m_objData.So_Luong = CUtility.Convert_To_Double(txtSL.Text);
            m_objData.Don_Gia = CUtility.Convert_To_Double(txtDon_Gia.Text);
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            string v_strError = CXuat_Kho_Common.Check_Raw_Data_Info(m_objData);

            if (v_strError != CConst.STR_VALUE_NULL)
                throw new Exception(v_strError);

            CDM_San_Pham v_objSP = CCache_San_Pham.Get_Data_By_ID(m_objData.San_Pham_ID);
            if (v_objSP != null)
            {
                m_objData.Ma_SP = v_objSP.Ma_SP;
                m_objData.Ten_SP = v_objSP.Ten_SP;
            }

            p_arrPara_Raw_Data.Add(m_objData);
        }


        protected override void Update_Data()
        {
            m_objData.San_Pham_ID = CUtility.Convert_To_Int64(cbbSan_Pham.SelectedValue);
            m_objData.So_Luong = CUtility.Convert_To_Double(txtSL.Text);
            m_objData.Don_Gia = CUtility.Convert_To_Double(txtDon_Gia.Text);
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            string v_strError = CXuat_Kho_Common.Check_Raw_Data_Info(m_objData);

            if (v_strError != CConst.STR_VALUE_NULL)
                throw new Exception(v_strError);

            CDM_San_Pham v_objSP = CCache_San_Pham.Get_Data_By_ID(m_objData.San_Pham_ID);
            if (v_objSP != null)
            {
                m_objData.Ma_SP = v_objSP.Ma_LSP;
                m_objData.Ten_SP = v_objSP.Ten_SP;
            }
        }

        protected override void Closed_Form()
        {
            Close();
        }

    }
}
