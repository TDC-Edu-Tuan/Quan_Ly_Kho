using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CUtility
    {
        static Random m_rand = new();
        #region Nhóm convert
        public static T Convert_Json_To_Object<T>(string p_strJson_Path)
        {
            // Đọc nội dung của tệp tin
            string v_strJson_Content = File.ReadAllText(p_strJson_Path);
            return JsonConvert.DeserializeObject<T>(v_strJson_Content);
        }

        public static string Convert_To_String(object p_objData)
        {
            if (p_objData == null)
                return CConst.STR_VALUE_NULL;

            return Convert.ToString(p_objData);
        }

        public static DateTime? Convert_To_DateTime(object p_objData, string p_strFormat)
        {
            if (p_objData == null)
                return CConst.DTM_VALUE_NULL;

            string v_strDateTime = Convert_To_String(p_objData);
            CultureInfo v_provider = CultureInfo.InvariantCulture;

            return DateTime.ParseExact(v_strDateTime, p_strFormat, v_provider);
        }

        public static DateTime? Convert_To_DateTime(object p_objData)
        {
            if (p_objData != System.DBNull.Value && p_objData != null)
                return Convert.ToDateTime(p_objData, CultureInfo.InvariantCulture);
            else
                return CConst.DTM_VALUE_NULL;
        }

        public static int Convert_To_Int32(object p_objData)
        {
            if (p_objData == null)
                return CConst.INT_VALUE_NULL;

            return Convert.ToInt32(p_objData);
        }

        public static long Convert_To_Int64(object p_objData)
        {
            if (p_objData == null)
                return CConst.INT_VALUE_NULL;

            return Convert.ToInt64(p_objData);
        }

        public static bool Convert_To_Bool(object p_objData)
        {
            if (p_objData == null)
                return CConst.IS_VALUE_NULL;

            return Convert.ToBoolean(p_objData);
        }

        public static double Convert_To_Double(object p_objData)
        {
            if (p_objData == null)
                return CConst.DB_VALUE_NULL;

            return Convert.ToDouble(p_objData);
        }

        public static string Convert_DateTime_To_String(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return CConst.STR_VALUE_NULL;

            return p_dtmData.Value.ToString(CConfig.Date_Format_String);
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate)
        {
            if (p_strDate == "")
                return CConst.DTM_VALUE_NULL;

            return Convert_String_To_Datetime(p_strDate, CConfig.Date_Format_String);
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate, string p_strFormat)
        {
            if (p_strDate == "")
                return CConst.DTM_VALUE_NULL;

            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(p_strDate, p_strFormat, provider);
        }

        #endregion 

        //Đọc 1 field trong file json
        public static string Map_Json_To_Entity_Field(string p_strJson_Path, string v_strFieldName)
        {
            string v_strRes = CConst.STR_VALUE_NULL;
            if (File.Exists(p_strJson_Path))//Kiểm tra file tồn tại
            {
                dynamic v_objValue = Convert_Json_To_Object<dynamic>(p_strJson_Path);

                //Kiểm tra có tồn tại field trong đối tượng không
                if (v_objValue[v_strFieldName] != null)
                {
                    v_strRes = v_objValue[v_strFieldName].ToString();
                }

            }
            return v_strRes;
        }

        //Tìm đường dẫn của 1 file trong source
        public static string Find_File_In_Solution(string p_strFileName)
        {
            string v_strRes = CConst.STR_VALUE_NULL;
            // Lấy đường dẫn đến thư mục gốc của solution
            string v_strSolutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            // Tìm tất cả các tệp tin có tên fileName trong solution
            string[] v_arrFiles = Directory.GetFiles(v_strSolutionDirectory, p_strFileName, SearchOption.AllDirectories);

            // Nếu tìm thấy ít nhất một tệp tin, trả về đường dẫn của tệp tin đầu tiên
            if (v_arrFiles.Length > 0)
                v_strRes = v_arrFiles[0];

            return v_strRes;
        }

        //Dùng để chuyển 1 dòng trong datatable thành entity
        public static T Map_Row_To_Entity<T>(DataRow p_Row) where T : new()
        {
            // create a new object
            T v_objItem = new();

            foreach (DataColumn v_colValue in p_Row.Table.Columns)
            {
                //  Tìm property của object
                PropertyInfo v_objItem_Info = v_objItem.GetType().GetProperty(v_colValue.ColumnName);

                // Kiểm tra giá trị có null hay không
                if (v_objItem_Info != null && p_Row[v_colValue] != DBNull.Value)
                {
                    MethodInfo v_objMethodInfo = v_objItem_Info.SetMethod;

                    // Kiểm tra propertie đó có cho phép gán dữ liệu không

                    if (v_objMethodInfo != null)
                    {
                        string v_strTypedata = v_colValue.DataType.Name;
                        switch (v_strTypedata)
                        {
                            case "String": v_objItem_Info.SetValue(v_objItem, Convert_To_String(p_Row[v_colValue])); break;
                            case "Int16": v_objItem_Info.SetValue(v_objItem, Convert_To_Int32(p_Row[v_colValue])); break;
                            case "Int32": v_objItem_Info.SetValue(v_objItem, Convert_To_Int32(p_Row[v_colValue])); break;
                            case "Int64": v_objItem_Info.SetValue(v_objItem, Convert_To_Int64(p_Row[v_colValue])); break;
                            case "DateTime": v_objItem_Info.SetValue(v_objItem, Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "DateTime?": v_objItem_Info.SetValue(v_objItem, Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "Double": v_objItem_Info.SetValue(v_objItem, Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Decimal": v_objItem_Info.SetValue(v_objItem, Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Boolean": v_objItem_Info.SetValue(v_objItem, Convert_To_Bool(p_Row[v_colValue]), null); break;
                        }
                    }
                }
            }

            // return 
            return v_objItem;
        }

        //format
        private static string Get_String_For_Tao_Key(object p_objData)
        {
            if (p_objData == null)
                return "";

            string v_strType = p_objData.GetType().Name.ToLower();
            string v_strRes = "";

            //Lấy kiểu dữ liệu để sử dụng hàm convert tương ứng (vì nó là object) để design text
            switch (v_strType.ToLower())
            {
                case "string": v_strRes = Convert_To_String(p_objData); break;
                case "int32": v_strRes = Convert_To_Int32(p_objData).ToString("###0"); break;
                case "int64": v_strRes = Convert_To_Int64(p_objData).ToString("###0"); break;
                case "double": v_strRes = Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "float": v_strRes = Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "datetime":
                    v_strRes = Convert_DateTime_To_String(Convert_To_DateTime(p_objData));
                    break;
                case "bool":
                    if (Convert_To_Bool(p_objData) == true)
                        v_strRes = "1";
                    else
                        v_strRes = "0";
                    break;
            }

            if (v_strRes == "")
                v_strRes = "";

            return v_strRes;
        }

        //Tạo key
        public static string Tao_Key(params object[] p_arrValue)
        {
            string v_strKey = "";
            if (p_arrValue == null)
                return "";

            for (int i = 0; i < p_arrValue.Length; i++)
            {
                string v_strValue = Get_String_For_Tao_Key(p_arrValue[i]);

                if (v_strKey == "")
                    v_strKey = v_strValue;
                else
                {
                    v_strKey += "|" + v_strValue;
                }
            }

            return v_strKey.ToUpper();
        }

        //Format
        private static string Get_String_For_Tao_Combo(object p_objData)
        {
            if (p_objData == null)
                return "";

            string v_strType = p_objData.GetType().Name.ToLower();
            string v_strRes = "";

            //Lấy kiểu dữ liệu để sử dụng hàm convert tương ứng (vì nó là object) để design text
            switch (v_strType.ToLower())
            {
                case "string": v_strRes = Convert_To_String(p_objData); break;
                case "int32": v_strRes = Convert_To_Int32(p_objData).ToString("###0"); break;
                case "int64": v_strRes = Convert_To_Int64(p_objData).ToString("###0"); break;
                case "double": v_strRes = Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "float": v_strRes = Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "datetime":
                    v_strRes = Convert_DateTime_To_String(Convert_To_DateTime(p_objData));
                    break;
                case "bool":
                    if (Convert_To_Bool(p_objData) == true)
                        v_strRes = "1";
                    else
                        v_strRes = "0";
                    break;
            }

            if (v_strRes == "")
                v_strRes = "";

            return v_strRes;
        }

        //Tạo trường theo combo
        public static string Tao_Combo_Text(params object[] p_arrValue)
        {
            string v_strKey = "";
            if (p_arrValue == null) // Check rỗng
                return "";

            for (int i = 0; i < p_arrValue.Length; i++)
            {
                string v_strValue = Get_String_For_Tao_Combo(p_arrValue[i]);

                if (v_strKey == "")
                    v_strKey = v_strValue;
                else
                {
                    if (v_strValue != "")
                        v_strKey += " (" + v_strValue + ")";
                }
            }

            return v_strKey;
        }

        //Mã hóa mật khẩu
        public static string MD5_Encrypt(string p_strSource)
        {
            UTF8Encoding p_utf8encoding = new UTF8Encoding();
            byte[] p_arrData = p_utf8encoding.GetBytes(p_strSource);

            System.Security.Cryptography.MD5CryptoServiceProvider p_md5Encrypt = new System.Security.Cryptography.MD5CryptoServiceProvider();

            byte[] v_arrHashData = p_md5Encrypt.ComputeHash(p_arrData);

            string v_strResult = "";

            for (int i = 0; i < v_arrHashData.Length; i++)
                v_strResult += Convert.ToString(v_arrHashData[i], 16).PadLeft(2, 'j');

            return v_strResult.PadLeft(32, 'n');
        }

        // Phương thức để kiểm tra xem một kiểu dữ liệu có phải là kiểu số không
        public static bool Is_Numeric_Type(Type p_type)
        {
            return p_type == typeof(int)
                || p_type == typeof(double)
                || p_type == typeof(decimal)
                || p_type == typeof(float)
                || p_type == typeof(long);
        }

        public static long Create_Rand_ID(int p_iLenght)
        {
            string v_strRes = CConst.STR_VALUE_NULL;
            for (int i = 0; i < p_iLenght; i++)
            {
                v_strRes += Convert_To_String(m_rand.Next(0, 10));
            }

            return Convert_To_Int64(v_strRes);
        }
    }
}
