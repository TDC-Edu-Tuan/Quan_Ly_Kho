using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;
namespace Quan_Ly_Kho_Data_Data_Access.Controller.Cache
{
    public class CCache_Chu_Hang
    {
        private static List<CDM_Chu_Hang> Arr_Data = new List<CDM_Chu_Hang>();
        private static Dictionary<long, CDM_Chu_Hang> Dic_Data_ID = new Dictionary<long, CDM_Chu_Hang>();
        private static Dictionary<string, CDM_Chu_Hang> Dic_Data_Code = new Dictionary<string, CDM_Chu_Hang>();

        public static void Load_Cache_DM_Chu_Hang()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();

            CDM_Chu_Hang_Controller v_objCtrData = new CDM_Chu_Hang_Controller();
            List<CDM_Chu_Hang> v_arrTemp_Data = v_objCtrData.FQ_104_CH_sp_sel_List_For_Cache();

            foreach (CDM_Chu_Hang v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CDM_Chu_Hang p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Ma_CH);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);
        }

        public static void Update_Data(CDM_Chu_Hang p_objData)
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

            CDM_Chu_Hang v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Ma_CH);

            Dic_Data_Code.Remove(v_strKey_Code);
        }

        public static CDM_Chu_Hang Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CDM_Chu_Hang Get_Data_By_Code(string p_strCode)
        {
            string v_strKey = CUtility.Tao_Key(p_strCode);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }
    }
}
