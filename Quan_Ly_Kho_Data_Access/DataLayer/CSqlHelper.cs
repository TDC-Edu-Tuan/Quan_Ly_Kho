using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.DataLayer
{
    public class CSqlHelper
    {
        public static SqlConnection Create_Connection(string p_strConnection_String)
        {
            SqlConnection v_conn = new(p_strConnection_String);

            if (v_conn == null)
                throw new Exception("Chuỗi kết nối có vấn đề.");

            return v_conn;
        }

        /// <summary>
        /// Lấy dữ liệu từ db
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_trans"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable FillDataTable(SqlConnection p_conn, SqlTransaction p_trans, string p_strStored_Name, params object[] p_arrParams)
        {
            DataTable v_dt = new();

            SqlCommand v_command = new SqlCommand();
            v_command.CommandType = CommandType.StoredProcedure;
            v_command.Connection = p_conn;
            v_command.Transaction = p_trans;
            v_command.CommandTimeout = 300;
            v_command.CommandText = p_strStored_Name;

            SqlCommandBuilder.DeriveParameters(v_command);

            if (v_command.Parameters.Count - 1 != p_arrParams.Length)
                throw new Exception("Số lượng tham số truyền vào không đúng.");

            if (p_arrParams != null && p_arrParams.Length > 0)
            {
                for (int i = 0; i < p_arrParams.Length; i++)
                {
                    if (p_arrParams[i] == null)
                        v_command.Parameters[i + 1].Value = DBNull.Value;
                    else
                        v_command.Parameters[i + 1].Value = p_arrParams[i];
                }
            }

            SqlDataAdapter v_da = new(v_command);
            v_da.Fill(v_dt);

            return v_dt;
        }

        /// <summary>
        /// Lấy dữ liệu từ db
        /// </summary>
        /// <param name="p_strConnection_String"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        /// <returns></returns>
        public static DataTable FillDataTable(string p_strConnection_String, string p_strStored_Name, params object[] p_arrParams)
        {
            DataTable v_dt = new();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            DateTime v_dtmStart = DateTime.Now;

            try
            {
                v_conn = Create_Connection(p_strConnection_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                v_dt = FillDataTable(v_conn, v_trans, p_strStored_Name, p_arrParams);

                v_trans.Commit();

                TimeSpan v_span = DateTime.Now - v_dtmStart; // Thời gian viết log

                CLogger.Save_Trace_Log("Fill:", "Sql-FillDataTable", "FillDataTable", "Get Data From Database", v_span.TotalSeconds);// Ghi log

            }
            catch (Exception ex)
            {
                TimeSpan v_span = DateTime.Now - v_dtmStart;

                CLogger.Save_Trace_Error_Log("Fill:", "Sql-FillDataTable", "FillDataTable", "Error: " + ex.Message, v_span.TotalSeconds); // Ghi log

                if (v_trans != null)
                    v_trans.Rollback();

                throw ex;
            }
            finally
            {
                if (v_trans != null)
                    v_trans.Dispose();

                if (v_conn != null)
                    v_conn.Close();
            }

            return v_dt;
        }

        /// <summary>
        /// Thực thi store có giá trị trả về
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_trans"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object ExecuteScarlar(SqlConnection p_conn, SqlTransaction p_trans, string p_strStored_Name, params object[] p_arrParams)
        {
            object v_objRes = CConst.OBJ_VALUE_NULL;

            SqlCommand v_command = new SqlCommand();
            v_command.CommandType = CommandType.StoredProcedure;
            v_command.Connection = p_conn;
            v_command.Transaction = p_trans;
            v_command.CommandTimeout = 300;
            v_command.CommandText = p_strStored_Name;

            SqlCommandBuilder.DeriveParameters(v_command);

            if (v_command.Parameters.Count - 1 != p_arrParams.Length)
                throw new Exception("Số lượng tham số truyền vào không đúng.");

            if (p_arrParams != null && p_arrParams.Length > 0)
            {
                for (int i = 0; i < p_arrParams.Length; i++)
                {
                    if (p_arrParams[i] == null)
                        v_command.Parameters[i + 1].Value = DBNull.Value;
                    else
                        v_command.Parameters[i + 1].Value = p_arrParams[i];
                }
            }

            v_objRes = v_command.ExecuteScalar();

            return v_objRes;
        }

        /// <summary>
        /// Thực thi store có giá trị trả về
        /// </summary>
        /// <param name="p_strConnection_String"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        /// <returns></returns>
        public static object ExecuteScarlar(string p_strConnection_String, string p_strStored_Name, params object[] p_arrParams)
        {
            object v_objRes = CConst.OBJ_VALUE_NULL;
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            DateTime v_dtmStart = DateTime.Now;

            try
            {
                v_conn = Create_Connection(p_strConnection_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                v_objRes = ExecuteScarlar(v_conn, v_trans, p_strStored_Name, p_arrParams);

                v_trans.Commit();
                TimeSpan v_span = DateTime.Now - v_dtmStart;

                CLogger.Save_Trace_Log("ExecuteScarlar:", "Sql-ExecuteScarlar", "ExecuteScarlar", "Execute sucess", v_span.TotalSeconds);// Ghi log

            }
            catch (Exception ex)
            {
                TimeSpan v_span = DateTime.Now - v_dtmStart;

                CLogger.Save_Trace_Error_Log("ExecuteScarlar:", "Sql-ExecuteScarlar", "ExecuteScarlar", "Error: " + ex.Message, v_span.TotalSeconds); // Ghi log

                if (v_trans != null)
                    v_trans.Rollback();

                throw ex;
            }
            finally
            {
                if (v_trans != null)
                    v_trans.Dispose();

                if (v_conn != null)
                    v_conn.Close();
            }

            return v_objRes;
        }

        /// <summary>
        /// Thực thi store không có tham số trả về
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_trans"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        /// <exception cref="Exception"></exception>
        public static void ExecuteNonquery(SqlConnection p_conn, SqlTransaction p_trans, string p_strStored_Name, params object[] p_arrParams)
        {
            SqlCommand v_command = new SqlCommand();
            v_command.CommandType = CommandType.StoredProcedure;
            v_command.Connection = p_conn;
            v_command.Transaction = p_trans;
            v_command.CommandTimeout = 300;
            v_command.CommandText = p_strStored_Name;

            SqlCommandBuilder.DeriveParameters(v_command);

            if (v_command.Parameters.Count - 1 != p_arrParams.Length)
                throw new Exception("Số lượng tham số truyền vào không đúng.");

            if (p_arrParams != null && p_arrParams.Length > 0)
            {
                for (int i = 0; i < p_arrParams.Length; i++)
                {
                    if (p_arrParams[i] == null)
                        v_command.Parameters[i + 1].Value = DBNull.Value;
                    else
                        v_command.Parameters[i + 1].Value = p_arrParams[i];
                }
            }

            v_command.ExecuteNonQuery();
        }

        /// <summary>
        /// Thực thi store không có tham số trả về
        /// </summary>
        /// <param name="p_strConnection_String"></param>
        /// <param name="p_strStored_Name"></param>
        /// <param name="p_arrParams"></param>
        public static void ExecuteNonquery(string p_strConnection_String, string p_strStored_Name, params object[] p_arrParams)
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            DateTime v_dtmStart = DateTime.Now;

            try
            {
                v_conn = Create_Connection(p_strConnection_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();

                ExecuteNonquery(v_conn, v_trans, p_strStored_Name, p_arrParams);

                v_trans.Commit();
                TimeSpan v_span = DateTime.Now - v_dtmStart;

                CLogger.Save_Trace_Log("ExecuteNonquery:", "Sql-ExecuteNonquery", "ExecuteNonquery", "Execute: Success", v_span.TotalSeconds);// Ghi log

            }
            catch (Exception ex)
            {
                TimeSpan v_span = DateTime.Now - v_dtmStart;

                CLogger.Save_Trace_Error_Log("ExecuteScarlar:", "Sql-ExecuteScarlar", "ExecuteScarlar", "Execute: Error" + ex.Message, v_span.TotalSeconds); // Ghi log

                if (v_trans != null)
                    v_trans.Rollback();

                throw ex;
            }
            finally
            {
                if (v_trans != null)
                    v_trans.Dispose();

                if (v_conn != null)
                    v_conn.Close();
            }

        }


    }
}
