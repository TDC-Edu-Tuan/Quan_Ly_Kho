using DevExpress.XtraCharts.UI;
using OfficeOpenXml;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Danh_Muc
{
    public partial class UCBase : UserControl
    {
        protected DataGridView g_grdData { get; set; } = null;

        public UCBase()
        {
            InitializeComponent();
        }

        protected long g_lngAuto_ID { get; set; } = CConst.INT_VALUE_NULL;

        private bool g_bIs_First_Load = false;

        protected bool g_bIs_Update { get; set; } = false;

        public string Function_Code { get; set; } = "";

        public string User_Name { get; set; } = "";


        protected virtual void Tim_Kiem(object sender, EventArgs e)
        {
            Load_Form(sender, e);
        }

        protected virtual void Load_Data(object sender, EventArgs e)
        {

        }

        protected virtual void Load_Init()
        {

        }

        protected virtual void Load_Form(object sender, EventArgs e)
        {
            try
            {
                if (g_bIs_First_Load == false)
                {
                    InitializeComponent();

                    Load_Init();
                    g_bIs_First_Load = true;
                }

                Load_Data(sender, e);
            }
            catch (Exception ex)
            {
                FCommonFunction.Show_Message_Box("Lỗi", ex.Message, (int)EMessage_Type.Error);
            }

        }

        protected virtual void Add_Data(object sender, EventArgs e)
        {

        }

        protected virtual void Update_Data(object sender, EventArgs e)
        {

        }

        protected virtual void Delete_Data_Entry(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;

            try
            {

                Delete_Data();
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Delete Data", Function_Code + ": Delete_Data", "Xóa data by: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }

        protected virtual void Delete_Data()
        {

        }

        protected void Save_Data(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;

            try
            {

                if (g_bIs_Update == true)
                    Update_Data(sender, e);
                else
                    Add_Data(sender, e);

            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Save Data", Function_Code + ": Save_Data", "Lưu: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }

        protected void Import_Excel(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;
            OpenFileDialog v_objFile_Dialog = new OpenFileDialog();

            try
            {
                //Type file focus
                v_objFile_Dialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

                //Title
                v_objFile_Dialog.Title = "Select an Excel File";

                //Hộp thoại chọn file
                if (v_objFile_Dialog.ShowDialog() == DialogResult.OK)
                {
                    string v_strFile_Path = v_objFile_Dialog.FileName;


                    FileInfo v_info = new(v_strFile_Path);
                    //Kiêm tra đuôi file
                    if (!CExcel_Controller.Check_Excel_File_Type(v_info.Extension))
                        throw new Exception("File không đúng định dạng.");

                    if (v_info.IsReadOnly == true)
                        throw new Exception("File này không thể đọc vui lòng kiểm tra lại");


                    Import_Excel_Entry(v_info);
                }
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Import_Excel", Function_Code + ": Import_Excel", "Import excel by: " + User_Name, ex.Message + "\n" + ex.StackTrace, (DateTime.Now - v_dtmStart).TotalSeconds);
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
            finally
            {
                v_objFile_Dialog.Dispose();
            }
        }

        protected virtual void Import_Excel_Entry(FileInfo p_objFile)
        {

        }

        protected void Export_Excel(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;

            try
            {
                Export_Excel_Entry(g_grdData, Function_Code.Replace("_Item", "") + ".xlsx");
                FCommonFunction.Show_Message_Box("Thông báo", "Export thành công", (int)EMessage_Type.Success);

            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Export Excel", Function_Code + ": Xuất Excel", "Export: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }

        protected void Export_Excel_Entry(DataGridView p_dgv, string p_strExcel)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage v_Package = new())
            {
                // Tạo một worksheet mới
                ExcelWorksheet v_Worksheet = v_Package.Workbook.Worksheets.Add("Sheet1");

                // Thêm tiêu đề của cột vào worksheet
                int v_index = 1;
                for (int i = 1; i <= p_dgv.Columns.Count; i++)
                {
                    //Kiểm tra trạng thái
                    if (p_dgv.Columns[i - 1].Visible == true)
                    {
                        v_Worksheet.Cells[1, v_index].Value = p_dgv.Columns[i - 1].HeaderText;
                        v_index++;
                    }
                }

                // Thêm dữ liệu vào worksheet
                int v_col = 1;
                for (int i = 1; i <= p_dgv.Rows.Count; i++)
                {
                    v_col = 1;
                    for (int j = 1; j <= p_dgv.Columns.Count; j++)
                    {
                        if (p_dgv.Columns[j - 1].Visible == true)
                        {
                            v_Worksheet.Cells[i + 1, v_col].Value = p_dgv.Rows[i - 1].Cells[j - 1].Value;
                            v_col++;
                        }
                    }
                }



                FileInfo v_info = new(p_strExcel);
                //Kiêm tra đuôi file
                if (!CExcel_Controller.Check_Excel_File_Type(v_info.Extension))
                    throw new Exception("File không đúng định dạng.");

                // Nếu không có đường dẫn được cung cấp, sử dụng thư mục Downloads mặc định
                string v_strFile_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", p_strExcel);

                // Lưu file
                v_Package.SaveAs(new FileInfo(v_strFile_Path));
            }
        }


    }
}
