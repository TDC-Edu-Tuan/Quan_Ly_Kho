namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_001_02_Ke_Hoach_Nhap_View : FBase
    {
        private CXNK_Nhap_Kho m_objData = new();
        private List<CXNK_Nhap_Kho_Raw_Data> m_arrRaw_Data = new();

        public FXNK_001_02_Ke_Hoach_Nhap_View()
        {
            InitializeComponent();

            g_grdData = grdData; //Tham chiếu

            g_arrCol_Hiden.Add("btnCheck");
            g_arrCol_Hiden.Add("btnDeleted");
            g_arrCol_Hiden.Add("btnUpdated");
            g_arrCol_Hiden.Add("Nhap_Kho_ID");
            g_arrCol_Hiden.Add("San_Pham_ID");

            Disable_Default_Col();

            g_dicCol_Name.Add("So_Luong", "Số Lượng");
            g_dicCol_Name.Add("So_Phieu_Nhap", "Số Phiếu");
            g_dicCol_Name.Add("Don_Gia", "Đơn Giá");
            g_dicCol_Name.Add("Tri_Gia", "Trị Giá");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");
            g_dicCol_Name.Add("Ma_SP", "Mã Sản Phẩm");
            g_dicCol_Name.Add("Ten_SP", "Tên Sản Phẩm");

            g_dicCol_Size.Add("So_Luong", 100);
            g_dicCol_Size.Add("So_Phieu_Nhap", 200);
            g_dicCol_Size.Add("Don_Gia", 100);
            g_dicCol_Size.Add("Tri_Gia", 100);
            g_dicCol_Size.Add("Ghi_Chu", 300);
            g_dicCol_Size.Add("Ma_SP", 200);
            g_dicCol_Size.Add("Ten_SP", 200);

            g_dicCol_Index.Add("Ma_SP", 1);
            g_dicCol_Index.Add("Ten_SP", 2);
            g_dicCol_Index.Add("So_Luong", 4);
            g_dicCol_Index.Add("Don_Gia", 5);
            g_dicCol_Index.Add("Tri_Gia", 6);
            g_dicCol_Index.Add("So_Phieu_Nhap", 3);


        }

        protected override void Load_Data()
        {
            CXNK_Nhap_Kho_Controller v_objCtrlData = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

            m_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(g_lngAuto_ID);
  
            Auto_ID.Text = CUtility.Convert_To_String(m_objData.Auto_ID);

            // Gán giá trị từ đối tượng m_objData vào các TextBox tương ứng và đặt thuộc tính ReadOnly
            txtSo_Phieu_Nhap.Text = m_objData.So_Phieu_Nhap;
            txtSo_Phieu_Nhap.ReadOnly = true;

            if (m_objData.Ngay_Nhap_Kho == null)
                dtmNgay_Nhap_Kho.Value = DateTime.Now;
            else
                dtmNgay_Nhap_Kho.Value = (DateTime)m_objData.Ngay_Nhap_Kho;

            dtmNgay_Nhap_Kho.Enabled = false;

            txtTrang_Thai.Text = m_objData.Trang_Thai_Nhap_Kho_Text;
            txtTrang_Thai.ReadOnly = true;

            txtNCC.Text = CUtility.Tao_Combo_Text(m_objData.Ma_NCC, m_objData.Ten_NCC);
            txtNCC.ReadOnly = true;

            txtGhi_Chu.Text = m_objData.Ghi_Chu;
            txtGhi_Chu.ReadOnly = true;

            Created.Text = CUtility.Convert_DateTime_To_String(m_objData.Created);
            Created_By.Text = m_objData.Created_By;
            Created_By_Function.Text = m_objData.Created_By_Function;

            Last_Updated.Text = CUtility.Convert_DateTime_To_String(m_objData.Last_Updated);
            Last_Updated_By.Text = m_objData.Last_Updated_By;
            Last_Updated_By_Function.Text = m_objData.Last_Updated_By_Function;

            Auto_ID.ReadOnly = true;
            Created.ReadOnly = true;
            Created_By.ReadOnly = true;
            Created_By_Function.ReadOnly = true;
            Last_Updated.ReadOnly = true;
            Last_Updated_By.ReadOnly = true;
            Last_Updated_By_Function.ReadOnly = true;
            //Detail
            m_arrRaw_Data = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(g_lngAuto_ID);

            Format_Grid(m_arrRaw_Data);
        }


    }
}
