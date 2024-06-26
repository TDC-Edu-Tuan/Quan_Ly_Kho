﻿using Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Controller.Cache
{
    public class CCache_Day_Ke
    {
        private static List<CDM_Day_Ke> Arr_Data = new List<CDM_Day_Ke>();
        private static Dictionary<long, CDM_Day_Ke> Dic_Data_ID = new Dictionary<long, CDM_Day_Ke>();
        private static Dictionary<string, CDM_Day_Ke> Dic_Data_Code = new Dictionary<string, CDM_Day_Ke>();
        private static Dictionary<long, List<CDM_Day_Ke>> Dic_Data_Kho = new Dictionary<long, List<CDM_Day_Ke>>();

        public static void Load_Cache_DM_Day_Ke()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();
            Dic_Data_Kho.Clear();

            CDM_Day_Ke_Controller v_objCtrData = new CDM_Day_Ke_Controller();
            List<CDM_Day_Ke> v_arrTemp_Data = v_objCtrData.FQ_109_DK_sp_sel_List_For_Cache();

            foreach (CDM_Day_Ke v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CDM_Day_Ke p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Kho_ID, p_objData.Ma_Ke);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);

            if (Dic_Data_Kho.ContainsKey(p_objData.Kho_ID) == false)
                Dic_Data_Kho.Add(p_objData.Kho_ID, new List<CDM_Day_Ke>());
            Dic_Data_Kho[p_objData.Kho_ID].Add(p_objData);
        }

        public static void Update_Data(CDM_Day_Ke p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == false || p_objData.Auto_ID == 0)
                return;

            Delete_Data(p_objData.Auto_ID);
            Add_Data(p_objData);
        }

        public static void Delete_Data(long p_iAuto_ID)
        {
            if (Dic_Data_ID.ContainsKey(p_iAuto_ID) == false || p_iAuto_ID == 0)
                return;

            CDM_Day_Ke v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Kho_ID, v_objData.Ma_Ke);

            Dic_Data_Code.Remove(v_strKey_Code);
            Dic_Data_Kho[v_objData.Kho_ID].Remove(v_objData);
        }

        public static CDM_Day_Ke Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CDM_Day_Ke Get_Data_By_Code(long p_iKho_ID, string p_strCode)
        {
            string v_strKey = CUtility.Tao_Key(p_iKho_ID, p_strCode);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }

        public static List<CDM_Day_Ke> List_Data_By_Kho_ID(long p_iKho_ID)
        {
            if (Dic_Data_Kho.ContainsKey(p_iKho_ID) == true)
                return Dic_Data_Kho[p_iKho_ID].ToList();

            return new List<CDM_Day_Ke>();
        }
    }
}
