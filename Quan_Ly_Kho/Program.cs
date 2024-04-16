using DevExpress.Skins;
using DevExpress.UserSkins;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Load_Config();

            Load_Cache_Quan_Tri();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }

        static void Load_Config()
        {
            string v_strJson_Path = CUtility.Find_File_In_Solution("appsetting.json");

            //Chuỗi kết nối
            CConfig.Quan_Li_Kho_Data_Connection_String = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Quan_Li_Kho_Data_Connection_String");
            CConfig.Quan_Li_Kho_Sys_Connection_String = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Quan_Li_Kho_Sys_Connection_String");

            //Format time
            CConfig.Date_Format_String = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Date_Format_String");

            CConfig.Time_Out = CUtility.Convert_To_Int32(CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Time_Out"));

            //Thông tin sản phẩm
            CConfig.Product_Name = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Product_Name");
            CConfig.Product_Version = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Product_Version");
            CConfig.Product_Auth = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Product_Auth");
            CConfig.Created = CUtility.Convert_String_To_Datetime(CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Created"));
            CConfig.Created_By = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Created_By");

            //Tạo thư mục file Manamangent
            CConfig.Folder_File_Management_Path = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Folder_File_Management_Path");
            if (!Directory.Exists(CConfig.Folder_File_Management_Path)) // Tạo thư mục nếu chưa có
                Directory.CreateDirectory(CConfig.Folder_File_Management_Path);

        }

        //Dùng để load cache các danh mục quản trị
        static void Load_Cache_Quan_Tri()
        {
            bool v_bIs_First_Load_Cache = false;
            long v_lngError = 0;
            //Load cache
            DateTime v_dtmStart = DateTime.Now;
            TimeSpan v_span = new();
            do
            {
                try
                {
                    CCache_Kho.Load_Kho();
                    v_bIs_First_Load_Cache = true;
                }
                catch (Exception)
                {
                    v_lngError++;
                }

                v_span = DateTime.Now - v_dtmStart;

            } while (v_bIs_First_Load_Cache == false && v_span.TotalSeconds <= CConfig.Time_Out);

            if (v_bIs_First_Load_Cache == false)//Nếu cờ không được bật thì tắt chương trình
            {
                CLogger.Save_Trace_Error_Log("Load Cache", "Load_Cache_Quan_Tri", "Load Cache Quản Trị", $"Cache chờ quá lâu", v_span.TotalSeconds);
                Application.Exit(); // Đóng chương trình
            }

        }

        //Dùng để kiểm tra các điều kiện
    }
}