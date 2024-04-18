namespace Quan_Ly_Kho_Sys
{
    partial class FDang_Nhap
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
            pnlImage = new DevExpress.XtraEditors.PanelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            lblMessage = new Label();
            ckcRememberMe = new DevExpress.XtraEditors.CheckEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtUser_Name = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ckcRememberMe.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUser_Name.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlImage);
            panel1.Controls.Add(groupControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 326);
            panel1.TabIndex = 0;
            // 
            // pnlImage
            // 
            pnlImage.Location = new Point(43, 35);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(317, 266);
            pnlImage.TabIndex = 3;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnLogin);
            groupControl1.Controls.Add(lblMessage);
            groupControl1.Controls.Add(ckcRememberMe);
            groupControl1.Controls.Add(txtPassword);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(txtUser_Name);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(395, 35);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(419, 266);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Người Dùng";
            // 
            // btnLogin
            // 
            btnLogin.Appearance.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Location = new Point(158, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 25);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(27, 38);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(61, 17);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Message";
            // 
            // ckcRememberMe
            // 
            ckcRememberMe.Location = new Point(247, 188);
            ckcRememberMe.Name = "ckcRememberMe";
            ckcRememberMe.Properties.Caption = "Ghi nhớ đăng nhập";
            ckcRememberMe.Size = new Size(147, 24);
            ckcRememberMe.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 22);
            txtPassword.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(27, 154);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(66, 19);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Mật Khẩu";
            // 
            // txtUser_Name
            // 
            txtUser_Name.Location = new Point(158, 100);
            txtUser_Name.Name = "txtUser_Name";
            txtUser_Name.Size = new Size(236, 22);
            txtUser_Name.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(27, 103);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(100, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Mã Đăng Nhập";
            // 
            // FDang_Nhap
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 326);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FDang_Nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += FDang_Nhap_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ckcRememberMe.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUser_Name.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DevExpress.XtraEditors.PanelControl pnlImage;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUser_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private Label lblMessage;
        private DevExpress.XtraEditors.CheckEdit ckcRememberMe;
    }
}