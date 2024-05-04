using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Danh_Muc
{
    public partial class FDM_01_01_Don_Vi_Tinh_List : UCBase
    {
        private List<CDM_Don_Vi_Tinh> m_arrData = new();

        public FDM_01_01_Don_Vi_Tinh_List()
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

            g_dicCol_Name.Add("Ten_Don_Vi_Tinh", "ĐVT");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");

            g_dicCol_Size.Add("Ten_Don_Vi_Tinh", 500);
            g_dicCol_Size.Add("Ghi_Chu", 500);

            FCommonFunction.Load_Combo(cbbChu_Hang, g_arrChu_Hang_Users, "Chu_Hang_Combo", "Chu_Hang_ID");
            FCommonFunction.Load_Combo(cbbKho, g_arrKho_Users, "Kho_Combo", "Kho_ID");

        }

        protected override void Load_Data()
        {
            CDM_Don_Vi_Tinh_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_110_DVT_sp_sel_List_By_Created(dtmFrom.Value, dtmTo.Value);
            grdData.DataSource = m_arrData;

            Format_Grid();

        }

        //Hàm thêm
        protected override void Open_Edit_Data()
        {
            FDM_01_03_Don_Vi_Tinh_Edit v_objEdit = new();
            v_objEdit.g_lngAuto_ID = g_lngAuto_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.ShowDialog();
        }

        protected override void Tim_Kiem_By_Key()
        {
            string v_strKey_Word = txtNoi_Dung_Tim_Kiem.Text;
            List<CDM_Don_Vi_Tinh> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.Ten_Don_Vi_Tinh.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)
             ).ToList();
            }
            grdData.DataSource = v_arrData_Temp;
        }
    }
}
