namespace Quan_Ly_Kho_Nhap_Kho.Nhap_Kho
{
    partial class FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke
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
            cbbVi_Tri = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cbbVi_Tri);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 156);
            panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(173, 107);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 37);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += Save_Data;
            // 
            // cbbVi_Tri
            // 
            cbbVi_Tri.FormattingEnabled = true;
            cbbVi_Tri.Location = new Point(91, 23);
            cbbVi_Tri.Name = "cbbVi_Tri";
            cbbVi_Tri.Size = new Size(176, 24);
            cbbVi_Tri.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 0;
            label1.Text = "Vị Trí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 3;
            label2.Text = "Ghi Chú";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(92, 61);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(175, 22);
            txtGhi_Chu.TabIndex = 4;
            // 
            // FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 156);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FXNK_002_03_QLNK_Chuyen_Hang_Len_Ke";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLuu;
        private ComboBox cbbVi_Tri;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label2;
    }
}