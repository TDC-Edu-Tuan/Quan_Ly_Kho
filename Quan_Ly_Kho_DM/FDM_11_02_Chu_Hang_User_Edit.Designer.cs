namespace Quan_Ly_Kho_DM
{
    partial class FDM_11_02_Chu_Hang_User_Edit
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
            cbbCH_User = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbCH_User);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 126);
            panel1.TabIndex = 0;
            // 
            // cbbCH_User
            // 
            cbbCH_User.FormattingEnabled = true;
            cbbCH_User.Location = new Point(146, 32);
            cbbCH_User.Name = "cbbCH_User";
            cbbCH_User.Size = new Size(167, 24);
            cbbCH_User.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(219, 74);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
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
            // FDM_11_02_Chu_Hang_User_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 126);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FDM_11_02_Chu_Hang_User_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Label label1;
        private ComboBox cbbCH_User;
    }
}