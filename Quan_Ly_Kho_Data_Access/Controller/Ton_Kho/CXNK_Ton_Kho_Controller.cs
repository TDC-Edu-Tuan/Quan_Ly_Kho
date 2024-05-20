using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Data.Ton_Kho;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;

namespace Quan_Ly_Kho_Data_Access.Controller.Ton_Kho
{
    public class CXNK_Ton_Kho_Controller
    {
        public List<CXNK_Ton_Kho> FQ_722_TK_sp_sel_List_By_Created(long p_iChu_Hang_ID, long p_iKho_ID, DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CXNK_Ton_Kho> v_arrRes = new List<CXNK_Ton_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_722_TK_sp_sel_List_By_Created", p_iChu_Hang_ID, p_iKho_ID, p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Ton_Kho v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho>(v_row);
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


        public List<CXNK_Ton_Kho> FQ_722_TK_sp_sel_List_By_San_Pham_ID(SqlConnection p_conn,SqlTransaction p_trans,long p_iSan_Pham_ID,long p_iChu_Hang_ID, long p_iKho_ID)
        {
            List<CXNK_Ton_Kho> v_arrRes = new List<CXNK_Ton_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(p_conn, p_trans, "FQ_722_TK_sp_sel_List_By_San_Pham_ID", p_iSan_Pham_ID, p_iChu_Hang_ID, p_iKho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Ton_Kho v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho>(v_row);
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


        public CXNK_Ton_Kho FQ_722_TK_sp_sel_Get_By_ID(long p_iID)
        {
            CXNK_Ton_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_722_TK_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho>(v_dt.Rows[0]);
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


        public CXNK_Ton_Kho FQ_722_TK_sp_sel_Get_By_Raw_Data_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iID)
        {
            CXNK_Ton_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(p_conn, p_trans, "FQ_722_TK_sp_sel_Get_By_Raw_Data_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho>(v_dt.Rows[0]);
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

        public CXNK_Ton_Kho FQ_722_TK_sp_sel_Get_NK_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iID)
        {
            CXNK_Ton_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(p_conn, p_trans, "FQ_722_TK_sp_sel_Get_NK_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CXNK_Ton_Kho>(v_dt.Rows[0]);
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



        public long FQ_722_TK_sp_ins_Insert(CXNK_Ton_Kho p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_722_TK_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Vi_Tri_ID, p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID,
                    p_objData.Nhap_Kho_Raw_ID, p_objData.So_Luong, p_objData.Trang_Thai_Ton_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_722_TK_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Ton_Kho p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, "FQ_722_TK_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Vi_Tri_ID, p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID,
                    p_objData.Nhap_Kho_Raw_ID, p_objData.So_Luong, p_objData.Trang_Thai_Ton_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_722_TK_sp_upd_Update(CXNK_Ton_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_722_TK_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Vi_Tri_ID, p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID,
                    p_objData.Nhap_Kho_Raw_ID, p_objData.So_Luong, p_objData.Trang_Thai_Ton_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_722_TK_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Ton_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, "FQ_722_TK_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.Kho_ID, p_objData.Vi_Tri_ID, p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID,
                    p_objData.Nhap_Kho_Raw_ID, p_objData.So_Luong, p_objData.Trang_Thai_Ton_Kho, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_722_TK_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_722_TK_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
