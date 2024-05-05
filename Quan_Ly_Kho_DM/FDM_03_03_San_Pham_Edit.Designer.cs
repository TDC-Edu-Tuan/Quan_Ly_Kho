namespace Quan_Ly_Kho_DM
{
    partial class FDM_03_03_San_Pham_Edit
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
            txtTen_SP = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            btnSave = new Button();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtMa_SP = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbLSP = new ComboBox();
            cbbDVT = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTen_SP.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_SP.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbDVT);
            panel1.Controls.Add(cbbLSP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTen_SP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMa_SP);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 189);
            panel1.TabIndex = 0;
            // 
            // txtTen_SP
            // 
            txtTen_SP.Location = new Point(161, 57);
            txtTen_SP.Name = "txtTen_SP";
            txtTen_SP.Size = new Size(156, 22);
            txtTen_SP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên SP";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(573, 125);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 40);
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
            // txtMa_SP
            // 
            txtMa_SP.Location = new Point(161, 29);
            txtMa_SP.Name = "txtMa_SP";
            txtMa_SP.Size = new Size(156, 22);
            txtMa_SP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(379, 29);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "LSP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(379, 60);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "DVT";
            // 
            // cbbLSP
            // 
            cbbLSP.FormattingEnabled = true;
            cbbLSP.Location = new Point(491, 29);
            cbbLSP.Name = "cbbLSP";
            cbbLSP.Size = new Size(179, 24);
            cbbLSP.TabIndex = 9;
            // 
            // cbbDVT
            // 
            cbbDVT.FormattingEnabled = true;
            cbbDVT.Location = new Point(491, 60);
            cbbDVT.Name = "cbbDVT";
            cbbDVT.Size = new Size(179, 24);
            cbbDVT.TabIndex = 10;
            // 
            // FDM_03_03_San_Pham_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 189);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildCaptionFormatString = "{1} - {1}";
            MinimizeBox = false;
            Name = "FDM_03_03_San_Pham_Edit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FDM_03_03_San_Pham_Edit";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTen_SP.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMa_SP.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtMa_SP;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtTen_SP;
        private Label label3;
        private ComboBox cbbDVT;
        private ComboBox cbbLSP;
        private Label label5;
        private Label label4;
    }
}