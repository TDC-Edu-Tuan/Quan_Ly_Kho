﻿namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CConfig
    {
        //Thông tin chuỗi kết nối
        public static string Quan_Ly_Kho_Data_Conn_String = "";

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

        //
        public static int Time_Out = 0;


        public static string Smtp_Host = "";
        public static bool Smtp_UseDefaultCredentials = false;
        public static int Smtp_Port = 0;
        public static string Smtp_User = "";
        public static string Smtp_Pass = "";
        public static bool Smtp_EnableSsl = false;
        public static string Email_From = "";
      }
}
