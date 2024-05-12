namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    public partial class FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke : FBase
    {
        private List<CDM_Vi_Tri> m_arrVi_Tri;

        public CXNK_Nhap_Kho m_objData = new();

        public FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke()
        {
            InitializeComponent();
        }

        protected override void Load_Init()
        {
            m_arrVi_Tri = CCache_Vi_Tri.List_Data_By_Kho_ID(g_lngKho_ID);
            FControl_Vi_Tri_Combo.Load_Combo(cbbVi_Tri, m_arrVi_Tri, "Auto_ID", "Vi_Tri_Combo");
        }

        protected override void Load_Data()
        {
            CXNK_Nhap_Kho_Controller v_objCtrlData = new();
            m_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(g_lngAuto_ID);

            //Lấy danh sách detail của phiếu nhập
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();
            m_objData.Details = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(m_objData.Auto_ID);

        }

        protected override void Add_Data()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            CXNK_Nhap_Kho_Controller v_objCtrlNK = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();
            CXNK_Ton_Kho_Controller v_objCtrl_Data = new();
            CXNK_Ton_Kho v_objData = new();
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                foreach (CXNK_Nhap_Kho_Raw_Data v_objRaw_Data in m_objData.Details)
                {
                    //Kiểm tra trong tồn nếu chưa có thì add vào còn nếu có rồi thì bỏ qua
                    v_objData = v_objCtrl_Data.FQ_722_TK_sp_sel_Get_By_Raw_Data_ID(v_conn, v_trans, v_objRaw_Data.Auto_ID);

                    if (v_objData == CConst.OBJ_VALUE_NULL)
                    {
                        v_objData = new();

                        //MapData
                        v_objData.Nhap_Kho_Raw_ID = v_objRaw_Data.Auto_ID;
                        v_objData.Nhap_Kho_ID = v_objRaw_Data.Nhap_Kho_ID;
                        v_objData.San_Pham_ID = v_objRaw_Data.San_Pham_ID;
                        v_objData.Vi_Tri_ID = CUtility.Convert_To_Int64(cbbVi_Tri.SelectedValue);

                        v_objData.Chu_Hang_ID = v_objRaw_Data.Chu_Hang_ID;
                        v_objData.Kho_ID = v_objRaw_Data.Kho_ID;
                        v_objData.So_Luong = v_objRaw_Data.So_Luong;
                        v_objData.Ghi_Chu = txtGhi_Chu.Text;

                        v_objData.Trang_Thai_Ton_Kho = (int)ETrang_Thai_TK_ID.New;
                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        //Thêm vào tồn
                        v_objCtrl_Data.FQ_722_TK_sp_ins_Insert(v_conn, v_trans, v_objData);
                    }
                }

                m_objData.Trang_Thai_Nhap_Kho_ID = (int)ETrang_Thai_Nhap_Kho.Hoan_Thanh_Vao_Ton;
                m_objData.Last_Updated_By = User_Name;
                m_objData.Last_Updated_By_Function = Function_Code;

                //Update lại trạng thái phiếu nhập
                v_objCtrlNK.FQ_718_NK_sp_upd_Update_Status_NK(v_conn, v_trans, m_objData);

                v_trans.Commit();
            }
            catch (Exception ex)
            {
                if (v_trans != null)
                    v_trans.Rollback();

                throw ex;
            }
            finally
            {

                if (v_trans != null)
                    v_trans.Dispose();

                if (v_conn != null)
                    v_conn.Close();
            }

        }


        protected override void Closed_Form()
        {
            Close();
        }
    }
}