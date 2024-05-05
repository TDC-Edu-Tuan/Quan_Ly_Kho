using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Controls.Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;

namespace Quan_Ly_Kho_DM
{
    public partial class FDM_05_01_Vi_Tri_List : UCBase
    {
        private List<CDM_Vi_Tri> m_arrData = new();

        public FDM_05_01_Vi_Tri_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = true;
            g_bIs_Deleted_Permission = true;

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

            g_dicCol_Name.Add("Ma_Vi_Tri", "Mã Vị Trí");
            g_dicCol_Name.Add("Ten_Vi_Tri", "Tên Vị Trí");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");

            g_dicCol_Size.Add("Ma_Vi_Tri", 200);
            g_dicCol_Size.Add("Ten_Vi_Tri", 300);
            g_dicCol_Size.Add("Ghi_Chu", 500);

            FControl_Chu_Hang_Combo.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_ID", "Chu_Hang_Combo");
            FControl_Kho_Combo.Load_Combo(cbbKho, g_arrKho_Users, "Kho_ID", "Kho_Combo");
        }

        protected override void Load_Data()
        {
            CDM_Vi_Tri_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_175_VT_sp_sel_List_By_Created(g_lngChu_Hang_ID, dtmFrom.Value, dtmTo.Value);
            grdData.DataSource = m_arrData;

            Format_Grid();

        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FDM_05_03_Vi_Tri_Edit v_objEdit = new();
            v_objEdit.g_lngKho_ID = g_lngKho_ID;
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.ShowDialog();
        }

        //Hàm đc gọi khi ấn vào nút view
        protected override void Open_View_Data(long p_lngAuto_ID)
        {
            FDM_05_02_Vi_Tri_View v_objView = new();
            v_objView.g_lngAuto_ID = p_lngAuto_ID;
            v_objView.Show();
        }

        protected override void Import_Excel_Entry(FileInfo p_objFile, ref int p_iCount_Success, ref int p_iCount_Error)
        {

        }
       
        protected override void Tim_Kiem_By_Key()
        {
            string v_strKey_Word = txtNoi_Dung_Tim_Kiem.Text;
            List<CDM_Vi_Tri> v_arrData_Temp = m_arrData.ToList();

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
