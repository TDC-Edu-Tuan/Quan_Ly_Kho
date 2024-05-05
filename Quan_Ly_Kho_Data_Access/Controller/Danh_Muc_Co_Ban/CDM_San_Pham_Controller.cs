﻿using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;


namespace Quan_Ly_Kho_Data
{
    public class CDM_San_Pham_Controller
    {
        public List<CDM_San_Pham> FQ_165_SP_sp_sel_List_By_Created(long p_iChu_Hang_ID, DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CDM_San_Pham> v_arrRes = new List<CDM_San_Pham>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_sel_List_By_Created", p_iChu_Hang_ID, p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_San_Pham v_objRes = CUtility.Map_Row_To_Entity<CDM_San_Pham>(v_row);
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

        public List<CDM_San_Pham> FQ_165_SP_sp_sel_List_For_Cache()
        {
            List<CDM_San_Pham> v_arrRes = new List<CDM_San_Pham>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_San_Pham v_objRes = CUtility.Map_Row_To_Entity<CDM_San_Pham>(v_row);
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

        public CDM_San_Pham FQ_165_SP_sp_sel_Get_By_ID(long p_iID)
        {
            CDM_San_Pham v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CDM_San_Pham>(v_dt.Rows[0]);
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

        public long FQ_165_SP_sp_ins_Insert(CDM_San_Pham p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.DVT_ID, p_objData.LSP_ID, p_objData.Ma_SP, p_objData.Ten_SP,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_165_SP_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CDM_San_Pham p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_ins_Insert",
                    p_objData.Chu_Hang_ID, p_objData.DVT_ID, p_objData.LSP_ID, p_objData.Ma_SP, p_objData.Ten_SP,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_165_SP_sp_upd_Update(CDM_San_Pham p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.DVT_ID, p_objData.LSP_ID, p_objData.Ma_SP, p_objData.Ten_SP,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_165_SP_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CDM_San_Pham p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Chu_Hang_ID, p_objData.DVT_ID, p_objData.LSP_ID, p_objData.Ma_SP, p_objData.Ten_SP,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_165_SP_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_165_SP_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
