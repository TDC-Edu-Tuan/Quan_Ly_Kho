
namespace Quan_Ly_Kho_DM
{
    partial class FXNK_001_01_Ke_Hoach_Nhap_List
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnNhap_Hang = new Button();
            btnIn = new Button();
            label1 = new Label();
            txtNoi_Dung_Tim_Kiem = new TextBox();
            panel2 = new Panel();
            cbbChu_Hang = new ComboBox();
            label6 = new Label();
            cbbKho = new ComboBox();
            label5 = new Label();
            btnImport = new Button();
            btnExport = new Button();
            btnAdd_Data = new Button();
            btnTim_Kiem = new Button();
            dtmTo = new DateTimePicker();
            label4 = new Label();
            dtmFrom = new DateTimePicker();
            label3 = new Label();
            grdData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNhap_Hang);
            panel1.Controls.Add(btnIn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNoi_Dung_Tim_Kiem);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(grdData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1821, 495);
            panel1.TabIndex = 0;
            // 
            // btnNhap_Hang
            // 
            btnNhap_Hang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhap_Hang.Location = new Point(1314, 173);
            btnNhap_Hang.Name = "btnNhap_Hang";
            btnNhap_Hang.Size = new Size(117, 38);
            btnNhap_Hang.TabIndex = 16;
            btnNhap_Hang.Text = "Nhập Hàng";
            btnNhap_Hang.UseVisualStyleBackColor = true;
            btnNhap_Hang.Click += btnNhap_Hang_Click;
            // 
            // btnIn
            // 
            btnIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIn.Location = new Point(1492, 173);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(117, 38);
            btnIn.TabIndex = 12;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 150);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 15;
            label1.Text = "Nội dung tìm kiếm";
            // 
            // txtNoi_Dung_Tim_Kiem
            // 
            txtNoi_Dung_Tim_Kiem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoi_Dung_Tim_Kiem.Location = new Point(185, 173);
            txtNoi_Dung_Tim_Kiem.Name = "txtNoi_Dung_Tim_Kiem";
            txtNoi_Dung_Tim_Kiem.Size = new Size(362, 27);
            txtNoi_Dung_Tim_Kiem.TabIndex = 14;
            txtNoi_Dung_Tim_Kiem.TextChanged += Tim_Kiem_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbChu_Hang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbbKho);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd_Data);
            panel2.Controls.Add(btnTim_Kiem);
            panel2.Controls.Add(dtmTo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtmFrom);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1821, 125);
            panel2.TabIndex = 2;
            // 
            // cbbChu_Hang
            // 
            cbbChu_Hang.FormattingEnabled = true;
            cbbChu_Hang.Location = new Point(1038, 33);
            cbbChu_Hang.Name = "cbbChu_Hang";
            cbbChu_Hang.Size = new Size(200, 28);
            cbbChu_Hang.TabIndex = 11;
            cbbChu_Hang.SelectedIndexChanged += Combobox_Selected_Index_Changed;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(940, 37);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 10;
            label6.Text = "Chủ Hàng";
            // 
            // cbbKho
            // 
            cbbKho.FormattingEnabled = true;
            cbbKho.Location = new Point(698, 34);
            cbbKho.Name = "cbbKho";
            cbbKho.Size = new Size(200, 28);
            cbbKho.TabIndex = 9;
            cbbKho.SelectedIndexChanged += Combobox_Selected_Index_Changed;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(642, 37);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 8;
            label5.Text = "Kho";
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Location = new Point(1515, 24);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 46);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += Import_Excel;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Location = new Point(1677, 24);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 46);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += Export_Excel;
            // 
            // btnAdd_Data
            // 
            btnAdd_Data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd_Data.Location = new Point(1349, 24);
            btnAdd_Data.Name = "btnAdd_Data";
            btnAdd_Data.Size = new Size(94, 46);
            btnAdd_Data.TabIndex = 5;
            btnAdd_Data.Text = "Thêm";
            btnAdd_Data.UseVisualStyleBackColor = true;
            btnAdd_Data.Click += Open_Edit;
            // 
            // btnTim_Kiem
            // 
            btnTim_Kiem.Location = new Point(483, 24);
            btnTim_Kiem.Name = "btnTim_Kiem";
            btnTim_Kiem.Size = new Size(94, 46);
            btnTim_Kiem.TabIndex = 4;
            btnTim_Kiem.Text = "Tìm kiếm";
            btnTim_Kiem.UseVisualStyleBackColor = true;
            btnTim_Kiem.Click += Tim_Kiem;
            // 
            // dtmTo
            // 
            dtmTo.Format = DateTimePickerFormat.Short;
            dtmTo.Location = new Point(305, 35);
            dtmTo.Name = "dtmTo";
            dtmTo.Size = new Size(134, 27);
            dtmTo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, 37);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 2;
            label4.Text = "Đến";
            // 
            // dtmFrom
            // 
            dtmFrom.Format = DateTimePickerFormat.Short;
            dtmFrom.Location = new Point(77, 35);
            dtmFrom.Name = "dtmFrom";
            dtmFrom.Size = new Size(134, 27);
            dtmFrom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 37);
            label3.Name = "label3";
            label3.Size = new Size(29, 19);
            label3.TabIndex = 0;
            label3.Text = "Từ";
            // 
            // grdData
            // 
            grdData.AllowUserToAddRows = false;
            grdData.AllowUserToDeleteRows = false;
            grdData.AllowUserToResizeRows = false;
            grdData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdData.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grdData.DefaultCellStyle = dataGridViewCellStyle5;
            grdData.GridColor = SystemColors.ButtonFace;
            grdData.Location = new Point(185, 229);
            grdData.Name = "grdData";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdData.RowHeadersVisible = false;
            grdData.RowHeadersWidth = 51;
            grdData.RowTemplate.Height = 29;
            grdData.Size = new Size(1424, 41);
            grdData.TabIndex = 1;
            grdData.CellContentClick += grdData_CellContentClick;
            // 
            // FXNK_001_01_Ke_Hoach_Nhap_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FXNK_001_01_Ke_Hoach_Nhap_List";
            Size = new Size(1821, 495);
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grdData;
        private Panel panel2;
        private Button btnAdd_Data;
        private Button btnTim_Kiem;
        private DateTimePicker dtmTo;
        private Label label4;
        private DateTimePicker dtmFrom;
        private Label label3;
        private Button btnImport;
        private Button btnExport;
        private ComboBox cbbChu_Hang;
        private Label label6;
        private ComboBox cbbKho;
        private Label label5;
        private Label label1;
        private TextBox txtNoi_Dung_Tim_Kiem;
        private Button btnIn;
        private Button btnNhap_Hang;
    }
}
