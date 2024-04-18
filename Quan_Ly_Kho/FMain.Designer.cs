using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using System.ComponentModel;

namespace Quan_Ly_Kho
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            fluentDesignFormContainer1 = new FluentDesignFormContainer();
            accordionControl1 = new AccordionControl();
            Danh_Muc = new AccordionControlElement();
            Danh_Muc_Quan_Tri = new AccordionControlElement();
            Danh_Muc_Kho_Item = new AccordionControlElement();
            Danh_Muc_Kho_User_Item = new AccordionControlElement();
            Danh_Muc_Chu_Hang_Item = new AccordionControlElement();
            Danh_Muc_Chu_Hang_User = new AccordionControlElement();
            Danh_Muc_Nhan_Vien_Item = new AccordionControlElement();
            Danh_Muc_Co_Ban = new AccordionControlElement();
            Danh_Muc_Don_Vi_Tinh_Item = new AccordionControlElement();
            Danh_Muc_Loai_San_Pham_Item = new AccordionControlElement();
            Danh_Muc_San_Pham_Item = new AccordionControlElement();
            Danh_Muc_Ke_Item = new AccordionControlElement();
            Danh_Muc_Vi_Tri_Item = new AccordionControlElement();
            Danh_Muc_NCC_Item = new AccordionControlElement();
            Danh_Muc_Noi_Xuat_Den_Item = new AccordionControlElement();
            Nhap_Hang = new AccordionControlElement();
            Dev_Tool = new AccordionControlElement();
            Tool_Menu_Item = new AccordionControlElement();
            Xuat_Hang = new AccordionControlElement();
            Ton_Kho = new AccordionControlElement();
            Ca_Nhan = new AccordionControlElement();
            fluentDesignFormControl1 = new FluentDesignFormControl();
            cbbKho = new DevExpress.XtraBars.BarEditItem();
            repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            fluentFormDefaultManager1 = new FluentFormDefaultManager(components);
            repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((ISupportInitialize)accordionControl1).BeginInit();
            ((ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((ISupportInitialize)repositoryItemComboBox2).BeginInit();
            ((ISupportInitialize)repositoryItemComboBox3).BeginInit();
            ((ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((ISupportInitialize)repositoryItemComboBox1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new System.Drawing.Size(772, 434);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new AccordionControlElement[] { Danh_Muc, Nhap_Hang, Dev_Tool, Xuat_Hang, Ton_Kho, Ca_Nhan });
            accordionControl1.Location = new System.Drawing.Point(0, 39);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            accordionControl1.ScrollBarMode = ScrollBarMode.Touch;
            accordionControl1.ShowFilterControl = ShowFilterControl.Always;
            accordionControl1.Size = new System.Drawing.Size(260, 434);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
            // 
            // Danh_Muc
            // 
            Danh_Muc.Elements.AddRange(new AccordionControlElement[] { Danh_Muc_Quan_Tri, Danh_Muc_Co_Ban });
            Danh_Muc.Expanded = true;
            Danh_Muc.Name = "Danh_Muc";
            Danh_Muc.Text = "Danh Mục";
            // 
            // Danh_Muc_Quan_Tri
            // 
            Danh_Muc_Quan_Tri.Elements.AddRange(new AccordionControlElement[] { Danh_Muc_Kho_Item, Danh_Muc_Kho_User_Item, Danh_Muc_Chu_Hang_Item, Danh_Muc_Chu_Hang_User, Danh_Muc_Nhan_Vien_Item });
            Danh_Muc_Quan_Tri.Name = "Danh_Muc_Quan_Tri";
            Danh_Muc_Quan_Tri.Text = "Quản Trị";
            // 
            // Danh_Muc_Kho_Item
            // 
            Danh_Muc_Kho_Item.Name = "Danh_Muc_Kho_Item";
            Danh_Muc_Kho_Item.Style = ElementStyle.Item;
            Danh_Muc_Kho_Item.Text = "Kho";
            // 
            // Danh_Muc_Kho_User_Item
            // 
            Danh_Muc_Kho_User_Item.Name = "Danh_Muc_Kho_User_Item";
            Danh_Muc_Kho_User_Item.Style = ElementStyle.Item;
            Danh_Muc_Kho_User_Item.Text = "Kho - User";
            // 
            // Danh_Muc_Chu_Hang_Item
            // 
            Danh_Muc_Chu_Hang_Item.Name = "Danh_Muc_Chu_Hang_Item";
            Danh_Muc_Chu_Hang_Item.Style = ElementStyle.Item;
            Danh_Muc_Chu_Hang_Item.Text = "Chủ Hàng";
            // 
            // Danh_Muc_Chu_Hang_User
            // 
            Danh_Muc_Chu_Hang_User.Name = "Danh_Muc_Chu_Hang_User";
            Danh_Muc_Chu_Hang_User.Style = ElementStyle.Item;
            Danh_Muc_Chu_Hang_User.Text = "Chủ Hàng - User";
            // 
            // Danh_Muc_Nhan_Vien_Item
            // 
            Danh_Muc_Nhan_Vien_Item.Name = "Danh_Muc_Nhan_Vien_Item";
            Danh_Muc_Nhan_Vien_Item.Style = ElementStyle.Item;
            Danh_Muc_Nhan_Vien_Item.Text = "Nhân Viên";
            // 
            // Danh_Muc_Co_Ban
            // 
            Danh_Muc_Co_Ban.Elements.AddRange(new AccordionControlElement[] { Danh_Muc_Don_Vi_Tinh_Item, Danh_Muc_Loai_San_Pham_Item, Danh_Muc_San_Pham_Item, Danh_Muc_Ke_Item, Danh_Muc_Vi_Tri_Item, Danh_Muc_NCC_Item, Danh_Muc_Noi_Xuat_Den_Item });
            Danh_Muc_Co_Ban.Name = "Danh_Muc_Co_Ban";
            Danh_Muc_Co_Ban.Text = "Cơ Bản";
            // 
            // Danh_Muc_Don_Vi_Tinh_Item
            // 
            Danh_Muc_Don_Vi_Tinh_Item.Name = "Danh_Muc_Don_Vi_Tinh_Item";
            Danh_Muc_Don_Vi_Tinh_Item.Style = ElementStyle.Item;
            Danh_Muc_Don_Vi_Tinh_Item.Text = "Đơn Vị Tính";
            // 
            // Danh_Muc_Loai_San_Pham_Item
            // 
            Danh_Muc_Loai_San_Pham_Item.Name = "Danh_Muc_Loai_San_Pham_Item";
            Danh_Muc_Loai_San_Pham_Item.Style = ElementStyle.Item;
            Danh_Muc_Loai_San_Pham_Item.Text = "Loại Sản Phẩm";
            // 
            // Danh_Muc_San_Pham_Item
            // 
            Danh_Muc_San_Pham_Item.Name = "Danh_Muc_San_Pham_Item";
            Danh_Muc_San_Pham_Item.Style = ElementStyle.Item;
            Danh_Muc_San_Pham_Item.Text = "Sản Phẩm";
            // 
            // Danh_Muc_Ke_Item
            // 
            Danh_Muc_Ke_Item.Name = "Danh_Muc_Ke_Item";
            Danh_Muc_Ke_Item.Style = ElementStyle.Item;
            Danh_Muc_Ke_Item.Text = "Kệ";
            // 
            // Danh_Muc_Vi_Tri_Item
            // 
            Danh_Muc_Vi_Tri_Item.Name = "Danh_Muc_Vi_Tri_Item";
            Danh_Muc_Vi_Tri_Item.Style = ElementStyle.Item;
            Danh_Muc_Vi_Tri_Item.Text = "Vị Trí";
            // 
            // Danh_Muc_NCC_Item
            // 
            Danh_Muc_NCC_Item.Name = "Danh_Muc_NCC_Item";
            Danh_Muc_NCC_Item.Style = ElementStyle.Item;
            Danh_Muc_NCC_Item.Text = "Nhà Cung Cấp";
            // 
            // Danh_Muc_Noi_Xuat_Den_Item
            // 
            Danh_Muc_Noi_Xuat_Den_Item.Name = "Danh_Muc_Noi_Xuat_Den_Item";
            Danh_Muc_Noi_Xuat_Den_Item.Style = ElementStyle.Item;
            Danh_Muc_Noi_Xuat_Den_Item.Text = "Nơi Xuất Đến";
            // 
            // Nhap_Hang
            // 
            Nhap_Hang.Name = "Nhap_Hang";
            Nhap_Hang.Text = "Nhập Hàng";
            // 
            // Dev_Tool
            // 
            Dev_Tool.Elements.AddRange(new AccordionControlElement[] { Tool_Menu_Item });
            Dev_Tool.Name = "Dev_Tool";
            Dev_Tool.Text = "Tool";
            // 
            // Tool_Menu_Item
            // 
            Tool_Menu_Item.Name = "Tool_Menu_Item";
            Tool_Menu_Item.Style = ElementStyle.Item;
            Tool_Menu_Item.Text = "Menu";
            // 
            // Xuat_Hang
            // 
            Xuat_Hang.Name = "Xuat_Hang";
            Xuat_Hang.Text = "Xuất Hàng";
            // 
            // Ton_Kho
            // 
            Ton_Kho.Name = "Ton_Kho";
            Ton_Kho.Text = "Tồn Kho";
            // 
            // Ca_Nhan
            // 
            Ca_Nhan.Expanded = true;
            Ca_Nhan.Name = "Ca_Nhan";
            Ca_Nhan.Text = "Cá Nhân";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { cbbKho, barEditItem2, barHeaderItem1, barStaticItem1, barEditItem1, barStaticItem2 });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1, repositoryItemComboBox2, repositoryItemComboBox3 });
            fluentDesignFormControl1.Size = new System.Drawing.Size(1032, 39);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(cbbKho);
            fluentDesignFormControl1.TitleItemLinks.Add(barStaticItem1);
            fluentDesignFormControl1.TitleItemLinks.Add(barEditItem1);
            fluentDesignFormControl1.TitleItemLinks.Add(barStaticItem2);
            // 
            // cbbKho
            // 
            cbbKho.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            cbbKho.Caption = "Kho: ";
            cbbKho.Edit = repositoryItemComboBox2;
            cbbKho.EditHeight = 20;
            cbbKho.EditWidth = 200;
            cbbKho.Id = 0;
            cbbKho.Name = "cbbKho";
            // 
            // repositoryItemComboBox2
            // 
            repositoryItemComboBox2.AutoHeight = false;
            repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barEditItem2
            // 
            barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barEditItem2.Caption = "Kho: ";
            barEditItem2.Edit = repositoryItemComboBox2;
            barEditItem2.EditHeight = 20;
            barEditItem2.EditWidth = 200;
            barEditItem2.Id = 1;
            barEditItem2.MaxWidth = 10;
            barEditItem2.MinWidth = 10;
            barEditItem2.Name = "barEditItem2";
            // 
            // barHeaderItem1
            // 
            barHeaderItem1.Caption = "Kho: ";
            barHeaderItem1.Id = 2;
            barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem1
            // 
            barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barStaticItem1.Caption = "Kho";
            barStaticItem1.Id = 3;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItem1
            // 
            barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemComboBox3;
            barEditItem1.EditWidth = 200;
            barEditItem1.Id = 4;
            barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox3
            // 
            repositoryItemComboBox3.AutoHeight = false;
            repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // barStaticItem2
            // 
            barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barStaticItem2.Caption = "Chủ Hàng";
            barStaticItem2.Id = 5;
            barStaticItem2.Name = "barStaticItem2";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { cbbKho, barEditItem2, barHeaderItem1, barStaticItem1, barEditItem1, barStaticItem2 });
            fluentFormDefaultManager1.MaxItemId = 6;
            fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1, repositoryItemComboBox2, repositoryItemComboBox3 });
            // 
            // repositoryItemComboBox1
            // 
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // FMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 473);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMain";
            NavigationControl = accordionControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FMain_Load;
            ((ISupportInitialize)accordionControl1).EndInit();
            ((ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((ISupportInitialize)repositoryItemComboBox2).EndInit();
            ((ISupportInitialize)repositoryItemComboBox3).EndInit();
            ((ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((ISupportInitialize)repositoryItemComboBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FluentDesignFormContainer fluentDesignFormContainer1;
        private AccordionControl accordionControl1;
        private FluentDesignFormControl fluentDesignFormControl1;
        private FluentFormDefaultManager fluentFormDefaultManager1;
        private AccordionControlElement Dev_Tool;
        private AccordionControlElement Danh_Muc;
        private AccordionControlElement Danh_Muc_Quan_Tri;
        private AccordionControlElement Danh_Muc_Kho_Item;
        private AccordionControlElement Danh_Muc_Co_Ban;
        private AccordionControlElement Danh_Muc_Chu_Hang_Item;
        private AccordionControlElement Danh_Muc_Don_Vi_Tinh_Item;
        private AccordionControlElement Danh_Muc_Loai_San_Pham_Item;
        private AccordionControlElement Danh_Muc_San_Pham_Item;
        private AccordionControlElement Danh_Muc_Ke_Item;
        private AccordionControlElement Danh_Muc_Vi_Tri_Item;
        private AccordionControlElement Danh_Muc_Nhan_Vien_Item;
        private AccordionControlElement Danh_Muc_NCC_Item;
        private AccordionControlElement Danh_Muc_Noi_Xuat_Den_Item;
        private AccordionControlElement Tool_Menu_Item;
        private AccordionControlElement Danh_Muc_Kho_User_Item;
        private AccordionControlElement Danh_Muc_Chu_Hang_User;
        private AccordionControlElement Nhap_Hang;
        private AccordionControlElement Xuat_Hang;
        private AccordionControlElement Ton_Kho;
        private AccordionControlElement Ca_Nhan;
        private DevExpress.XtraBars.BarEditItem cbbKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
    }
}

