using Quan_Ly_Kho_Data_Access.Controller;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;


namespace Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri
{
    public class CDM_Kho_Controller : CController_Base<CDM_Kho>
    {
        public override List<CDM_Kho> List_Data()
        {
            DataTable v_dt = new();
            List<CDM_Kho> v_arrRes = new();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_sel_List_Kho");

                foreach (DataRow v_row in v_dt.Rows)
                    v_arrRes.Add(CUtility.Map_Row_To_Entity<CDM_Kho>(v_row));

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_arrRes;
        }

        public override CDM_Kho Get_Data_By_ID(long p_lngAuto_ID)
        {
            DataTable v_dt = new();
            CDM_Kho v_objRes = null;

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_sel_Get_Kho_By_ID");

                if (v_dt.Rows.Count > 0)
                    v_objRes = CUtility.Map_Row_To_Entity<CDM_Kho>(v_dt.Rows[0]);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_objRes;
        }

        public override long Add_Data(CDM_Kho p_objData)
        {
            long v_lngRes = CConst.INT_VALUE_NULL;
            try
            {
                v_lngRes = CUtility.Convert_To_Int64(CSqlHelper.ExecuteScarlar(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_ins_Kho",
                    p_objData.Ma_Kho, p_objData.Ten_Kho, p_objData.Loai_Hinh_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }
            catch (Exception)
            {
                throw;
            }
            return v_lngRes;
        }

        public override void Update_Data(CDM_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_upd_Kho", p_objData.Auto_ID,
                    p_objData.Ma_Kho, p_objData.Ten_Kho, p_objData.Loai_Hinh_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Delete_Data(long p_lngAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_del_Kho", p_lngAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
