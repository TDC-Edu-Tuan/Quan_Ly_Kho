using System.Reflection;

namespace Quan_Ly_Kho_Controls
{
    public class FControl_Combobox_Base : ComboBox
    {
        protected static bool g_bIs_Success = false;
        protected static void Check_Fields_Combo<T>(T p_objType, string p_strValue_Field, string p_strValue_Display)
        {
            if (p_objType == null)
                return;

            //Kiểm tra field có tồn tại trong obj không
            PropertyInfo v_objValue_Field = p_objType.GetType().GetProperty(p_strValue_Field);
            PropertyInfo v_objDisplay_Field = p_objType.GetType().GetProperty(p_strValue_Display);

            if (v_objValue_Field == null || v_objDisplay_Field == null)
                return;

            g_bIs_Success = true;
        }
    }
}
