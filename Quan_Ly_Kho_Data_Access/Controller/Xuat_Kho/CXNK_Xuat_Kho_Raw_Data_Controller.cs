using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Data.Xuat_kho;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;

namespace Quan_Ly_Kho_Data_Access.Controller.Xuat_Kho
{
    public class CXNK_Xuat_Kho_Raw_Data_Controller
    {
        public List<CXNK_Xuat_Kho_Raw_Data> FQ_734_XKRD_sp_sel_List_By_Created(long p_iChu_Hang_ID, long p_iKho_ID, DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_sel_List_By_Created", p_iChu_Hang_ID, p_iKho_ID, p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
                    v_arrRes.Add(v_objRes);
                }
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

        public List<CXNK_Xuat_Kho_Raw_Data> FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID(long p_iXuat_Kho_ID)
        {
            List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID", p_iXuat_Kho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
                    v_arrRes.Add(v_objRes);
                }
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

        public List<CXNK_Xuat_Kho_Raw_Data> FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iXuat_Kho_ID)
        {
            List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(p_conn, p_trans, "FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID", p_iXuat_Kho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
                    v_arrRes.Add(v_objRes);
                }
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

        public CXNK_Xuat_Kho_Raw_Data FQ_734_XKRD_sp_sel_Get_By_ID(long p_iID)
        {
            CXNK_Xuat_Kho_Raw_Data v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_dt.Rows[0]);
                }
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
        public CXNK_Xuat_Kho_Raw_Data FQ_734_XKRD_sp_sel_Get_By_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iID)
        {
            CXNK_Xuat_Kho_Raw_Data v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(p_conn, p_trans, "FQ_734_XKRD_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_dt.Rows[0]);
                }
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

        public long FQ_734_XKRD_sp_ins_Insert(CXNK_Xuat_Kho_Raw_Data p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong,
                    p_objData.Don_Gia, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_734_XKRD_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Raw_Data p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong,
                    p_objData.Don_Gia, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_734_XKRD_sp_upd_Update(CXNK_Xuat_Kho_Raw_Data p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong,
                    p_objData.Don_Gia, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_734_XKRD_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Raw_Data p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong,
                    p_objData.Don_Gia, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_734_XKRD_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_734_XKRD_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
        public void FQ_734_XKRD_sp_del_Delete_By_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, "FQ_734_XKRD_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_734_XKRD_sp_del_Delete_By_XK_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_lngXuat_Kho_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, "FQ_734_XKRD_sp_del_Delete_By_XK_ID", p_lngXuat_Kho_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

    }
}
