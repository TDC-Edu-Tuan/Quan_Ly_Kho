using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Common
{
    public class FCommonFunction : Form
    {

        public static void Set_Error_Label_Message(Label p_objLabel, string p_strMessage)
        {
            p_objLabel.Text = p_strMessage;
            p_objLabel.ForeColor = Color.Red;
        }

        public static void Set_Success_Label_Message(Label p_objLabel, string p_strMessage)
        {
            p_objLabel.Text = p_strMessage;
            p_objLabel.ForeColor = Color.Green;
        }

        public static void Load_Combo<T>(ComboBox p_objCombo, List<T> p_arrData, string p_strField_Value, string p_strDisplay)
        {
            T v_objData = p_arrData.FirstOrDefault();
            if (v_objData == null)
                return;

            //Kiểm tra field có tồn tại trong obj không

            PropertyInfo v_objValue_Field = v_objData.GetType().GetProperty(p_strField_Value);
            PropertyInfo v_objDisplay_Field = v_objData.GetType().GetProperty(p_strDisplay);

            if (v_objValue_Field == null || v_objDisplay_Field == null)
                return;

            p_objCombo.DataSource = p_arrData;
            p_objCombo.DisplayMember = p_strDisplay;
            p_objCombo.ValueMember = p_strField_Value;
        }
    }
}
