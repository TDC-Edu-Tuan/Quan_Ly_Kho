﻿using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;

namespace Quan_Ly_Kho_Data_Access.Controller.Sys
{
    public class CSys_Frozen_Column_Controller
    {
        public List<CSys_Frozen_Column> FQ_513_FC_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Frozen_Column> v_arrRes = new List<CSys_Frozen_Column>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Frozen_Column v_objRes = CUtility.Map_Row_To_Entity<CSys_Frozen_Column>(v_row);
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

        public List<CSys_Frozen_Column> FQ_513_FC_sp_sel_List_For_Cache()
        {
            List<CSys_Frozen_Column> v_arrRes = new List<CSys_Frozen_Column>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Frozen_Column v_objRes = CUtility.Map_Row_To_Entity<CSys_Frozen_Column>(v_row);
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

        public CSys_Frozen_Column FQ_513_FC_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Frozen_Column v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSqlHelper.FillDataTable(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Frozen_Column>(v_dt.Rows[0]);
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

        public long FQ_513_FC_sp_ins_Insert(CSys_Frozen_Column p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_ins_Insert",
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_513_FC_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Frozen_Column p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_ins_Insert",
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_513_FC_sp_upd_Update(CSys_Frozen_Column p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_513_FC_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Frozen_Column p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Cot_Frozen, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_513_FC_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.Quan_Ly_Kho_Data_Conn_String, "FQ_513_FC_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
