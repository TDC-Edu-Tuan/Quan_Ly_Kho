﻿using System.Drawing;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    partial class FLoading
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
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = Color.Transparent;
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            progressPanel1.AppearanceCaption.Options.UseFont = true;
            progressPanel1.AppearanceDescription.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            progressPanel1.AppearanceDescription.Options.UseFont = true;
            progressPanel1.Caption = "Đang load hệ thống";
            progressPanel1.Dock = DockStyle.Fill;
            progressPanel1.ImageHorzOffset = 20;
            progressPanel1.Location = new Point(0, 21);
            progressPanel1.Margin = new Padding(0, 4, 0, 4);
            progressPanel1.Name = "progressPanel1";
            progressPanel1.Size = new Size(287, 48);
            progressPanel1.TabIndex = 0;
            progressPanel1.Text = "progressPanel1";
            progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(progressPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 17, 0, 17);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(287, 90);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(287, 90);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "FLoading";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
