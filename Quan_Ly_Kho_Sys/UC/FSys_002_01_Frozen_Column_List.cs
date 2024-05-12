using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Sys;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.DataLayer;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Data;
using System.Text;

namespace Quan_Ly_Kho_Sys
{
    public partial class FSys_002_01_Frozen_Column_List : UCBase
    {
        private List<CSys_Frozen_Column> m_arrData = new();

        public FSys_002_01_Frozen_Column_List()
        {
            InitializeComponent();
            g_bIs_View_Permission = true;
            g_bIs_Deleted_Permission = true;

            // Chuyển đổi mã màu hex thành màu Color
            Color navColor = ColorTranslator.FromHtml("#d8bfd8");

            // Đặt màu nền cho panel2
            panel2.BackColor = navColor;
        }

        protected override void Load_Init()
        {
            dtmFrom.Value = CUtility_Date.Convert_To_Dau_Ngay(DateTime.Now.AddDays(-15));
            dtmTo.Value = CUtility_Date.Convert_To_Cuoi_Ngay(DateTime.Now);

            g_grdData = grdData; //Để tham chiếu tới export excel
            Disable_Default_Col();
            g_arrCol_Hiden.Add("Mat_Khau");
            g_arrCol_Hiden.Add("Nhom_Frozen_Column_ID");

            g_dicCol_Name.Add("Ma_Chuc_Nang", "Mã Chức Năng");
            g_dicCol_Name.Add("Ten_Cot_Frozen", "Tên Cột");
            g_dicCol_Name.Add("Ghi_Chu", "Ghi Chú");


            g_dicCol_Size.Add("Ma_Chuc_Nang", 200);
            g_dicCol_Size.Add("Ten_Cot_Frozen", 300);
            g_dicCol_Size.Add("Ghi_Chu", 400);

        }

        protected override void Load_Data()
        {
            CSys_Frozen_Column_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_513_FC_sp_sel_List_By_Created(dtmFrom.Value, dtmTo.Value);

            Format_Grid(m_arrData);

        }

        //Hàm đc gọi khi ấn vào nút thêm hoặc edit
        protected override void Open_Edit_Data(long p_lngAuto_ID)
        {
            FSys_002_03_Frozen_Column_Edit v_objEdit = new();
            v_objEdit.g_lngAuto_ID = p_lngAuto_ID;
            v_objEdit.User_Name = User_Name;
            v_objEdit.Function_Code = Function_Code;
            v_objEdit.ShowDialog();
        }

        //Hàm đc gọi khi ấn vào nút view
        protected override void Open_View_Data(long p_lngAuto_ID)
        {
            FSys_002_02_Frozen_Column_View v_objView = new();
            v_objView.g_lngAuto_ID = p_lngAuto_ID;
            v_objView.Show();
        }
        protected override void Delete_Data(long p_lngAuto_ID)
        {
            CSys_Frozen_Column_Controller v_objCtrlData = new();
            v_objCtrlData.FQ_513_FC_sp_del_Delete_By_ID(p_lngAuto_ID, User_Name, Function_Code);
            CCache_Frozen_Column.Delete_Data(p_lngAuto_ID);
        }

        protected override void Import_Excel_Entry(CExcel_Controller v_objCtrlExcel, ref int p_iCount_Success, ref int p_iCount_Error)
        {
            CSys_Frozen_Column_Controller v_objCtrData = new();

            StringBuilder v_sbError = new StringBuilder();
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;

            try
            {
                DataTable v_dt = v_objCtrlExcel.List_Range_Value_To_End(0, "A2", "G");

                // Loại mấy dòng trống
                for (int v_i = v_dt.Rows.Count - 1; v_i >= 0; v_i--)
                    if (v_dt.Rows[v_i][0].ToString().Trim() == "")
                        v_dt.Rows.RemoveAt(v_i);

                int v_iCount = 1;

                foreach (DataRow v_row in v_dt.Rows)
                {
                    v_iCount++;

                    //tao ket noi transaction
                    v_conn = CSqlHelper.CreateConnection(CConfig.Quan_Ly_Kho_Data_Conn_String);
                    v_conn.Open();
                    v_trans = v_conn.BeginTransaction();

                    try
                    {
                        CSys_Frozen_Column v_objData = new CSys_Frozen_Column();
                        v_objData.Ma_Chuc_Nang = CUtility.Convert_To_String(v_row[0]);
                        v_objData.Ten_Cot_Frozen = CUtility.Convert_To_String(v_row[1]);
                        v_objData.Ghi_Chu = CUtility.Convert_To_String(v_row[2]);
                        v_objData.Last_Updated_By = User_Name;
                        v_objData.Last_Updated_By_Function = Function_Code;

                        v_objData.Auto_ID = v_objCtrData.FQ_513_FC_sp_ins_Insert(v_conn, v_trans, v_objData);
                        p_iCount_Success++;
                        v_trans.Commit();

                        CCache_Frozen_Column.Add_Data(v_objData);
                    }

                    catch (Exception ex)
                    {
                        v_sbError.AppendLine("Dòng" + " " + v_iCount.ToString() + " " + "có lỗi" + ": " + ex.Message);

                        if (v_trans != null)
                            v_trans.Rollback();
                    }

                    finally
                    {
                        if (v_trans != null)
                            v_trans.Dispose();

                        if (v_conn != null)
                            v_conn.Close();
                    }
                }

                p_iCount_Error = v_dt.Rows.Count - p_iCount_Success;
                if (v_sbError.ToString() != "")
                    throw new(v_sbError.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override void Tim_Kiem_By_Key()
        {
            string v_strKey_Word = txtNoi_Dung_Tim_Kiem.Text;
            List<CSys_Frozen_Column> v_arrData_Temp = m_arrData.ToList();

            v_strKey_Word = v_strKey_Word.ToLower().Trim();

            if (v_strKey_Word == CConst.STR_VALUE_NULL)
            {
                grdData.DataSource = v_arrData_Temp;
            }
            else
            {
                v_arrData_Temp = v_arrData_Temp.Where(it => it.Ma_Chuc_Nang.ToLower().Contains(v_strKey_Word)
                                                         || it.Ten_Cot_Frozen.ToLower().Contains(v_strKey_Word)
                                                         || it.Ghi_Chu.ToLower().Contains(v_strKey_Word)

             ).ToList();
            }
            grdData.DataSource = v_arrData_Temp;
        }


    }
}
