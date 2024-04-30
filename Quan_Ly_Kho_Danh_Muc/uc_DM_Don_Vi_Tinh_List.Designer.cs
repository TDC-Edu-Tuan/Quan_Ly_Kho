using Quan_Ly_Kho_Common;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Danh_Muc
{
    partial class uc_DM_Don_Vi_Tinh_List
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
            panel1 = new Panel();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(grdData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1821, 495);
            panel1.TabIndex = 0;
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
            panel2.Size = new Size(1821, 95);
            panel2.TabIndex = 2;
            // 
            // cbbChu_Hang
            // 
            cbbChu_Hang.FormattingEnabled = true;
            cbbChu_Hang.Location = new Point(1020, 34);
            cbbChu_Hang.Name = "cbbChu_Hang";
            cbbChu_Hang.Size = new Size(200, 28);
            cbbChu_Hang.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(940, 37);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 37);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
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
            label4.Location = new Point(249, 37);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
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
            label3.Location = new Point(21, 37);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 0;
            label3.Text = "Từ";
            // 
            // grdData
            // 
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Dock = DockStyle.Fill;
            grdData.Location = new Point(0, 0);
            grdData.Name = "grdData";
            grdData.RowHeadersWidth = 51;
            grdData.RowTemplate.Height = 29;
            grdData.Size = new Size(1821, 495);
            grdData.TabIndex = 1;
            grdData.CellContentClick += grdData_CellContentClick;
         
            // 
            // uc_DM_Don_Vi_Tinh_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "uc_DM_Don_Vi_Tinh_List";
            Size = new Size(1821, 495);
            Load += Load_Form;
            panel1.ResumeLayout(false);
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
    }
}
