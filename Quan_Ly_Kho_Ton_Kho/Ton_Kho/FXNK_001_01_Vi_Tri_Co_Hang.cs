using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Data.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Ton_Kho.Ton_Kho;
using System.Data;

namespace Quan_Ly_Kho_DM
{
    public partial class FXNK_001_01_Vi_Tri_Co_Hang : UCBase
    {
        private List<CXNK_Ton_Kho> m_arrData = new();

        public FXNK_001_01_Vi_Tri_Co_Hang()
        {
            InitializeComponent();
            g_bIs_Updated_Permission = true;


            // Chuyển đổi mã màu hex thành màu Color
            Color navColor = ColorTranslator.FromHtml("#d8bfd8");

            // Đặt màu nền cho panel2
            panel2.BackColor = navColor;
        }

        protected override void Load_Init()
        {
            dtmFrom.Value = CUtility_Date.Convert_To_Dau_Ngay(DateTime.Now.AddDays(-15));
            dtmTo.Value = CUtility_Date.Convert_To_Cuoi_Ngay(DateTime.Now);

            g_grdData = grdData; //Để tham chiếu tới export excel
            Disable_Default_Col();

            g_arrCol_Hiden.Add("Vi_Tri_ID");
            g_arrCol_Hiden.Add("Nhap_Kho_ID");
            g_arrCol_Hiden.Add("San_Pham_ID");
            g_arrCol_Hiden.Add("Nhap_Kho_Raw_ID");
            g_arrCol_Hiden.Add("Trang_Thai_Ton_Kho");

            g_dicCol_Name.Add("Ma_Vi_Tri", "Mã Vị Trí");
            g_dicCol_Name.Add("Ten_Vi_Tri", "Tên Vị Trí");
            g_dicCol_Name.Add("Ten_Don_Vi_Tinh", "ĐVT");
            g_dicCol_Name.Add("Ma_LSP", "Mã LSP");
            g_dicCol_Name.Add("Ten_LSP", "Tên LSP");
            g_dicCol_Name.Add("Trang_Thai_TK_Text", "Trạng Thái");

            g_dicCol_Name.Add("So_Luong", "Số Lượng");
            g_dicCol_Name.Add("So_Phieu_Nhap", "Số Phiếu");
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

            FControl_Chu_Hang_User_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_User_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");
            cbbChu_Hang.SelectedValue = g_lngChu_Hang_ID;
            cbbKho.SelectedValue = g_lngKho_ID;
        }

        protected override void Load_Data()
        {
            CXNK_Ton_Kho_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_722_TK_sp_sel_List_By_Created(g_lngChu_Hang_ID, g_lngKho_ID, dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);
        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FXNK_001_02_Hieu_Chinh_Lo_Hang v_objEdit = new();
            v_objEdit.g_lngChu_Hang_ID = g_lngChu_Hang_ID;
            v_objEdit.g_lngKho_ID = g_lngKho_ID;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.User_Name = User_Name;
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.ShowDialog();
        }


        protected override void Tim_Kiem_By_Key()
        {
            string v_strKey_Word = txtNoi_Dung_Tim_Kiem.Text;
            List<CXNK_Ton_Kho> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.Ma_Vi_Tri.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_Vi_Tri.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_Don_Vi_Tinh.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_LSP.ToLower().Contains(v_strKey_Word)
                                                         || it.Ma_LSP.ToString().ToLower().Contains(v_strKey_Word)
                                                         || it.So_Phieu_Nhap.ToString().ToLower().Contains(v_strKey_Word)
                                                         || it.So_Luong.ToString().ToLower().Contains(v_strKey_Word)


             ).ToList();
            }
            grdData.DataSource = v_arrData_Temp;
        }

        protected override void Combobox_Selected_Index_Changed()
        {
            g_lngChu_Hang_ID = CUtility.Convert_To_Int64(cbbChu_Hang.SelectedValue);
            g_lngKho_ID = CUtility.Convert_To_Int64(cbbKho.SelectedValue);
        }
    }
}

