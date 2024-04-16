using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Controller.Cache
{
    public class CCache_Kho
    {
        private static List<CDM_Kho> Arr_Data = new();
        private static Dictionary<string, CDM_Kho> Dic_Code = new();

        public static void Load_Kho()
        {
            CDM_Kho_Controller v_ctrlData = new();
            List<CDM_Kho> v_arrTemp = v_ctrlData.List_Data();
            foreach (CDM_Kho v_item in v_arrTemp)
                Add_Data(v_item);
        }

        public static void Add_Data(CDM_Kho p_objData)
        {
            if (p_objData == null)
                return;

            //Kiểm tra trên mảng
            if (Arr_Data.FirstOrDefault(it => it.Ma_Kho == p_objData.Ma_Kho) != null)
                return;

            Arr_Data.Add(p_objData);


            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(p_objData.Ma_Kho);
            if (Dic_Code.ContainsKey(v_strKey) == true)
                return;

            Dic_Code.Add(v_strKey, p_objData);

        }

        public static void Delete_Data(long p_lngKho_ID)
        {
            CDM_Kho v_objValue = Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngKho_ID);
            if (v_objValue == null)
                return;

            Arr_Data.Remove(v_objValue);

            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(v_objValue.Ma_Kho);
            if (Dic_Code.ContainsKey(v_strKey) == false)
                return;

            Dic_Code.Remove(v_strKey);
        }

        public static void Update_Data(CDM_Kho p_objData)
        {
            if (p_objData == null)
                return;

            if (Arr_Data.FirstOrDefault(it => it.Auto_ID == p_objData.Auto_ID) == null)
                return;

            Delete_Data(p_objData.Auto_ID);
            Add_Data(p_objData);
        }

        public static CDM_Kho Get_Kho_By_ID(long p_lngAuto_ID)
        {
            return Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngAuto_ID);
        }

        public static CDM_Kho Get_Data_By_Code(string p_strCode)
        {
            if (p_strCode == CConst.STR_VALUE_NULL)
                return null;

            string v_strKey = CUtility.Tao_Key(p_strCode);

            if(Dic_Code.Keys.FirstOrDefault(it=>it == v_strKey) ==null)
                return null;

            CDM_Kho v_objRes = Dic_Code[v_strKey];

            return v_objRes;
        }

        public static List<CDM_Kho> List_Data()
        {
            return Arr_Data.ToList();
        }
    }
}
