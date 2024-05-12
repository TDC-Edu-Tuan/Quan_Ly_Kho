namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    partial class FXNK_001_03_Update_Info_Phieu_Nhap_Edit
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
            panel1 = new Panel();
            btnLuu = new Button();
            label4 = new Label();
            dtmNgay_Nhap_Kho = new DateTimePicker();
            cbbNCC = new ComboBox();
            label3 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtSo_Phieu_Nhap = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtmNgay_Nhap_Kho);
            panel1.Controls.Add(cbbNCC);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSo_Phieu_Nhap);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 248);
            panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(290, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 37);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += Save_Data;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 101);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày Nhập Kho";
            // 
            // dtmNgay_Nhap_Kho
            // 
            dtmNgay_Nhap_Kho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtmNgay_Nhap_Kho.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtmNgay_Nhap_Kho.Format = DateTimePickerFormat.Short;
            dtmNgay_Nhap_Kho.Location = new Point(198, 95);
            dtmNgay_Nhap_Kho.Name = "dtmNgay_Nhap_Kho";
            dtmNgay_Nhap_Kho.Size = new Size(186, 28);
            dtmNgay_Nhap_Kho.TabIndex = 6;
            // 
            // cbbNCC
            // 
            cbbNCC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbNCC.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNCC.FormattingEnabled = true;
            cbbNCC.Location = new Point(198, 54);
            cbbNCC.Name = "cbbNCC";
            cbbNCC.Size = new Size(186, 28);
            cbbNCC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "NCC";
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtGhi_Chu.Location = new Point(198, 135);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Properties.Appearance.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhi_Chu.Properties.Appearance.Options.UseFont = true;
            txtGhi_Chu.Size = new Size(186, 26);
            txtGhi_Chu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 138);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Ghi Chú";
            // 
            // txtSo_Phieu_Nhap
            // 
            txtSo_Phieu_Nhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSo_Phieu_Nhap.Location = new Point(198, 17);
            txtSo_Phieu_Nhap.Name = "txtSo_Phieu_Nhap";
            txtSo_Phieu_Nhap.Properties.Appearance.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSo_Phieu_Nhap.Properties.Appearance.Options.UseFont = true;
            txtSo_Phieu_Nhap.Size = new Size(186, 26);
            txtSo_Phieu_Nhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Số Phiếu Nhâp";
            // 
            // FXNK_001_03_Update_Info_Phieu_Nhap_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 248);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FXNK_001_03_Update_Info_Phieu_Nhap_Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hiệu Chỉnh";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLuu;
        private Label label4;
        private DateTimePicker dtmNgay_Nhap_Kho;
        private ComboBox cbbNCC;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtSo_Phieu_Nhap;
        private Label label1;
    }
}