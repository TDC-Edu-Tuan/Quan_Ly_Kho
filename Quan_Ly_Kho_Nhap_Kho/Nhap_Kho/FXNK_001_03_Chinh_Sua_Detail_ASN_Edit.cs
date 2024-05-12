namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    public partial class FXNK_001_03_Chinh_Sua_Detail_ASN_Edit : FBase
    {
        public long p_lngNhap_Kho_ID { get; set; }

        private List<CDM_San_Pham> m_arrSP = new();

        private CXNK_Nhap_Kho_Raw_Data m_objData = new();

        public FXNK_001_03_Chinh_Sua_Detail_ASN_Edit()
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
            CXNK_Nhap_Kho_Raw_Data_Controller v_ctrlRaw_Data = new();
            m_objData = v_ctrlRaw_Data.FQ_719_NKRD_sp_sel_Get_By_ID(g_lngAuto_ID);

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
            CXNK_Nhap_Kho_Raw_Data_Controller v_ctrlRaw_Data = new();

            m_objData.Nhap_Kho_ID = p_lngNhap_Kho_ID;

            m_objData.San_Pham_ID = CUtility.Convert_To_Int64(cbbSan_Pham.SelectedValue);
            m_objData.So_Luong = CUtility.Convert_To_Double(txtSL.Text);
            m_objData.Don_Gia = CUtility.Convert_To_Double(txtDon_Gia.Text);
            m_objData.Ghi_Chu = txtGhi_Chu.Text;
            m_objData.Chu_Hang_ID = g_lngChu_Hang_ID;
            m_objData.Kho_ID = g_lngKho_ID;

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            string v_strError = CNhap_Kho_Common.Check_Raw_Data_Info(m_objData);

            if (v_strError != CConst.STR_VALUE_NULL)
                throw new Exception(v_strError);

            CDM_San_Pham v_objSP = CCache_San_Pham.Get_Data_By_ID(m_objData.San_Pham_ID);
            if (v_objSP != null)
            {
                m_objData.Ma_SP = v_objSP.Ma_SP;
                m_objData.Ten_SP = v_objSP.Ten_SP;
            }

            v_ctrlRaw_Data.FQ_719_NKRD_sp_ins_Insert(m_objData);
        }


        protected override void Update_Data()
        {

            CXNK_Nhap_Kho_Raw_Data_Controller v_ctrlRaw_Data = new();

            m_objData.San_Pham_ID = CUtility.Convert_To_Int64(cbbSan_Pham.SelectedValue);
            m_objData.So_Luong = CUtility.Convert_To_Double(txtSL.Text);
            m_objData.Don_Gia = CUtility.Convert_To_Double(txtDon_Gia.Text);
            m_objData.Ghi_Chu = txtGhi_Chu.Text;

            m_objData.Last_Updated_By = User_Name;
            m_objData.Last_Updated_By_Function = Function_Code;

            string v_strError = CNhap_Kho_Common.Check_Raw_Data_Info(m_objData);

            if (v_strError != CConst.STR_VALUE_NULL)
                throw new Exception(v_strError);

            v_ctrlRaw_Data.FQ_719_NKRD_sp_upd_Update(m_objData);
        }


        protected override void Closed_Form()
        {
            Close();
        }

    }
}
