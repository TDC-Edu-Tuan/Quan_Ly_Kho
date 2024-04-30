using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using Quan_Ly_Kho_Data_Access.Utility;
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
            Menu = new AccordionControl();
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
            Header = new DevExpress.XtraBars.BarStaticItem();
            Title = new DevExpress.XtraBars.BarStaticItem();
            fluentFormDefaultManager1 = new FluentFormDefaultManager(components);
            Container = new FluentDesignFormContainer();
            ((ISupportInitialize)Menu).BeginInit();
            ((ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Dock = System.Windows.Forms.DockStyle.Left;
            Menu.Elements.AddRange(new AccordionControlElement[] { Danh_Muc, Nhap_Hang, Dev_Tool, Xuat_Hang, Ton_Kho, Ca_Nhan });
            Menu.Location = new System.Drawing.Point(0, 39);
            Menu.Name = "Menu";
            Menu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            Menu.ScrollBarMode = ScrollBarMode.Touch;
            Menu.ShowFilterControl = ShowFilterControl.Always;
            Menu.Size = new System.Drawing.Size(260, 434);
            Menu.TabIndex = 1;
            Menu.ViewType = AccordionControlViewType.HamburgerMenu;
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
            Danh_Muc_Co_Ban.Expanded = true;
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
            fluentDesignFormControl1.ForeColor = System.Drawing.Color.White;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { Header, Title });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1032, 39);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(Header);
            fluentDesignFormControl1.TitleItemLinks.Add(Title);
            // 
            // Header
            // 
            Header.Id = 6;
            Header.Name = "Header";
            // 
            // Title
            // 
            Title.Caption = "Tiêu đề";
            Title.Id = 8;
            Title.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Title.ItemAppearance.Hovered.Options.UseFont = true;
            Title.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Title.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            Title.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            Title.ItemAppearance.Normal.Options.UseFont = true;
            Title.ItemAppearance.Normal.Options.UseForeColor = true;
            Title.Name = "Title";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { Header, Title });
            fluentFormDefaultManager1.MaxItemId = 9;
            // 
            // Container
            // 
            Container.Dock = System.Windows.Forms.DockStyle.Fill;
            Container.Location = new System.Drawing.Point(260, 39);
            Container.Name = "Container";
            Container.Size = new System.Drawing.Size(772, 434);
            Container.TabIndex = 0;
            // 
            // FMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 473);
            ControlContainer = Container;
            Controls.Add(Container);
            Controls.Add(Menu);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMain";
            NavigationControl = Menu;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FMain_Load;
            ((ISupportInitialize)Menu).EndInit();
            ((ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private AccordionControl Menu;
        private FluentDesignFormControl fluentDesignFormControl1;
        private FluentFormDefaultManager fluentFormDefaultManager1;
        private FluentDesignFormContainer Container;
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


        private DevExpress.XtraBars.BarStaticItem Header;
        private DevExpress.XtraBars.BarStaticItem Title;
    }
}

