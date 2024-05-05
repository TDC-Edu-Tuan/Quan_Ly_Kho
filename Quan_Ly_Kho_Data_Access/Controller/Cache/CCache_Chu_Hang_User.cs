using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Data_Access.Controller.Cache
{
    public class CCache_Chu_Hang_User
    {
        private static List<CDM_Chu_Hang_User> Arr_Data = new List<CDM_Chu_Hang_User>();
        private static Dictionary<long, CDM_Chu_Hang_User> Dic_Data_ID = new Dictionary<long, CDM_Chu_Hang_User>();
        private static Dictionary<string, CDM_Chu_Hang_User> Dic_Data_Code = new Dictionary<string, CDM_Chu_Hang_User>();
        private static Dictionary<long, List<CDM_Chu_Hang_User>> Dic_Data_Chu_Hang = new Dictionary<long, List<CDM_Chu_Hang_User>>();

        public static void Load_Cache_DM_Chu_Hang_User()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();
            Dic_Data_Chu_Hang.Clear();

            CDM_Chu_Hang_User_Controller v_objCtrData = new CDM_Chu_Hang_User_Controller();
            List<CDM_Chu_Hang_User> v_arrTemp_Data = v_objCtrData.FQ_107_CHU_sp_sel_List_For_Cache();

            foreach (CDM_Chu_Hang_User v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CDM_Chu_Hang_User p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Chu_Hang_ID, p_objData.Thanh_Vien_ID);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);

            if (Dic_Data_Chu_Hang.ContainsKey(p_objData.Chu_Hang_ID) == false)
                Dic_Data_Chu_Hang.Add(p_objData.Chu_Hang_ID, new List<CDM_Chu_Hang_User>());
            Dic_Data_Chu_Hang[p_objData.Chu_Hang_ID].Add(p_objData);
        }

        public static void Update_Data(CDM_Chu_Hang_User p_objData)
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

            CDM_Chu_Hang_User v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Chu_Hang_ID, v_objData.Thanh_Vien_ID);

            Dic_Data_Code.Remove(v_strKey_Code);
            Dic_Data_Chu_Hang[v_objData.Chu_Hang_ID].Remove(v_objData);
        }

        public static CDM_Chu_Hang_User Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CDM_Chu_Hang_User Get_Data_By_Code(long p_iChu_Hang_ID, string p_strCode)
        {
            string v_strKey = CUtility.Tao_Key(p_iChu_Hang_ID, p_strCode);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }

        public static List<CDM_Chu_Hang_User> List_Data_By_Chu_Hang_ID(long p_iChu_Hang_ID)
        {
            if (Dic_Data_Chu_Hang.ContainsKey(p_iChu_Hang_ID) == true)
                return Dic_Data_Chu_Hang[p_iChu_Hang_ID].ToList();

            return new List<CDM_Chu_Hang_User>();
        }

        public static List<CDM_Chu_Hang_User> List_Data_By_Thanh_Vien_ID(long p_iThanh_Vien_ID)
        {
            return Arr_Data.Where(it => it.Thanh_Vien_ID == p_iThanh_Vien_ID).ToList();
        }
    }
}
