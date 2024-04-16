using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CLogger
    {
        private static CLog m_objLog = new();

        private static bool Is_Error = false;


        public static void Save_Trace_Error_Log(string p_strTitle, string p_strFunc_Code, string p_strFunction_Name, string p_strDescription, double p_dblTime_Second_Excute)
        {
            Is_Error = true;

            Save_Trace_Log(p_strTitle, p_strFunc_Code, p_strFunction_Name, p_strDescription, p_dblTime_Second_Excute);
        }

        public static void Save_Trace_Log(string p_strTitle, string p_strFunc_Code, string p_strFunction_Name, string p_strDescription, double p_dblTime_Second_Excute)
        {
            DateTime v_dtmNow = DateTime.Now;
            string p_strFile_Path = Path.Combine(CConfig.Folder_File_Management_Path, $"Log{v_dtmNow.Day}{v_dtmNow.Day}{v_dtmNow.Day}.txt"); // Lưu log 1 ngày

            if (!File.Exists(p_strFile_Path))
                File.Create(p_strFile_Path);

            m_objLog.Reset_Data();

            if (Is_Error == true)
                m_objLog.Title = "Error|" + p_strTitle;

            m_objLog.Title = p_strTitle;

            m_objLog.Function_Code = p_strFunc_Code;
            m_objLog.Function_Name = p_strFunction_Name;
            m_objLog.Description = p_strDescription;
            m_objLog.Total_Time = p_dblTime_Second_Excute;

            m_objLog.Write_To_Txt(p_strFile_Path);
        }
    }
}
