using DevExpress.DXTemplateGallery.Extensions;

namespace Quan_Ly_Kho_DM
{
    partial class FXNK_001_02_Ke_Hoach_Nhap_View
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
            tabControl1 = new TabControl();
            tabInfo = new TabPage();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            dtmNgay_Nhap_Kho = new DateTimePicker();
            txtNCC = new DevExpress.XtraEditors.TextEdit();
            label9 = new Label();
            label5 = new Label();
            txtTrang_Thai = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            txtGhi_Chu = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            txtSo_Phieu_Nhap = new DevExpress.XtraEditors.TextEdit();
            label6 = new Label();
            Sysem_Fields = new DevExpress.XtraEditors.GroupControl();
            Auto_ID = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            Created = new DevExpress.XtraEditors.TextEdit();
            Last_Updated_By_Function = new DevExpress.XtraEditors.TextEdit();
            Createdlb = new Label();
            label2 = new Label();
            Created_Bylb = new Label();
            Last_Updated_By = new DevExpress.XtraEditors.TextEdit();
            Created_By = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            lb = new Label();
            Last_Updated = new DevExpress.XtraEditors.TextEdit();
            label8 = new Label();
            Created_By_Function = new DevExpress.XtraEditors.TextEdit();
            tabDetail = new TabPage();
            grdData = new DataGridView();
            tabControl1.SuspendLayout();
            tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNCC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTrang_Thai.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sysem_Fields).BeginInit();
            Sysem_Fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Auto_ID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Created.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated_By_Function.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated_By.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Created_By.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Created_By_Function.Properties).BeginInit();
            tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInfo);
            tabControl1.Controls.Add(tabDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(652, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabInfo
            // 
            tabInfo.Controls.Add(groupControl1);
            tabInfo.Controls.Add(Sysem_Fields);
            tabInfo.Location = new Point(4, 25);
            tabInfo.Name = "tabInfo";
            tabInfo.Padding = new Padding(3);
            tabInfo.Size = new Size(644, 385);
            tabInfo.TabIndex = 0;
            tabInfo.Text = "Thông Tin";
            tabInfo.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(dtmNgay_Nhap_Kho);
            groupControl1.Controls.Add(txtNCC);
            groupControl1.Controls.Add(label9);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(txtTrang_Thai);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(txtGhi_Chu);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(txtSo_Phieu_Nhap);
            groupControl1.Controls.Add(label6);
            groupControl1.Location = new Point(22, 17);
            groupControl1.Margin = new Padding(3, 2, 3, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(598, 143);
            groupControl1.TabIndex = 21;
            groupControl1.Text = "Function Fields";
            // 
            // dtmNgay_Nhap_Kho
            // 
            dtmNgay_Nhap_Kho.Format = DateTimePickerFormat.Short;
            dtmNgay_Nhap_Kho.Location = new Point(121, 74);
            dtmNgay_Nhap_Kho.Name = "dtmNgay_Nhap_Kho";
            dtmNgay_Nhap_Kho.Size = new Size(136, 23);
            dtmNgay_Nhap_Kho.TabIndex = 14;
            // 
            // txtNCC
            // 
            txtNCC.Location = new Point(441, 36);
            txtNCC.Margin = new Padding(3, 2, 3, 2);
            txtNCC.Name = "txtNCC";
            txtNCC.Size = new Size(136, 22);
            txtNCC.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 42);
            label9.Name = "label9";
            label9.Size = new Size(88, 16);
            label9.TabIndex = 12;
            label9.Text = "Nhà Cung Cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 116);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 10;
            label5.Text = "Trạng Thái";
            // 
            // txtTrang_Thai
            // 
            txtTrang_Thai.Location = new Point(121, 113);
            txtTrang_Thai.Margin = new Padding(3, 2, 3, 2);
            txtTrang_Thai.Name = "txtTrang_Thai";
            txtTrang_Thai.Size = new Size(136, 22);
            txtTrang_Thai.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 74);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 8;
            label4.Text = "Ngày Nhập";
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new Point(441, 71);
            txtGhi_Chu.Margin = new Padding(3, 2, 3, 2);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new Size(136, 22);
            txtGhi_Chu.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 0;
            label1.Text = "Số Phiếu";
            // 
            // txtSo_Phieu_Nhap
            // 
            txtSo_Phieu_Nhap.Location = new Point(121, 36);
            txtSo_Phieu_Nhap.Margin = new Padding(3, 2, 3, 2);
            txtSo_Phieu_Nhap.Name = "txtSo_Phieu_Nhap";
            txtSo_Phieu_Nhap.Size = new Size(136, 22);
            txtSo_Phieu_Nhap.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 77);
            label6.Name = "label6";
            label6.Size = new Size(49, 16);
            label6.TabIndex = 6;
            label6.Text = "Ghi chú";
            // 
            // Sysem_Fields
            // 
            Sysem_Fields.Controls.Add(Auto_ID);
            Sysem_Fields.Controls.Add(label3);
            Sysem_Fields.Controls.Add(Created);
            Sysem_Fields.Controls.Add(Last_Updated_By_Function);
            Sysem_Fields.Controls.Add(Createdlb);
            Sysem_Fields.Controls.Add(label2);
            Sysem_Fields.Controls.Add(Created_Bylb);
            Sysem_Fields.Controls.Add(Last_Updated_By);
            Sysem_Fields.Controls.Add(Created_By);
            Sysem_Fields.Controls.Add(label7);
            Sysem_Fields.Controls.Add(lb);
            Sysem_Fields.Controls.Add(Last_Updated);
            Sysem_Fields.Controls.Add(label8);
            Sysem_Fields.Controls.Add(Created_By_Function);
            Sysem_Fields.Location = new Point(22, 176);
            Sysem_Fields.Margin = new Padding(3, 2, 3, 2);
            Sysem_Fields.Name = "Sysem_Fields";
            Sysem_Fields.Size = new Size(598, 185);
            Sysem_Fields.TabIndex = 20;
            Sysem_Fields.Text = "System Fields";
            // 
            // Auto_ID
            // 
            Auto_ID.Location = new Point(121, 49);
            Auto_ID.Margin = new Padding(3, 2, 3, 2);
            Auto_ID.Name = "Auto_ID";
            Auto_ID.Size = new Size(136, 22);
            Auto_ID.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 49);
            label3.Name = "label3";
            label3.Size = new Size(19, 16);
            label3.TabIndex = 18;
            label3.Text = "ID";
            // 
            // Created
            // 
            Created.Location = new Point(121, 84);
            Created.Margin = new Padding(3, 2, 3, 2);
            Created.Name = "Created";
            Created.Size = new Size(136, 22);
            Created.TabIndex = 3;
            // 
            // Last_Updated_By_Function
            // 
            Last_Updated_By_Function.Location = new Point(441, 145);
            Last_Updated_By_Function.Margin = new Padding(3, 2, 3, 2);
            Last_Updated_By_Function.Name = "Last_Updated_By_Function";
            Last_Updated_By_Function.Size = new Size(136, 22);
            Last_Updated_By_Function.TabIndex = 17;
            // 
            // Createdlb
            // 
            Createdlb.AutoSize = true;
            Createdlb.Location = new Point(11, 84);
            Createdlb.Name = "Createdlb";
            Createdlb.Size = new Size(82, 16);
            Createdlb.TabIndex = 2;
            Createdlb.Text = "Thời gian tạo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 148);
            label2.Name = "label2";
            label2.Size = new Size(125, 16);
            label2.TabIndex = 16;
            label2.Text = "Chức năng thực hiện";
            // 
            // Created_Bylb
            // 
            Created_Bylb.AutoSize = true;
            Created_Bylb.Location = new Point(11, 118);
            Created_Bylb.Name = "Created_Bylb";
            Created_Bylb.Size = new Size(62, 16);
            Created_Bylb.TabIndex = 4;
            Created_Bylb.Text = "Người tạo";
            // 
            // Last_Updated_By
            // 
            Last_Updated_By.Location = new Point(441, 115);
            Last_Updated_By.Margin = new Padding(3, 2, 3, 2);
            Last_Updated_By.Name = "Last_Updated_By";
            Last_Updated_By.Size = new Size(136, 22);
            Last_Updated_By.TabIndex = 15;
            // 
            // Created_By
            // 
            Created_By.Location = new Point(121, 115);
            Created_By.Margin = new Padding(3, 2, 3, 2);
            Created_By.Name = "Created_By";
            Created_By.Size = new Size(136, 22);
            Created_By.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 118);
            label7.Name = "label7";
            label7.Size = new Size(97, 16);
            label7.TabIndex = 14;
            label7.Text = "Người thực hiện";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(11, 145);
            lb.Name = "lb";
            lb.Size = new Size(90, 16);
            lb.TabIndex = 8;
            lb.Text = "Chức năng tạo";
            // 
            // Last_Updated
            // 
            Last_Updated.Location = new Point(441, 84);
            Last_Updated.Margin = new Padding(3, 2, 3, 2);
            Last_Updated.Name = "Last_Updated";
            Last_Updated.Size = new Size(136, 22);
            Last_Updated.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 86);
            label8.Name = "label8";
            label8.Size = new Size(107, 16);
            label8.TabIndex = 12;
            label8.Text = "Lần cuối cập nhật";
            // 
            // Created_By_Function
            // 
            Created_By_Function.Location = new Point(121, 145);
            Created_By_Function.Margin = new Padding(3, 2, 3, 2);
            Created_By_Function.Name = "Created_By_Function";
            Created_By_Function.Size = new Size(136, 22);
            Created_By_Function.TabIndex = 9;
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(grdData);
            tabDetail.Location = new Point(4, 25);
            tabDetail.Name = "tabDetail";
            tabDetail.Padding = new Padding(3);
            tabDetail.Size = new Size(644, 385);
            tabDetail.TabIndex = 1;
            tabDetail.Text = "Chi Tiết";
            tabDetail.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            grdData.AllowUserToAddRows = false;
            grdData.AllowUserToDeleteRows = false;
            grdData.AllowUserToResizeColumns = false;
            grdData.AllowUserToResizeRows = false;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Dock = DockStyle.Fill;
            grdData.Location = new Point(3, 3);
            grdData.Name = "grdData";
            grdData.RowHeadersVisible = false;
            grdData.RowHeadersWidth = 51;
            grdData.RowTemplate.Height = 29;
            grdData.Size = new Size(638, 379);
            grdData.TabIndex = 0;
            // 
            // FXNK_001_02_Ke_Hoach_Nhap_View
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 414);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FXNK_001_02_Ke_Hoach_Nhap_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết";
            Load += Load_Form;
            tabControl1.ResumeLayout(false);
            tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNCC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTrang_Thai.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGhi_Chu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSo_Phieu_Nhap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sysem_Fields).EndInit();
            Sysem_Fields.ResumeLayout(false);
            Sysem_Fields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Auto_ID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Created.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated_By_Function.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated_By.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Created_By.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Last_Updated.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Created_By_Function.Properties).EndInit();
            tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInfo;
        private TabPage tabDetail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtGhi_Chu;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtSo_Phieu_Nhap;
        private Label label6;
        private DevExpress.XtraEditors.GroupControl Sysem_Fields;
        private DevExpress.XtraEditors.TextEdit Auto_ID;
        private Label label3;
        private new DevExpress.XtraEditors.TextEdit Created;
        private DevExpress.XtraEditors.TextEdit Last_Updated_By_Function;
        private Label Createdlb;
        private Label label2;
        private Label Created_Bylb;
        private DevExpress.XtraEditors.TextEdit Last_Updated_By;
        private DevExpress.XtraEditors.TextEdit Created_By;
        private Label label7;
        private Label lb;
        private DevExpress.XtraEditors.TextEdit Last_Updated;
        private Label label8;
        private DevExpress.XtraEditors.TextEdit Created_By_Function;
        private Label label5;
        private DevExpress.XtraEditors.TextEdit txtTrang_Thai;
        private DevExpress.XtraEditors.TextEdit txtNCC;
        private Label label9;
        private DateTimePicker dtmNgay_Nhap_Kho;
        private DataGridView grdData;
    }
}