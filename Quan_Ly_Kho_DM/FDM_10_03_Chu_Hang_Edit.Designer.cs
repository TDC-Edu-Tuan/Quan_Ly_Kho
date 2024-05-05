namespace Quan_Ly_Kho_DM
{
    partial class FDM_10_03_Chu_Hang_Edit
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
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            txtSDT = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            txtTen_Chu_Hang = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            btnSave = new Button();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtMa_Chu_Hang = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSDT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTen_Chu_Hang.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_Chu_Hang.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTen_Chu_Hang);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMa_Chu_Hang);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 240);
            panel1.TabIndex = 0;
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(161, 141);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(156, 22);
            txtGhi_Chu.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 9;
            label5.Text = "Ghi chú";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(161, 113);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(156, 22);
            txtSDT.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "SĐT";
            // 
            // txtTen_Chu_Hang
            // 
            txtTen_Chu_Hang.Location = new Point(161, 57);
            txtTen_Chu_Hang.Name = "txtTen_Chu_Hang";
            txtTen_Chu_Hang.Size = new Size(156, 22);
            txtTen_Chu_Hang.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên CH";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(219, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 22);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtMa_Chu_Hang
            // 
            txtMa_Chu_Hang.Location = new Point(161, 29);
            txtMa_Chu_Hang.Name = "txtMa_Chu_Hang";
            txtMa_Chu_Hang.Size = new Size(156, 22);
            txtMa_Chu_Hang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã CH";
            // 
            // FDM_10_03_Chu_Hang_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 240);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FDM_10_03_Chu_Hang_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSDT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTen_Chu_Hang.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_Chu_Hang.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtMa_Chu_Hang;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtTen_Chu_Hang;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label5;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private Label label4;
    }
}