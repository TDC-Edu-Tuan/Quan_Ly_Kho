using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Sys;


namespace Quan_Ly_Kho_Data_Data_Access.Controller.Cache
{
    public class CCache_Phan_Quyen_Chuc_Nang
    {
        private static List<CSys_Phan_Quyen_Chuc_Nang> Arr_Data = new List<CSys_Phan_Quyen_Chuc_Nang>();
        private static Dictionary<long, CSys_Phan_Quyen_Chuc_Nang> Dic_Data_ID = new Dictionary<long, CSys_Phan_Quyen_Chuc_Nang>();
        private static Dictionary<string, CSys_Phan_Quyen_Chuc_Nang> Dic_Data_Code = new Dictionary<string, CSys_Phan_Quyen_Chuc_Nang>();

        public static void Load_Cache_DM_Phan_Quyen_Chuc_Nang()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();

            CSys_Phan_Quyen_Chuc_Nang_Controller v_objCtrData = new CSys_Phan_Quyen_Chuc_Nang_Controller();
            List<CSys_Phan_Quyen_Chuc_Nang> v_arrTemp_Data = v_objCtrData.FQ_527_PQCN_sp_sel_List_For_Cache();

            foreach (CSys_Phan_Quyen_Chuc_Nang v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Phan_Quyen_Chuc_Nang p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);
        }

        public static void Update_Data(CSys_Phan_Quyen_Chuc_Nang p_objData)
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

            CSys_Phan_Quyen_Chuc_Nang v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Nhom_Thanh_Vien_ID, v_objData.Chuc_Nang_ID);

            Dic_Data_Code.Remove(v_strKey_Code);
        }

        public static CSys_Phan_Quyen_Chuc_Nang Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Phan_Quyen_Chuc_Nang Get_Data_By_Code(string p_strCode)
        {
            string v_strKey = CUtility.Tao_Key(p_strCode);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }

        public static List<CSys_Phan_Quyen_Chuc_Nang> List_Chuc_Nang_By_Nhom_Thanh_Vien_ID(long p_lngNhom_Thanh_Vien_ID)
        {
            return Arr_Data.Where(it => it.Nhom_Thanh_Vien_ID == p_lngNhom_Thanh_Vien_ID).ToList();
        }
    }
}
