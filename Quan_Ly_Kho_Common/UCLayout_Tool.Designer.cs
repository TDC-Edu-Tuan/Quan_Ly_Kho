namespace Quan_Ly_Kho_Common
{
    partial class UCLayout_Tool
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
            btnExport = new Button();
            btnImport = new Button();
            btnAdd_Data = new Button();
            dtmTo = new DateTimePicker();
            To = new Label();
            dtmFrom = new DateTimePicker();
            From = new Label();
            btnSearch = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnAdd_Data);
            panel1.Controls.Add(dtmTo);
            panel1.Controls.Add(To);
            panel1.Controls.Add(dtmFrom);
            panel1.Controls.Add(From);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 74);
            panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Location = new Point(1107, 15);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(110, 47);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Location = new Point(952, 15);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(110, 47);
            btnImport.TabIndex = 5;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnAdd_Data
            // 
            btnAdd_Data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd_Data.Location = new Point(792, 15);
            btnAdd_Data.Name = "btnAdd_Data";
            btnAdd_Data.Size = new Size(110, 47);
            btnAdd_Data.TabIndex = 4;
            btnAdd_Data.Text = "Thêm";
            btnAdd_Data.UseVisualStyleBackColor = true;
            btnAdd_Data.Click += btnAdd_Data_Click;
            // 
            // dtmTo
            // 
            dtmTo.Format = DateTimePickerFormat.Short;
            dtmTo.Location = new Point(233, 23);
            dtmTo.Name = "dtmTo";
            dtmTo.Size = new Size(121, 27);
            dtmTo.TabIndex = 3;
            // 
            // To
            // 
            To.AutoSize = true;
            To.Location = new Point(191, 28);
            To.Name = "To";
            To.Size = new Size(36, 20);
            To.TabIndex = 2;
            To.Text = "Đến";
            // 
            // dtmFrom
            // 
            dtmFrom.Format = DateTimePickerFormat.Short;
            dtmFrom.Location = new Point(46, 24);
            dtmFrom.Name = "dtmFrom";
            dtmFrom.Size = new Size(122, 27);
            dtmFrom.TabIndex = 1;
            // 
            // From
            // 
            From.AutoSize = true;
            From.Location = new Point(14, 28);
            From.Name = "From";
            From.Size = new Size(26, 20);
            From.TabIndex = 0;
            From.Text = "Từ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(392, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(93, 27);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // UCLayout_Tool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCLayout_Tool";
            Size = new Size(1258, 74);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd_Data;
        private DateTimePicker dtmTo;
        private Label To;
        private DateTimePicker dtmFrom;
        private Label From;
        private Button btnExport;
        private Button btnImport;
        private Button btnSearch;
    }
}
