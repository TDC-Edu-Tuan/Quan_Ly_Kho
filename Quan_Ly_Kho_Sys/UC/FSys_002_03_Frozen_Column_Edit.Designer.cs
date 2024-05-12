using DevExpress.XtraMap.Native;

namespace Quan_Ly_Kho_Sys
{
    partial class FSys_002_03_Frozen_Column_Edit
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
            btnSave = new Button();
            txtMa_Chuc_Nang = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            txtCol_Frozen = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMa_Chuc_Nang.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCol_Frozen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCol_Frozen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtMa_Chuc_Nang);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 214);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(223, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
            // 
            // txtMa_Chuc_Nang
            // 
            txtMa_Chuc_Nang.Location = new Point(161, 29);
            txtMa_Chuc_Nang.Name = "txtMa_Chuc_Nang";
            txtMa_Chuc_Nang.Size = new Size(156, 22);
            txtMa_Chuc_Nang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Chức Năng";
            // 
            // txtCol_Frozen
            // 
            txtCol_Frozen.Location = new Point(161, 67);
            txtCol_Frozen.Name = "txtCol_Frozen";
            txtCol_Frozen.Size = new Size(156, 22);
            txtCol_Frozen.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên cột";
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(161, 108);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(156, 22);
            txtGhi_Chu.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Ghi Chú";
            // 
            // FSys_002_03_Frozen_Column_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 214);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FSys_002_03_Frozen_Column_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMa_Chuc_Nang.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCol_Frozen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtMa_Chuc_Nang;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtCol_Frozen;
        private Label label2;
    }
}