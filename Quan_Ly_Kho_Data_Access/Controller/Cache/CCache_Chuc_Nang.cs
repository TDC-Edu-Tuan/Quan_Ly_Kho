using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Sys;


namespace Quan_Ly_Kho_Data_Data_Access.Controller.Cache
{
    public class CCache_Chuc_Nang
    {
        private static List<CSys_Chuc_Nang> Arr_Data = new List<CSys_Chuc_Nang>();
        private static Dictionary<long, CSys_Chuc_Nang> Dic_Data_ID = new Dictionary<long, CSys_Chuc_Nang>();
        private static Dictionary<string, CSys_Chuc_Nang> Dic_Data_Code = new Dictionary<string, CSys_Chuc_Nang>();

        public static void Load_Cache_DM_Chuc_Nang()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();

            CSys_Chuc_Nang_Controller v_objCtrData = new CSys_Chuc_Nang_Controller();
            List<CSys_Chuc_Nang> v_arrTemp_Data = v_objCtrData.FQ_507_CN_sp_sel_List_For_Cache();

            foreach (CSys_Chuc_Nang v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Chuc_Nang p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);
        }

        public static void Update_Data(CSys_Chuc_Nang p_objData)
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

            CSys_Chuc_Nang v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang);

            Dic_Data_Code.Remove(v_strKey_Code);
        }

        public static CSys_Chuc_Nang Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Chuc_Nang Get_Data_By_Code(string p_strCode)
        {
            string v_strKey = CUtility.Tao_Key(p_strCode);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }
    }
}
