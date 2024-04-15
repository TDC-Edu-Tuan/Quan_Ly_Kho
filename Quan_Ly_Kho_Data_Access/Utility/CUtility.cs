﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Utility
{
    public class CUtility
    {
        //Dùng để convert 1 chuỗi json sang đối tượng
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
                            case "Int64": v_objItem_Info.SetValue(v_objItem,Convert_To_Int64(p_Row[v_colValue])); break;
                            case "DateTime": v_objItem_Info.SetValue(v_objItem, Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "DateTime?": v_objItem_Info.SetValue(v_objItem, Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "Double": v_objItem_Info.SetValue(v_objItem, Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Decimal": v_objItem_Info.SetValue(v_objItem, Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Boolean": v_objItem_Info.SetValue(v_objItem,Convert_To_Bool(p_Row[v_colValue]), null); break;
                        }
                    }
                }
            }

            // return 
            return v_objItem;
        }

    }
}