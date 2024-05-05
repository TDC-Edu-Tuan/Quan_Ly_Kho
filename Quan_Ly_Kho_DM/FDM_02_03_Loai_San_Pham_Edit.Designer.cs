namespace Quan_Ly_Kho_DM
{
    partial class FDM_02_03_Loai_San_Pham_Edit
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
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtMa_LSP = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            txtTen_LSP = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_LSP.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTen_LSP.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTen_LSP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMa_LSP);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 190);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(223, 138);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Data;
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(161, 85);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(156, 22);
            txtGhi_Chu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Ghi chú";
            // 
            // txtMa_LSP
            // 
            txtMa_LSP.Location = new Point(161, 29);
            txtMa_LSP.Name = "txtMa_LSP";
            txtMa_LSP.Size = new Size(156, 22);
            txtMa_LSP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã LSP";
            // 
            // txtTen_LSP
            // 
            txtTen_LSP.Location = new Point(161, 57);
            txtTen_LSP.Name = "txtTen_LSP";
            txtTen_LSP.Size = new Size(156, 22);
            txtTen_LSP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên LSP";
            // 
            // FDM_02_03_Loai_San_Pham_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 190);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FDM_02_03_Loai_San_Pham_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_02_03_Loai_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_LSP.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTen_LSP.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtMa_LSP;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtTen_LSP;
        private Label label3;
    }
}