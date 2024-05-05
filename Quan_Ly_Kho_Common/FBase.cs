using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using OfficeOpenXml;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Common
{
    public partial class FBase : XtraForm
    {
        #region Các biến control system
        private bool g_bIs_First_Load = CConst.IS_VALUE_NULL;

        public string Function_Code { get; set; } = CConst.STR_VALUE_NULL;
        public string User_Name { get; set; } = CConst.STR_VALUE_NULL;

        public long g_lngAuto_ID { get; set; } = CConst.INT_VALUE_NULL;
        public long g_lngKho_ID { get; set; } = CConst.INT_VALUE_NULL;
        public long g_lngChu_Hang_ID { get; set; } = CConst.INT_VALUE_NULL;

        public List<CDM_Kho_User> g_arrKho_Users { get; set; } = new();
        public List<CDM_Chu_Hang_User> g_arrChu_Hang_Users { get; set; } = new();

        protected DataGridView g_grdData { get; set; } = (DataGridView)CConst.OBJ_VALUE_NULL;

        protected List<string> g_arrCol_Hiden = new();

        protected Dictionary<string, int> g_dicCol_Size = new();
        protected Dictionary<string, string> g_dicCol_Name = new();

        protected bool g_bIs_Deleted_Permission = CConst.IS_VALUE_NULL;
        protected bool g_bIs_View_Permission = CConst.IS_VALUE_NULL;
        protected bool g_bIs_Update { get; set; } = CConst.IS_VALUE_NULL;

        #endregion

        #region Nhóm event

        /// <summary>
        /// Hàm nút tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Tim_Kiem(object sender, EventArgs e)
        {
            g_grdData.Columns.Clear();
            Load_Data();
        }

        /// <summary>
        /// Hàm gọi khi form đc load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Load_Form(object sender, EventArgs e)
        {
            Start_Loading();//
            DateTime v_dtmStart = DateTime.Now;

            try
            {
                g_lngChu_Hang_ID = CSystem.Chu_Hang_ID;
                g_lngKho_ID = CSystem.Kho_ID;

                if (g_bIs_First_Load == false)
                {
                    if(g_grdData == null)
                    {
                        g_grdData = new();
                    }
                    Load_Init();
                    g_grdData.CellContentClick += Cell_Content_Click;

                    g_bIs_First_Load = true;
                }
                g_grdData.Columns.Clear();

                Load_Data();

                Tim_Kiem_TextChanged(sender, e);

                End_Loading();//
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Load Form", Function_Code + ": Load Form", "Load: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);

                End_Loading();//

                FCommonFunction.Show_Message_Box("Lỗi", ex.Message, (int)EMessage_Type.Error);
            }

        }

        /// <summary>
        /// Hàm cho nút xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Delete_Data_Entry(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;

            try
            {
                Delete_Data(g_lngAuto_ID);
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Delete Data", Function_Code + ": Delete_Data", "Xóa data by: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }

        /// <summary>
        /// Hàm sự kiện lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Save_Data(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;

            Start_Loading();
            try
            {

                if (g_bIs_Update == true)
                    Update_Data();
                else
                    Add_Data();

                Closed_Form();
                End_Loading();
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Save Data", Function_Code + ": Save_Data", "Lưu: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);
                End_Loading();

                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }

        /// <summary>
        /// Mở form edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Open_Edit(object sender, EventArgs e)
        {
            Open_Edit_Data();
            Load_Form(sender, e);
        }

        /// <summary>
        /// Hàm sự kiện khi mở form view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Open_View(object sender, EventArgs e)
        {
            Open_View_Data(g_lngAuto_ID);
        }

        /// <summary>
        /// Hàm sự kiện import excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Import_Excel(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;
            OpenFileDialog v_objFile_Dialog = new();

            int v_iCount_Success = CConst.INT_VALUE_NULL;
            int v_iCount_Error = CConst.INT_VALUE_NULL;

            try
            {
                //Type file focus
                v_objFile_Dialog.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";

                //Title
                v_objFile_Dialog.Title = "Select an Excel File";

                //Hộp thoại chọn file
                if (v_objFile_Dialog.ShowDialog() == DialogResult.OK)
                {
                    Start_Loading();//

                    string v_strFile_Path = v_objFile_Dialog.FileName;

                    FileInfo v_info = new(v_strFile_Path);
                    //Kiêm tra đuôi file
                    if (!CExcel_Controller.Check_Excel_File_Type(v_info.Extension))
                        throw new Exception("File không đúng định dạng.");

                    if (v_info.IsReadOnly == true)
                        throw new Exception("File này không thể đọc vui lòng kiểm tra lại");


                    Import_Excel_Entry(v_info, ref v_iCount_Success, ref v_iCount_Error);
                    if (v_iCount_Error != CConst.INT_VALUE_NULL)
                        throw new Exception($"Import excel không thành công với {v_iCount_Error} dòng lỗi");


                    FCommonFunction.Show_Message_Box("Thông báo", $"Import excel: {v_iCount_Success} dòng thành công ", (int)EMessage_Type.Success);

                    End_Loading();//
                }
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Import_Excel", Function_Code + ": Import_Excel", "Import excel by: " + User_Name, ex.Message + "\n" + ex.StackTrace, (DateTime.Now - v_dtmStart).TotalSeconds);

                End_Loading();//

                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
            finally
            {
                v_objFile_Dialog.Dispose();
            }
        }

        /// <summary>
        /// Hàm export excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Export_Excel(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;
            Start_Loading();
            try
            {
                if (g_grdData == null)
                {
                    throw new Exception("Không tìm thấy lưới dữ liệu để phục vụ export excel vui lòng liên hệ nhà phát triển để xử lý");
                }

                Export_Excel_Entry(g_grdData, Function_Code.Replace("_Item", "") + ".xlsx");
                FCommonFunction.Show_Message_Box("Thông báo", "Export thành công", (int)EMessage_Type.Success);

                End_Loading();
            }
            catch (Exception ex)
            {
                CLogger.Save_Trace_Error_Log("Export Excel", Function_Code + ": Xuất Excel", "Export: " + User_Name, ex.Message, (DateTime.Now - v_dtmStart).TotalSeconds);

                End_Loading();

                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }


        /// <summary>
        /// Hàm tìm kiếm theo keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            Tim_Kiem_By_Key();
        }
        #endregion


        #region Nhóm kế thừa

        /// <summary>
        /// Hàm load data
        /// </summary>
        protected virtual void Load_Data()
        {

        }

        /// <summary>
        /// Hàm load data lần đầu
        /// </summary>
        protected virtual void Load_Init()
        {

        }

        /// <summary>
        /// Hàm xử lý dữ liệu khi add
        /// </summary>
        protected virtual void Add_Data()
        {

        }

        /// <summary>
        /// Hàm xử lý dữ liệu  khi update
        /// </summary>
        protected virtual void Update_Data()
        {

        }

        /// <summary>
        /// Hàm xử lý dữ liệu khi xóa
        /// </summary>
        protected virtual void Delete_Data(long p_lngAuto_ID)
        {

        }

        /// <summary>
        /// Hàm sự kiện mở form edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void Open_Edit_Data()
        {

        }

        /// <summary>
        /// Hàm xử lý khi mở form view
        /// </summary>
        /// <param name="p_lngAuto_ID"></param>
        protected void Open_View_Data(long p_lngAuto_ID)
        {

        }

        /// <summary>
        /// Hàm xử lý data import excel
        /// </summary>
        /// <param name="p_objFile"></param>
        /// <param name="p_iCount_Success"></param>
        /// <param name="p_iCount_Error"></param>
        protected virtual void Import_Excel_Entry(FileInfo p_objFile, ref int p_iCount_Success, ref int p_iCount_Error)
        {

        }

        /// <summary>
        /// Dùng để format lại grid view
        /// </summary>
        protected void Format_Grid()
        {
            //Load CSystem button
            Load_System_Button();

            // Tính toán lại chiều dài các cột và thiết lập kiểu cho từng cột
            foreach (DataGridViewColumn v_item in g_grdData.Columns)
            {
                if (v_item.Name != "btnDeleted" && v_item.Name != "btnView")
                    // Gọi phương thức Col_Custom để thiết lập kiểu cho cột
                    Col_Custom(v_item);
            }



            // Áp dụng định dạng cho ô dữ liệu
            Apply_Cell_Formatting();
        }

        /// <summary>
        /// Ẩn hết các cột mặc định
        /// </summary>
        protected void Disable_Default_Col()
        {
            g_arrCol_Hiden.Add("Auto_ID");
            g_arrCol_Hiden.Add("deleted");
            g_arrCol_Hiden.Add("Created");
            g_arrCol_Hiden.Add("Created_By");
            g_arrCol_Hiden.Add("Created_By_Function");
            g_arrCol_Hiden.Add("Last_Updated");
            g_arrCol_Hiden.Add("Last_Updated_By");
            g_arrCol_Hiden.Add("Last_Updated_By_Function");
        }

        /// <summary>
        /// Thêm 1 nút vào grid
        /// </summary>
        /// <param name="p_strName"></param>
        /// <param name="p_Type"></param>
        /// <param name="p_intIndex"></param>
        /// <param name="p_icon"></param>
        protected void Add_Button_Column(string p_strName, DataGridViewColumn p_Type, int p_intIndex, Image p_icon = null)
        {
            DataGridViewColumn v_colRes = new();
            if (p_Type.GetType() == typeof(DataGridViewImageColumn))
            {
                DataGridViewImageColumn v_ImgCol = new();
                v_ImgCol.Resizable = DataGridViewTriState.False;
                v_ImgCol.Name = p_strName;
                v_ImgCol.Width = 100;
                v_ImgCol.Image = p_icon;
                v_ImgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // Zoom ảnh trong ô
                v_colRes = v_ImgCol;
            }
            else if (p_Type.GetType() == typeof(DataGridViewCheckBoxColumn))
            {
                DataGridViewCheckBoxColumn v_checkBoxCol = new();
                v_checkBoxCol.Resizable = DataGridViewTriState.False;
                v_checkBoxCol.Name = p_strName;
                v_checkBoxCol.Width = 100;
                v_colRes = v_checkBoxCol;
            }

            g_grdData.Columns.Insert(p_intIndex, v_colRes);
        }

        protected virtual void Tim_Kiem_By_Key()
        {

        }

        protected void Start_Loading()
        {
            if (g_bIs_First_Load == false)
            {
                InitializeComponent();
            }
            Loading_Control.ShowWaitForm();
        }

        protected void End_Loading()
        {
            Loading_Control.CloseWaitForm();
        }

        protected virtual void Closed_Form()
        {

        }

        protected void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Ngăn chặn sự kiện KeyPress được xử lý
        }

        #endregion

        #region Nhóm private
        private void Apply_Cell_Formatting()
        {
            // Thiết lập định dạng cho ô dữ liệu
            g_grdData.CellFormatting += (sender, e) =>
            {
                var v_objDataGridView = (DataGridView)sender;
                var v_objColumn = v_objDataGridView.Columns[e.ColumnIndex];

                // Kiểm tra xem cột có phải là kiểu số không
                if (CUtility.Is_Numeric_Type(v_objColumn.ValueType) && e.RowIndex >= 0)
                {
                    // Thiết lập căn chỉnh dữ liệu trong ô
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Thiết lập màu nền và màu chữ
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Red;
                }
            };
        }

        private void Load_System_Button()
        {
            string v_strDeleted_Icon_Path = CUtility.Find_File_In_Solution("settings.png");
            string v_strView_Icon_Path = CUtility.Find_File_In_Solution("view.png");

            // Load hình ảnh từ tệp và tạo đối tượng Image
            Image v_objDeleted_Icon = Image.FromFile(v_strDeleted_Icon_Path);
            Image v_objView_Icon = Image.FromFile(v_strView_Icon_Path);

            //Thêm check box, view, deleted
            DataGridViewImageColumn v_objView_Col = new();
            DataGridViewImageColumn v_objDel_Col = new();
            DataGridViewCheckBoxColumn v_objCheck_Col = new();

            Add_Button_Column("btnView", v_objView_Col, 1, v_objView_Icon);
            Add_Button_Column("btnDeleted", v_objDel_Col, 2, v_objDeleted_Icon);
            Add_Button_Column("btnCheck", v_objCheck_Col, 0);

            g_grdData.Columns["btnDeleted"].Visible = g_bIs_Deleted_Permission;
            g_grdData.Columns["btnView"].Visible = g_bIs_Deleted_Permission;
            g_grdData.Columns["btnDeleted"].HeaderText = "Xóa";
            g_grdData.Columns["btnView"].HeaderText = "View";
            g_grdData.Columns["btnCheck"].HeaderText = "";

            Col_Custom(g_grdData.Columns["btnDeleted"]);
            Col_Custom(g_grdData.Columns["btnView"]);
            Col_Custom(g_grdData.Columns["btnCheck"]);


        }

        /// <summary>
        /// Hàm xử lý dữ liệu export
        /// </summary>
        /// <param name="p_dgv"></param>
        /// <param name="p_strExcel"></param>
        /// <exception cref="Exception"></exception>
        private void Export_Excel_Entry(DataGridView p_dgv, string p_strExcel)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage v_Package = new())
            {
                // Tạo một worksheet mới
                ExcelWorksheet v_Worksheet = v_Package.Workbook.Worksheets.Add("Sheet1");

                //Không import 3 cột chức năng
                p_dgv.Columns["btnCheck"].Visible = false;
                p_dgv.Columns["btnDeleted"].Visible = false;
                p_dgv.Columns["btnView"].Visible = false;

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

                //Hiện lại 3 cột đó trên grid
                p_dgv.Columns["btnCheck"].Visible = false;
                p_dgv.Columns["btnDeleted"].Visible = false;
                p_dgv.Columns["btnView"].Visible = false;
            }
        }

        private void Col_Custom(DataGridViewColumn p_col)
        {
            // Căn giữa header của cột
            p_col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Kiểm tra col có trong danh sách cột ẩn không
            if (g_arrCol_Hiden.Contains(p_col.HeaderText))
            {
                p_col.Visible = false; // Ẩn cột đó đi
            }

            // Kiểm tra cột đã ẩn
            if (p_col.Visible)
            {
                // Kiểm tra col có khai báo chỉnh độ rộng cột không 
                if (g_dicCol_Size.ContainsKey(p_col.Name))
                {
                    p_col.Width = g_dicCol_Size[p_col.Name]; // Set độ rộng bằng khai báo
                }

                // Kiểm tra col có trong danh sách thay đổi tên cột không 
                if (g_dicCol_Name.ContainsKey(p_col.Name))
                {
                    p_col.HeaderText = g_dicCol_Name[p_col.Name];
                }
            }

            // Ngăn người dùng điều chỉnh độ rộng của cột
            p_col.Resizable = DataGridViewTriState.False;
        }

        private void Cell_Content_Click(object? sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được click 
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy giá trị của cột Auto_ID từ hàng được click
                g_lngAuto_ID = CUtility.Convert_To_Int64(g_grdData.Rows[e.RowIndex].Cells["Auto_ID"].Value);

                string v_strCol_Name = g_grdData.Columns[e.ColumnIndex].Name;

                switch (v_strCol_Name)
                {
                    case "btnView":
                        Open_View(sender, e);
                        break;
                    case "btnDeleted":
                        Open_Edit(sender, e);
                        break;
                }
            }
        }


         #endregion
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private DevExpress.XtraSplashScreen.SplashScreenManager Loading_Control;

        private void InitializeComponent()
        {
            Loading_Control = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(FLoading), true, true);
            SuspendLayout();
            // 
            // Loading_Control
            // 
            Loading_Control.ClosingDelay = 500;
            // 
            // UCBase
            // 
            Name = "UCBase";
            ResumeLayout(false);
        }
    }
}