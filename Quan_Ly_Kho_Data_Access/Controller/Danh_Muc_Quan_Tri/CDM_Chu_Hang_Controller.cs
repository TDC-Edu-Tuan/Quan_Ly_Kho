using Quan_Ly_Kho_Data_Access.Controller;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;


namespace Quan_Ly_Kho_Data_Access.Controller.Danh_Muc_Quan_Tri
{
    public class CDM_Chu_Hang_Controller : CController_Base<CDM_Chu_Hang>
    {
        public override List<CDM_Chu_Hang> List_Data()
        {
            DataTable v_dt = new();
            List<CDM_Chu_Hang> v_arrRes = new();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_sel_DM_Chu_Hang");

                foreach (DataRow v_row in v_dt.Rows)
                    v_arrRes.Add(CUtility.Map_Row_To_Entity<CDM_Chu_Hang>(v_row));

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

        public override CDM_Chu_Hang Get_Data_By_ID(long p_lngAuto_ID)
        {
            DataTable v_dt = new();
            CDM_Chu_Hang v_objRes = null;

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_sel_Get_Chu_Hang_By_ID", p_lngAuto_ID);

                if (v_dt.Rows.Count > 0)
                    v_objRes = CUtility.Map_Row_To_Entity<CDM_Chu_Hang>(v_dt.Rows[0]);
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

        public override long Add_Data(CDM_Chu_Hang p_objData)
        {
            long v_lngRes = CConst.INT_VALUE_NULL;
            try
            {
                v_lngRes = CUtility.Convert_To_Int64(CSqlHelper.ExecuteScarlar(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_ins_DM_Chu_Hang",
                    p_objData.Ma_Chu_Hang, p_objData.Ten_Chu_Hang, p_objData.Ghi_Chu,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }
            catch (Exception)
            {
                throw;
            }
            return v_lngRes;
        }

        public override void Update_Data(CDM_Chu_Hang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_upd_DM_Chu_Hang", p_objData.Auto_ID,
                    p_objData.Ma_Chu_Hang, p_objData.Ten_Chu_Hang, p_objData.Ghi_Chu, 
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
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
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Li_Kho_Data_Connection_String, "sp_del_DM_Chu_Hang", 
                    p_lngAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
