namespace Quan_Ly_Kho_Xuat_Kho.Xuat_Kho
{
    partial class FXNK_001_03_Update_XK_Details_Edit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            grdData = new DataGridView();
            panel2 = new Panel();
            btnThem = new Button();
            txtTim_Kiem = new DevExpress.XtraEditors.TextEdit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTim_Kiem.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 429);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(grdData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 378);
            panel3.TabIndex = 1;
            // 
            // grdData
            // 
            grdData.AllowUserToAddRows = false;
            grdData.AllowUserToDeleteRows = false;
            grdData.AllowUserToResizeColumns = false;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Dock = DockStyle.Fill;
            grdData.Location = new Point(0, 0);
            grdData.Name = "grdData";
            grdData.RowHeadersVisible = false;
            grdData.RowHeadersWidth = 51;
            grdData.RowTemplate.Height = 29;
            grdData.Size = new Size(1036, 378);
            grdData.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTim_Kiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 51);
            panel2.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(900, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += Open_Edit;
            // 
            // txtTim_Kiem
            // 
            txtTim_Kiem.Location = new Point(12, 12);
            txtTim_Kiem.Name = "txtTim_Kiem";
            txtTim_Kiem.Size = new Size(156, 22);
            txtTim_Kiem.TabIndex = 0;
            // 
            // FXNK_001_03_Update_NK_Details_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 429);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FXNK_001_03_Update_NK_Details_Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Load_Form;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtTim_Kiem.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView grdData;
        private Panel panel2;
        private Button btnThem;
        private DevExpress.XtraEditors.TextEdit txtTim_Kiem;
    }
}
