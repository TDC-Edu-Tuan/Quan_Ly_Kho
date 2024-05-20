
using Quan_Ly_Kho_Data_Access.Data.Sys;

namespace Quan_Ly_Kho_Controls.Sys
{
    public class FControl_Thanh_Vien_Combo : FControl_Combobox_Base
    {
        public static void Load_Combo(ComboBox p_objCombo, List<CSys_Thanh_Vien> p_arrData, string p_strValue_Field,
              string p_strValue_Display)
        {
            if (p_arrData.Count == 0)
                return;

            CSys_Thanh_Vien v_objFirst = p_arrData.FirstOrDefault();
            Check_Fields_Combo(v_objFirst, p_strValue_Field, p_strValue_Display);

            if (g_bIs_Success == false)
                return;

            p_objCombo.ValueMember = p_strValue_Field;
            p_objCombo.DisplayMember = p_strValue_Display;
            p_objCombo.DataSource = p_arrData.ToList();


        }
    }
}
