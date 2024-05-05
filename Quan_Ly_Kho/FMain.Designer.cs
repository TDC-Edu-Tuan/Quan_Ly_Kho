using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using Quan_Ly_Kho_Common;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FMain));
            Loading_Control = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(FLoading), true, true);
            Menu = new AccordionControl();
            Danh_Muc = new AccordionControlElement();
            Danh_Muc_Quan_Tri = new AccordionControlElement();
            FDM_08_Kho = new AccordionControlElement();
            FDM_09_Kho_User = new AccordionControlElement();
            FDM_10_Chu_Hang = new AccordionControlElement();
            FDM_11_Chu_Hang_User = new AccordionControlElement();
            FDM_12_Nhan_Vien_Kho = new AccordionControlElement();
            Danh_Muc_Co_Ban = new AccordionControlElement();
            FDM_01_Don_Vi_Tinh = new AccordionControlElement();
            FDM_02_Loai_San_Pham = new AccordionControlElement();
            FDM_03_San_Pham = new AccordionControlElement();
            FDM_04_Day_Ke = new AccordionControlElement();
            FDM_05_Vi_Tri = new AccordionControlElement();
            FDM_06_NCC = new AccordionControlElement();
            FDM_07_Noi_Xuat_Den = new AccordionControlElement();
            Nhap_Hang = new AccordionControlElement();
            Dev_Tool = new AccordionControlElement();
            Tool_Menu_Item = new AccordionControlElement();
            Xuat_Hang = new AccordionControlElement();
            Ton_Kho = new AccordionControlElement();
            Ca_Nhan = new AccordionControlElement();
            Dang_Xuat_Item = new AccordionControlElement();
            fluentDesignFormControl1 = new FluentDesignFormControl();
            Header = new DevExpress.XtraBars.BarStaticItem();
            Title = new DevExpress.XtraBars.BarStaticItem();
            Reload_Item = new DevExpress.XtraBars.BarButtonItem();
            fluentFormDefaultManager1 = new FluentFormDefaultManager(components);
            Container = new FluentDesignFormContainer();
            ((ISupportInitialize)Menu).BeginInit();
            ((ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // Loading_Control
            // 
            Loading_Control.ClosingDelay = 500;
            // 
            // Menu
            // 
            Menu.Appearance.AccordionControl.ForeColor = System.Drawing.Color.FromArgb(110, 218, 218);
            Menu.Appearance.AccordionControl.Options.UseForeColor = true;
            Menu.Dock = System.Windows.Forms.DockStyle.Left;
            Menu.Elements.AddRange(new AccordionControlElement[] { Danh_Muc, Nhap_Hang, Dev_Tool, Xuat_Hang, Ton_Kho, Ca_Nhan });
            Menu.Location = new System.Drawing.Point(0, 39);
            Menu.Name = "Menu";
            Menu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            Menu.ScrollBarMode = ScrollBarMode.Fluent;
            Menu.ShowFilterControl = ShowFilterControl.Always;
            Menu.Size = new System.Drawing.Size(312, 434);
            Menu.TabIndex = 1;
            Menu.ViewType = AccordionControlViewType.HamburgerMenu;
            // 
            // Danh_Muc
            // 
            Danh_Muc.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Danh_Muc.Appearance.Default.Options.UseFont = true;
            Danh_Muc.Elements.AddRange(new AccordionControlElement[] { Danh_Muc_Quan_Tri, Danh_Muc_Co_Ban });
            Danh_Muc.Expanded = true;
            Danh_Muc.Name = "Danh_Muc";
            Danh_Muc.Text = "Danh Mục";
            // 
            // Danh_Muc_Quan_Tri
            // 
            Danh_Muc_Quan_Tri.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Danh_Muc_Quan_Tri.Appearance.Default.Options.UseFont = true;
            Danh_Muc_Quan_Tri.Elements.AddRange(new AccordionControlElement[] { FDM_08_Kho, FDM_09_Kho_User, FDM_10_Chu_Hang, FDM_11_Chu_Hang_User, FDM_12_Nhan_Vien_Kho });
            Danh_Muc_Quan_Tri.Expanded = true;
            Danh_Muc_Quan_Tri.Name = "Danh_Muc_Quan_Tri";
            Danh_Muc_Quan_Tri.Text = "Quản Trị";
            // 
            // FDM_08_Kho
            // 
            FDM_08_Kho.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_08_Kho.Appearance.Default.Options.UseFont = true;
            FDM_08_Kho.Name = "FDM_08_Kho";
            FDM_08_Kho.Style = ElementStyle.Item;
            FDM_08_Kho.Text = "Kho";
            // 
            // FDM_09_Kho_User
            // 
            FDM_09_Kho_User.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_09_Kho_User.Appearance.Default.Options.UseFont = true;
            FDM_09_Kho_User.Name = "FDM_09_Kho_User";
            FDM_09_Kho_User.Style = ElementStyle.Item;
            FDM_09_Kho_User.Text = "Kho - User";
            // 
            // FDM_10_Chu_Hang
            // 
            FDM_10_Chu_Hang.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_10_Chu_Hang.Appearance.Default.Options.UseFont = true;
            FDM_10_Chu_Hang.Name = "FDM_10_Chu_Hang";
            FDM_10_Chu_Hang.Style = ElementStyle.Item;
            FDM_10_Chu_Hang.Text = "Chủ Hàng";
            // 
            // FDM_11_Chu_Hang_User
            // 
            FDM_11_Chu_Hang_User.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_11_Chu_Hang_User.Appearance.Default.Options.UseFont = true;
            FDM_11_Chu_Hang_User.Name = "FDM_11_Chu_Hang_User";
            FDM_11_Chu_Hang_User.Style = ElementStyle.Item;
            FDM_11_Chu_Hang_User.Text = "Chủ Hàng - User";
            // 
            // FDM_12_Nhan_Vien_Kho
            // 
            FDM_12_Nhan_Vien_Kho.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_12_Nhan_Vien_Kho.Appearance.Default.Options.UseFont = true;
            FDM_12_Nhan_Vien_Kho.Name = "FDM_12_Nhan_Vien_Kho";
            FDM_12_Nhan_Vien_Kho.Style = ElementStyle.Item;
            FDM_12_Nhan_Vien_Kho.Text = "Nhân Viên";
            // 
            // Danh_Muc_Co_Ban
            // 
            Danh_Muc_Co_Ban.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Danh_Muc_Co_Ban.Appearance.Default.Options.UseFont = true;
            Danh_Muc_Co_Ban.Elements.AddRange(new AccordionControlElement[] { FDM_01_Don_Vi_Tinh, FDM_02_Loai_San_Pham, FDM_03_San_Pham, FDM_04_Day_Ke, FDM_05_Vi_Tri, FDM_06_NCC, FDM_07_Noi_Xuat_Den });
            Danh_Muc_Co_Ban.Name = "Danh_Muc_Co_Ban";
            Danh_Muc_Co_Ban.Text = "Cơ Bản";
            // 
            // FDM_01_Don_Vi_Tinh
            // 
            FDM_01_Don_Vi_Tinh.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_01_Don_Vi_Tinh.Appearance.Default.Options.UseFont = true;
            FDM_01_Don_Vi_Tinh.Name = "FDM_01_Don_Vi_Tinh";
            FDM_01_Don_Vi_Tinh.Style = ElementStyle.Item;
            FDM_01_Don_Vi_Tinh.Text = "Đơn Vị Tính";
            // 
            // FDM_02_Loai_San_Pham
            // 
            FDM_02_Loai_San_Pham.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_02_Loai_San_Pham.Appearance.Default.Options.UseFont = true;
            FDM_02_Loai_San_Pham.Name = "FDM_02_Loai_San_Pham";
            FDM_02_Loai_San_Pham.Style = ElementStyle.Item;
            FDM_02_Loai_San_Pham.Text = "Loại Sản Phẩm";
            // 
            // FDM_03_San_Pham
            // 
            FDM_03_San_Pham.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_03_San_Pham.Appearance.Default.Options.UseFont = true;
            FDM_03_San_Pham.Name = "FDM_03_San_Pham";
            FDM_03_San_Pham.Style = ElementStyle.Item;
            FDM_03_San_Pham.Text = "Sản Phẩm";
            // 
            // FDM_04_Day_Ke
            // 
            FDM_04_Day_Ke.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_04_Day_Ke.Appearance.Default.Options.UseFont = true;
            FDM_04_Day_Ke.Name = "FDM_04_Day_Ke";
            FDM_04_Day_Ke.Style = ElementStyle.Item;
            FDM_04_Day_Ke.Text = "Dãy Kệ";
            // 
            // FDM_05_Vi_Tri
            // 
            FDM_05_Vi_Tri.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_05_Vi_Tri.Appearance.Default.Options.UseFont = true;
            FDM_05_Vi_Tri.Name = "FDM_05_Vi_Tri";
            FDM_05_Vi_Tri.Style = ElementStyle.Item;
            FDM_05_Vi_Tri.Text = "Vị Trí";
            // 
            // FDM_06_NCC
            // 
            FDM_06_NCC.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_06_NCC.Appearance.Default.Options.UseFont = true;
            FDM_06_NCC.Name = "FDM_06_NCC";
            FDM_06_NCC.Style = ElementStyle.Item;
            FDM_06_NCC.Text = "Nhà Cung Cấp";
            // 
            // FDM_07_Noi_Xuat_Den
            // 
            FDM_07_Noi_Xuat_Den.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FDM_07_Noi_Xuat_Den.Appearance.Default.Options.UseFont = true;
            FDM_07_Noi_Xuat_Den.Name = "FDM_07_Noi_Xuat_Den";
            FDM_07_Noi_Xuat_Den.Style = ElementStyle.Item;
            FDM_07_Noi_Xuat_Den.Text = "Nơi Xuất Đến";
            // 
            // Nhap_Hang
            // 
            Nhap_Hang.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Nhap_Hang.Appearance.Default.Options.UseFont = true;
            Nhap_Hang.Name = "Nhap_Hang";
            Nhap_Hang.Text = "Nhập Hàng";
            // 
            // Dev_Tool
            // 
            Dev_Tool.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Dev_Tool.Appearance.Default.Options.UseFont = true;
            Dev_Tool.Elements.AddRange(new AccordionControlElement[] { Tool_Menu_Item });
            Dev_Tool.Expanded = true;
            Dev_Tool.Name = "Dev_Tool";
            Dev_Tool.Text = "Tool";
            // 
            // Tool_Menu_Item
            // 
            Tool_Menu_Item.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Tool_Menu_Item.Appearance.Default.Options.UseFont = true;
            Tool_Menu_Item.Name = "Tool_Menu_Item";
            Tool_Menu_Item.Style = ElementStyle.Item;
            Tool_Menu_Item.Text = "Menu";
            // 
            // Xuat_Hang
            // 
            Xuat_Hang.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Xuat_Hang.Appearance.Default.Options.UseFont = true;
            Xuat_Hang.Expanded = true;
            Xuat_Hang.Name = "Xuat_Hang";
            Xuat_Hang.Text = "Xuất Hàng";
            // 
            // Ton_Kho
            // 
            Ton_Kho.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Ton_Kho.Appearance.Default.Options.UseFont = true;
            Ton_Kho.Expanded = true;
            Ton_Kho.Name = "Ton_Kho";
            Ton_Kho.Text = "Tồn Kho";
            // 
            // Ca_Nhan
            // 
            Ca_Nhan.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Ca_Nhan.Appearance.Default.Options.UseFont = true;
            Ca_Nhan.Elements.AddRange(new AccordionControlElement[] { Dang_Xuat_Item });
            Ca_Nhan.Expanded = true;
            Ca_Nhan.Name = "Ca_Nhan";
            Ca_Nhan.Text = "Cá Nhân";
            // 
            // Dang_Xuat_Item
            // 
            Dang_Xuat_Item.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Dang_Xuat_Item.Appearance.Default.Options.UseFont = true;
            Dang_Xuat_Item.Name = "Dang_Xuat_Item";
            Dang_Xuat_Item.Style = ElementStyle.Item;
            Dang_Xuat_Item.Text = "Đăng xuất";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.ForeColor = System.Drawing.Color.White;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { Header, Title, Reload_Item });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1032, 39);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(Header);
            fluentDesignFormControl1.TitleItemLinks.Add(Title);
            fluentDesignFormControl1.TitleItemLinks.Add(Reload_Item);
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
            // Reload_Item
            // 
            Reload_Item.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            Reload_Item.Caption = "Reload";
            Reload_Item.Id = 9;
            Reload_Item.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Reload_Item.ImageOptions.SvgImage");
            Reload_Item.Name = "Reload_Item";
            Reload_Item.ItemClick += Reload_Item_ItemClick;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { Header, Title, Reload_Item });
            fluentFormDefaultManager1.MaxItemId = 10;
            // 
            // Container
            // 
            Container.Dock = System.Windows.Forms.DockStyle.Fill;
            Container.Location = new System.Drawing.Point(312, 39);
            Container.Name = "Container";
            Container.Size = new System.Drawing.Size(720, 434);
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
        private new FluentDesignFormContainer Container;
        private AccordionControlElement Dev_Tool;
        private AccordionControlElement Danh_Muc;
        private AccordionControlElement Danh_Muc_Quan_Tri;
        private AccordionControlElement FDM_08_Kho;
        private AccordionControlElement Danh_Muc_Co_Ban;
        private AccordionControlElement FDM_10_Chu_Hang;
        private AccordionControlElement FDM_01_Don_Vi_Tinh;
        private AccordionControlElement FDM_02_Loai_San_Pham;
        private AccordionControlElement FDM_03_San_Pham;
        private AccordionControlElement FDM_04_Day_Ke;
        private AccordionControlElement FDM_05_Vi_Tri;
        private AccordionControlElement FDM_12_Nhan_Vien_Kho;
        private AccordionControlElement FDM_06_NCC;
        private AccordionControlElement FDM_07_Noi_Xuat_Den;
        private AccordionControlElement Tool_Menu_Item;
        private AccordionControlElement FDM_09_Kho_User;
        private AccordionControlElement FDM_11_Chu_Hang_User;
        private AccordionControlElement Nhap_Hang;
        private AccordionControlElement Xuat_Hang;
        private AccordionControlElement Ton_Kho;
        private AccordionControlElement Ca_Nhan;


        private DevExpress.XtraBars.BarStaticItem Header;
        private DevExpress.XtraBars.BarStaticItem Title;
        private AccordionControlElement Dang_Xuat_Item;
        private DevExpress.XtraSplashScreen.SplashScreenManager Loading_Control;
        private DevExpress.XtraBars.BarButtonItem Reload_Item;
    }
}

