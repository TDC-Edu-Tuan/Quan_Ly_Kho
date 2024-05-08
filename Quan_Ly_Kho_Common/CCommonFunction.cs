using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using System.IO;

namespace Quan_Ly_Kho_Common
{
    public class CCommonFunction
    {
        public static void Load_Cache()
        {
            bool v_bIs_First_Load_Cache = false;
            //Load cache
            DateTime v_dtmStart = DateTime.Now;
            TimeSpan v_span = new();
            do
            {
                v_bIs_First_Load_Cache = true; // Start load cache
                try
                {
                    //Cache quản trị
                    CCache_Kho.Load_Cache_DM_Kho();
                    CCache_Kho_User.Load_Cache_DM_Kho_User();
                    CCache_Chu_Hang.Load_Cache_DM_Chu_Hang();
                    CCache_Chu_Hang_User.Load_Cache_DM_Chu_Hang_User();

                    //Cache cơ bản
                    CCache_Don_Vi_Tinh.Load_Cache_DM_Don_Vi_Tinh();
                    CCache_Loai_San_Pham.Load_Cache_DM_Loai_San_Pham();
                    CCache_San_Pham.Load_Cache_DM_San_Pham();
                    CCache_Day_Ke.Load_Cache_DM_Day_Ke();
                    CCache_Vi_Tri.Load_Cache_DM_Vi_Tri();
                    CCache_NCC.Load_Cache_DM_NCC();
                    CCache_Noi_Xuat_Den.Load_Cache_DM_Noi_Xuat_Den();
                    CCache_Nhan_Vien_Kho.Load_Cache_DM_Nhan_Vien_Kho();

                    v_bIs_First_Load_Cache = false; // Stop load cache

                }
                catch (Exception)
                {

                }

                v_span = DateTime.Now - v_dtmStart;

            } while (v_bIs_First_Load_Cache == true && v_span.TotalSeconds <= CConfig.Time_Out);

            if (v_bIs_First_Load_Cache == true)//Nếu cờ không được bật => cache lỗi
            {
                CLogger.Save_Trace_Error_Log("Load Cache", "Load_Cache", "Load Cache ", "Cache load quá lâu", v_span.TotalSeconds);
                throw new Exception("Lỗi cache vui lòng liên hệ nhà phát hành để xử lý");
            }

        }

        public static void Load_Config()
        {
            string v_strJson_Path = CUtility.Find_File_In_Solution("appsetting.json");

            //Chuỗi kết nối
            CConfig.Quan_Ly_Kho_Data_Conn_String = CUtility.Map_Json_To_Entity_Field(v_strJson_Path, "Quan_Ly_Kho_Data_Conn_String");

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

            // Nếu không có đường dẫn được cung cấp, sử dụng thư mục Downloads mặc định
            string v_strLog_Excel = Path.Combine(CConfig.Folder_File_Management_Path, "log_excel");
            string v_strLog_Txt = Path.Combine(CConfig.Folder_File_Management_Path, "log_txt");

            //Kiểm tra nếu thư mục log chưa tồn tại thì tạo
            if (!Directory.Exists(v_strLog_Excel))
                Directory.CreateDirectory(v_strLog_Excel);

            if (!Directory.Exists(v_strLog_Txt))
                Directory.CreateDirectory(v_strLog_Txt);


        }

    }

}
