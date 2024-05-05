using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Sys;

namespace Quan_Ly_Kho_Data_Access.Controller.Cache
{
    public class CCache_Thanh_Vien
    {
        private static List<CSys_Thanh_Vien> Arr_Data = new();
        private static Dictionary<string, CSys_Thanh_Vien> Dic_Code = new();

        public static void Load_Thanh_Vien()
        {
            CSys_Thanh_Vien_Controller v_ctrlData = new();
            List<CSys_Thanh_Vien> v_arrTemp = v_ctrlData.FQ_531_TV_sp_sel_List_For_Cache();
            foreach (CSys_Thanh_Vien v_item in v_arrTemp)
                Add_Data(v_item);
        }

        public static void Add_Data(CSys_Thanh_Vien p_objData)
        {
            if (p_objData == null)
                return;

            //Kiểm tra trên mảng
            if (Arr_Data.FirstOrDefault(it => it.Ma_Dang_Nhap == p_objData.Ma_Dang_Nhap) != null)
                return;

            Arr_Data.Add(p_objData);

            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(p_objData.Ma_Dang_Nhap);
            if (Dic_Code.ContainsKey(v_strKey) == true)
                return;

            Dic_Code.Add(v_strKey, p_objData);

        }

        public static void Delete_Data(long p_lngKho_ID)
        {
            CSys_Thanh_Vien v_objValue = Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngKho_ID);
            if (v_objValue == null)
                return;

            Arr_Data.Remove(v_objValue);

            //Kiểm tra trong dic
            string v_strKey = CUtility.Tao_Key(v_objValue.Ma_Dang_Nhap);
            if (Dic_Code.ContainsKey(v_strKey) == false)
                return;

            Dic_Code.Remove(v_strKey);
        }

        public static void Update_Data(CSys_Thanh_Vien p_objData)
        {
            if (p_objData == null)
                return;

            if (Arr_Data.FirstOrDefault(it => it.Auto_ID == p_objData.Auto_ID) == null)
                return;

            Delete_Data(p_objData.Auto_ID);
            Add_Data(p_objData);
        }

        public static CSys_Thanh_Vien Get_Data_By_ID(long p_lngAuto_ID)
        {
            return Arr_Data.FirstOrDefault(it => it.Auto_ID == p_lngAuto_ID);
        }

        public static CSys_Thanh_Vien Get_Data_By_Code(string p_strCode)
        {
            if (p_strCode == CConst.STR_VALUE_NULL)
                return null;

            string v_strKey = CUtility.Tao_Key(p_strCode);

            if (Dic_Code.Keys.FirstOrDefault(it => it == v_strKey) == null)
                return null;

            CSys_Thanh_Vien v_objRes = Dic_Code[v_strKey];

            return v_objRes;
        }

        public static List<CSys_Thanh_Vien> List_Data()
        {
            return Arr_Data.ToList();
        }
    }
}
