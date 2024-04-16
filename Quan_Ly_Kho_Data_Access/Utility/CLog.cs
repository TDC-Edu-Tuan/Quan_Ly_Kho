using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CLog
    {
        private string m_strTitle;
        private string m_strFunction_Code;
        private string m_strFunction_Name;
        private string m_strDescription;
        private double m_dblTotal_Time;

        public CLog()
        {
            Reset_Data();
        }

        public string Title { get => m_strTitle; set => m_strTitle = value.Trim(); }
        public string Function_Code { get => m_strFunction_Code; set => m_strFunction_Code = value.Trim(); }
        public string Function_Name { get => m_strFunction_Name; set => m_strFunction_Name = value.Trim(); }
        public string Description { get => m_strDescription; set => m_strDescription = value.Trim(); }
        public double Total_Time { get => m_dblTotal_Time; set => m_dblTotal_Time = value; }

        public void Reset_Data()
        {
            m_strTitle = CConst.STR_VALUE_NULL;
            m_strFunction_Code = CConst.STR_VALUE_NULL;
            m_strFunction_Name = CConst.STR_VALUE_NULL;
            m_strDescription = CConst.STR_VALUE_NULL;
            m_dblTotal_Time = CConst.DB_VALUE_NULL;
        }

        public void Write_To_Txt(string p_strFile_Path)
        {

            if (!File.Exists(p_strFile_Path))
                File.Create(p_strFile_Path);

            StringBuilder sb = new();

            sb.Append(m_strTitle);
            sb.Append("|");
            sb.Append(m_strFunction_Code);
            sb.Append("|");
            sb.Append(m_strFunction_Name);
            sb.Append("|");
            sb.Append(m_strDescription);
            sb.Append("|");
            sb.AppendLine(CUtility.Convert_To_String(m_dblTotal_Time) + "\n");

            BinaryWriter v_sw = new BinaryWriter(new FileStream(p_strFile_Path, FileMode.Append,FileAccess.Write));
            v_sw.Write(sb.ToString());
        }
    }
}
