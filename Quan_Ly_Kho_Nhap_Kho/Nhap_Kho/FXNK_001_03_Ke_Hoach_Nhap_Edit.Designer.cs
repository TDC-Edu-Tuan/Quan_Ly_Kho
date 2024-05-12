using DevExpress.XtraMap.Native;

namespace Quan_Ly_Kho_DM
{
    partial class FXNK_001_03_Ke_Hoach_Nhap_Edit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            grdData = new DataGridView();
            btnAdd_Detail = new Button();
            dtmNgay_Nhap_kho = new DateTimePicker();
            cbbNCC = new ComboBox();
            label7 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            label3 = new Label();
            btnSave = new Button();
            txtSo_Phieu_Nhap = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(grdData);
            panel1.Controls.Add(btnAdd_Detail);
            panel1.Controls.Add(dtmNgay_Nhap_kho);
            panel1.Controls.Add(cbbNCC);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtSo_Phieu_Nhap);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 515);
            panel1.TabIndex = 0;
            // 
            // grdData
            // 
            grdData.AllowUserToAddRows = false;
            grdData.AllowUserToDeleteRows = false;
            grdData.AllowUserToResizeRows = false;
            grdData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdData.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdData.DefaultCellStyle = dataGridViewCellStyle2;
            grdData.GridColor = SystemColors.ButtonFace;
            grdData.Location = new Point(12, 189);
            grdData.Name = "grdData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdData.RowHeadersVisible = false;
            grdData.RowHeadersWidth = 51;
            grdData.RowTemplate.Height = 29;
            grdData.Size = new Size(1124, 245);
            grdData.TabIndex = 19;
            // 
            // btnAdd_Detail
            // 
            btnAdd_Detail.Location = new Point(12, 122);
            btnAdd_Detail.Name = "btnAdd_Detail";
            btnAdd_Detail.Size = new Size(94, 43);
            btnAdd_Detail.TabIndex = 18;
            btnAdd_Detail.Text = "Thêm";
            btnAdd_Detail.UseVisualStyleBackColor = true;
            btnAdd_Detail.Click += Open_Edit;
            // 
            // dtmNgay_Nhap_kho
            // 
            dtmNgay_Nhap_kho.Format = DateTimePickerFormat.Short;
            dtmNgay_Nhap_kho.Location = new Point(161, 66);
            dtmNgay_Nhap_kho.Name = "dtmNgay_Nhap_kho";
            dtmNgay_Nhap_kho.Size = new Size(156, 23);
            dtmNgay_Nhap_kho.TabIndex = 16;
            // 
            // cbbNCC
            // 
            cbbNCC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbNCC.FormattingEnabled = true;
            cbbNCC.Location = new Point(551, 32);
            cbbNCC.Name = "cbbNCC";
            cbbNCC.Size = new Size(156, 24);
            cbbNCC.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(402, 35);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 11;
            label7.Text = "NCC";
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtGhi_Chu.Location = new Point(965, 35);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(167, 22);
            txtGhi_Chu.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(816, 35);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 9;
            label5.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày Nhập Kho";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(1042, 463);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
            // 
            // txtSo_Phieu_Nhap
            // 
            txtSo_Phieu_Nhap.Location = new Point(161, 29);
            txtSo_Phieu_Nhap.Name = "txtSo_Phieu_Nhap";
            txtSo_Phieu_Nhap.Properties.NullValuePrompt = "Để trống = tự sinh";
            txtSo_Phieu_Nhap.Size = new Size(156, 22);
            txtSo_Phieu_Nhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Số Phiếu Nhập";
            // 
            // FXNK_001_03_Ke_Hoach_Nhap_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 515);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FXNK_001_03_Ke_Hoach_Nhap_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtSo_Phieu_Nhap;
        private Label label1;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label5;
        private Label label7;
        private Button btnAdd_Detail;
        private DateTimePicker dtmNgay_Nhap_kho;
        private ComboBox cbbNCC;
        private DataGridView grdData;
    }
}