using Quan_Ly_Kho_Data_Access.Utility;

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


        public static DialogResult Show_Message_Box(string p_strHeader, string p_strCaption, int p_iType = 0)
        {
            DialogResult v_dlr = new DialogResult();
            switch (p_iType)
            {
                case (int)EMessage_Type.None:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    break;
                case (int)EMessage_Type.Error:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (int)EMessage_Type.Warning:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case (int)EMessage_Type.Stop:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case (int)EMessage_Type.Success:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case (int)EMessage_Type.Question:
                    v_dlr = MessageBox.Show(p_strCaption, p_strHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
            }
            return v_dlr;
        }


    }
}
