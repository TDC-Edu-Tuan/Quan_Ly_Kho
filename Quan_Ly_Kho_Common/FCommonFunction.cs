using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
