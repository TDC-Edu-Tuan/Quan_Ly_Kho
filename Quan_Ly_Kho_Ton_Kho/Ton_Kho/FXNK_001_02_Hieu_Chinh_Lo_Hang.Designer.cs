using DevExpress.XtraMap.Native;

namespace Quan_Ly_Kho_Ton_Kho.Ton_Kho
{
    partial class FXNK_001_02_Hieu_Chinh_Lo_Hang
    { /// <summary>
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
            btnThem = new Button();
            label4 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtSL = new DevExpress.XtraEditors.TextEdit();
            cbbSan_Pham = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSL.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(cbbSan_Pham);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 240);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(233, 177);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 37);
            btnThem.TabIndex = 9;
            btnThem.Text = "Lưu";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += Save_Data;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 127);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 8;
            label4.Text = "Ghi Chú";
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(155, 125);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(172, 22);
            txtGhi_Chu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 4;
            label2.Text = "Số Lượng";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(155, 80);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(172, 22);
            txtSL.TabIndex = 3;
            // 
            // cbbSan_Pham
            // 
            cbbSan_Pham.FormattingEnabled = true;
            cbbSan_Pham.Location = new Point(155, 35);
            cbbSan_Pham.Name = "cbbSan_Pham";
            cbbSan_Pham.Size = new Size(172, 24);
            cbbSan_Pham.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 1;
            label1.Text = "Mã Sản Phẩm";
            // 
            // FXNK_001_02_Hieu_Chinh_Lo_Hang
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 240);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FXNK_001_02_Hieu_Chinh_Lo_Hang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hiệu Chỉnh";
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSL.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThem;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private ComboBox cbbSan_Pham;
        private Label label1;
    }
}