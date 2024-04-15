using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CConfig
    {
        //Thông tin chuỗi kết nối
        public static string Quan_Li_Kho_Data_Connection_String = "";
        public static string Quan_Li_Kho_Sys_Connection_String = "";

        //Thông tin sản phẩm
        public static string Product_Name = "";
        public static string Product_Version = "";
        public static string Product_Auth = "";
        public static DateTime? Created = null;
        public static string Created_By = "";

        //Format
        public static string Date_Format_String = "";

        //File
        public static string Folder_File_Management_Path = "";

    }
}
