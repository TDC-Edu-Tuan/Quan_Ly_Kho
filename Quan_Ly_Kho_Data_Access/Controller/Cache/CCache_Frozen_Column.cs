using Quan_Ly_Kho_Data_Access.Controller.Sys;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;


namespace Quan_Ly_Kho_Data_Access.Controller.Cache
{
    public class CCache_Frozen_Column
    {
        private static List<CSys_Frozen_Column> Arr_Data = new();
        private static Dictionary<string, CSys_Frozen_Column> Dic_Code = new Dictionary<string, CSys_Frozen_Column>();

        public static void Load_Frozen_Column()
        {
            CSys_Frozen_Column_Controller v_ctrlData = new();
            List<CSys_Frozen_Column> v_arrTemp = v_ctrlData.FQ_513_FC_sp_sel_List_For_Cache();
            foreach (CSys_Frozen_Column v_item in v_arrTemp)
                Add_Data(v_item);
        }

        public static void Add_Data(CSys_Frozen_Column p_objData)
        {
            //Kiểm tra trên mảng
            if (Arr_Data.FirstOrDefault(it => it.Ma_Chuc_Nang == p_objData.Ma_Chuc_Nang) != null)
                return;

            Arr_Data.Add(p_objData);

            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen);
            if (Dic_Code.ContainsKey(v_strKey) == true)
                return;

            Dic_Code.Add(v_strKey, p_objData);

        }

        public static void Delete_Data(long p_lngKho_ID)
        {
            CSys_Frozen_Column v_objValue = Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngKho_ID);
            if (v_objValue == null)
                return;

            Arr_Data.Remove(v_objValue);

            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(v_objValue.Ma_Chuc_Nang, v_objValue.Ten_Cot_Frozen);
            if (Dic_Code.ContainsKey(v_strKey) == false)
                return;

            Dic_Code.Remove(v_strKey);
        }

        public static void Update_Data(CSys_Frozen_Column p_objData)
        {
            string v_strKey = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen);

            if (Dic_Code.ContainsKey(v_strKey) == false)
                return;

            Delete_Data(p_objData.Auto_ID);
            Add_Data(p_objData);
        }

        public static CSys_Frozen_Column Get_Data_By_ID(long p_lngAuto_ID)
        {
            return Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngAuto_ID);
        }

        public static CSys_Frozen_Column Get_Data_By_Code(string p_strCodeFunction, string p_strTen_Cot_Frozen)
        {
            if (p_strCodeFunction == CConst.STR_VALUE_NULL || p_strTen_Cot_Frozen == CConst.STR_VALUE_NULL)
                return null;

            string v_strKey = CUtility.Tao_Key(p_strCodeFunction, p_strTen_Cot_Frozen);

            if (Dic_Code.Keys.FirstOrDefault(it => it == v_strKey) == null)
                return null;

            CSys_Frozen_Column v_objRes = Dic_Code[v_strKey];

            return v_objRes;
        }

        public static List<CSys_Frozen_Column> List_Data()
        {
            return Arr_Data.ToList();
        }
    }
}
