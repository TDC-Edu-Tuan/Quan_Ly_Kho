using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraBars.Alerter;

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

        /// <summary>
        /// Bắt lỗi trên label
        /// </summary>
        /// <param name="p_objLabel"></param>
        /// <param name="p_strMessage"></param>
        public static void Set_Error_Label_Message(Label p_objLabel, string p_strMessage)
        {
            p_objLabel.Text = p_strMessage;
            p_objLabel.ForeColor = Color.Red;
        }

        /// <summary>
        /// Xuất kq trên label
        /// </summary>
        /// <param name="p_objLabel"></param>
        /// <param name="p_strMessage"></param>

        public static void Set_Success_Label_Message(Label p_objLabel, string p_strMessage)
        {
            p_objLabel.Text = p_strMessage;
            p_objLabel.ForeColor = Color.Green;
        }

        /// <summary>
        /// Load combo box
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_objCombo"></param>
        /// <param name="p_arrData"></param>
        /// <param name="p_strField_Value"></param>
        /// <param name="p_strDisplay"></param>

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

        #region Start load Alert
        public static void Show_Alert(AlertControl p_objAlert, Form p_objForm, string title, string message)
        {
            // Set properties for the alert control
            p_objAlert.AutoFormDelay = 1; 
            p_objAlert.FormLocation = AlertFormLocation.BottomRight; // Set alert location

            // Disable pin button (optional)
            p_objAlert.ShowPinButton = false;

            AlertInfo info = new AlertInfo(title, message);
            p_objAlert.Show(p_objForm, info);
        }
        #endregion Stop load alert

    }
}
