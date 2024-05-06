using DevExpress.XtraMap.Native;

namespace Quan_Ly_Kho_DM
{
    partial class FSys_001_03_Thanh_Vien_Edit
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
            cbbNhom_Thanh_Vien = new ComboBox();
            radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            label6 = new Label();
            txtHo_Ten = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            label5 = new Label();
            txtSDT = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            txtMat_Khau = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            btnSave = new Button();
            label2 = new Label();
            txtMa_Dang_Nhap = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radioGroup1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHo_Ten.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSDT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMat_Khau.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_Dang_Nhap.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbNhom_Thanh_Vien);
            panel1.Controls.Add(radioGroup1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtHo_Ten);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMat_Khau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMa_Dang_Nhap);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 200);
            panel1.TabIndex = 0;
            // 
            // cbbNhom_Thanh_Vien
            // 
            cbbNhom_Thanh_Vien.FormattingEnabled = true;
            cbbNhom_Thanh_Vien.Location = new Point(562, 87);
            cbbNhom_Thanh_Vien.Name = "cbbNhom_Thanh_Vien";
            cbbNhom_Thanh_Vien.Size = new Size(151, 24);
            cbbNhom_Thanh_Vien.TabIndex = 16;
            // 
            // radioGroup1
            // 
            radioGroup1.Location = new Point(161, 85);
            radioGroup1.Name = "radioGroup1";
            radioGroup1.Properties.Columns = 2;
            radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem("Nam", "Nam"), new DevExpress.XtraEditors.Controls.RadioGroupItem("Nữ", "Nữ", true, "Nữ") });
            radioGroup1.Size = new Size(156, 31);
            radioGroup1.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(557, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 22);
            txtEmail.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(408, 60);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtHo_Ten
            // 
            txtHo_Ten.Location = new Point(557, 32);
            txtHo_Ten.Name = "txtHo_Ten";
            txtHo_Ten.Size = new Size(156, 22);
            txtHo_Ten.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(408, 32);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 11;
            label7.Text = "Họ Tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(408, 88);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 9;
            label5.Text = "Nhóm Thành Viên";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(161, 122);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(156, 22);
            txtSDT.TabIndex = 8;
            txtSDT.EditValueChanged += txtSDT_EditValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "SĐT";
            // 
            // txtMat_Khau
            // 
            txtMat_Khau.Location = new Point(161, 57);
            txtMat_Khau.Name = "txtMat_Khau";
            txtMat_Khau.Size = new Size(156, 22);
            txtMat_Khau.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Mật Khẩu";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(619, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Giới tính";
            // 
            // txtMa_Dang_Nhap
            // 
            txtMa_Dang_Nhap.Location = new Point(161, 29);
            txtMa_Dang_Nhap.Name = "txtMa_Dang_Nhap";
            txtMa_Dang_Nhap.Size = new Size(156, 22);
            txtMa_Dang_Nhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Đăng Nhập";
            // 
            // FSys_001_03_Thanh_Vien_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 200);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FSys_001_03_Thanh_Vien_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radioGroup1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHo_Ten.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSDT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMat_Khau.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_Dang_Nhap.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtMa_Dang_Nhap;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtMat_Khau;
        private Label label3;
        private Label label5;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private Label label6;
        private DevExpress.XtraEditors.TextEdit txtHo_Ten;
        private Label label7;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private Label label2;
        private ComboBox cbbNhom_Thanh_Vien;
    }
}