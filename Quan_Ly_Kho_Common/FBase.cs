using DevExpress.Map.Kml.Model;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using Quan_Ly_Kho_Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Common
{
    //Đây là lớp kế thừa nơi thực hiện các control
    public partial class FBase : FluentDesignForm
    {
        private List<CDM_Kho_User> m_arrKho_User = new();
        private List<CDM_Chu_Hang_User> m_arrCH_User = new();

        protected long Auto_ID { get; set; } = 0;

        protected string Ma_Dang_Nhap { get; set; } = "";

        protected string Function_Code { get; set; } = "";

        protected long Thanh_Vien_ID { get; set; } = 0;

        protected AccordionControl Accordion_Control { get; set; } = null;

        protected FluentDesignFormContainer Container_Control { get; set; } = null;

        protected BarStaticItem Bar_Static_Item { get; set; } = null;

        protected virtual void Load_Form(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();

                //Get thành viên
                CSys_Thanh_Vien v_objTV = CSystem.Thanh_Vien;
                if (v_objTV != null)
                {
                    Thanh_Vien_ID = v_objTV.Auto_ID;
                    Ma_Dang_Nhap = v_objTV.Ma_Dang_Nhap;
                }

                //Load chức năng by nhóm thành viên
                Load_Cay_Chuc_Nang_By_Nhom_Thanh_Vien(v_objTV.Nhom_Thanh_Vien_ID, Accordion_Control);

                //Load chủ hàng - user với kho - user
                m_arrKho_User = CCache_Kho_User.List_Data_By_Thanh_Vien_ID(Thanh_Vien_ID);

                m_arrCH_User = CCache_Chu_Hang_User.List_Data_By_Thanh_Vien_ID(Thanh_Vien_ID);

                if ((m_arrKho_User.Count == CConst.INT_VALUE_NULL || m_arrCH_User.Count == CConst.INT_VALUE_NULL) && Thanh_Vien_ID != 0)
                    throw new Exception("Bạn không có quyền thao tác.");


                ResumeLayout(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if ((m_arrKho_User.Count == CConst.INT_VALUE_NULL || m_arrCH_User.Count == CConst.INT_VALUE_NULL) && Thanh_Vien_ID != 0)
                    Application.Exit();

            }
        }



        public void Load_Cay_Chuc_Nang_By_Nhom_Thanh_Vien(long p_lngNhom_Thanh_Vien, AccordionControl p_objMenu)
        {
            List<AccordionControlElement> v_arrChuc_Nang = new();
            switch (p_lngNhom_Thanh_Vien)
            {
                case (int)ENhom_Thanh_Vien.Quan_Tri:
                    Load_Quan_Tri(v_arrChuc_Nang);
                    break;
                case (int)ENhom_Thanh_Vien.Xuat_Kho:
                    Load_Xuat_Kho(v_arrChuc_Nang);
                    break;
                case (int)ENhom_Thanh_Vien.Nhap_Hang:
                    Load_Nhap_Hang(v_arrChuc_Nang);
                    break;
                case (int)ENhom_Thanh_Vien.Data:
                    Load_Data(v_arrChuc_Nang);
                    break;
                case (int)ENhom_Thanh_Vien.Dev:
                    Load_Dev(v_arrChuc_Nang);
                    break;
            }

            //Thêm sự kiện cho mỗi phần tử
            foreach (AccordionControlElement v_cn in v_arrChuc_Nang)
            {
                v_cn.Click += Item_Click;
            }

            p_objMenu.Elements.AddRange(v_arrChuc_Nang.ToArray());
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

    }

    //Đây là nơi khai báo
    partial class FBase
    {
        private AccordionControlElement Danh_Muc = new();
        private AccordionControlElement Danh_Muc_Quan_Tri = new();
        private AccordionControlElement Danh_Muc_Kho_Item = new();
        private AccordionControlElement Danh_Muc_Kho_User_Item = new();
        private AccordionControlElement Danh_Muc_Chu_Hang_Item = new();
        private AccordionControlElement Danh_Muc_Chu_Hang_User = new();
        private AccordionControlElement Danh_Muc_Nhan_Vien_Item = new();
        private AccordionControlElement Danh_Muc_Co_Ban = new();
        private AccordionControlElement Danh_Muc_Don_Vi_Tinh_Item = new();
        private AccordionControlElement Danh_Muc_Loai_San_Pham_Item = new();
        private AccordionControlElement Danh_Muc_San_Pham_Item = new();
        private AccordionControlElement Danh_Muc_Ke_Item = new();
        private AccordionControlElement Danh_Muc_Vi_Tri_Item = new();
        private AccordionControlElement Danh_Muc_NCC_Item = new();
        private AccordionControlElement Danh_Muc_Noi_Xuat_Den_Item = new();
        private AccordionControlElement Nhap_Hang = new();
        private AccordionControlElement Dev_Tool = new();
        private AccordionControlElement Tool_Menu_Item = new();
        private AccordionControlElement Xuat_Hang = new();
        private AccordionControlElement Ton_Kho = new();
        private AccordionControlElement Ca_Nhan = new();

        private void Load_Quan_Tri(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Load_Danh_Muc());
            p_arrChuc_Nang.Add(Load_Nhap_Hang());
            p_arrChuc_Nang.Add(Load_Ton_Kho());
            p_arrChuc_Nang.Add(Load_Dev_Tool());
            p_arrChuc_Nang.Add(Load_Xuat_Hang());
            p_arrChuc_Nang.Add(Load_Ca_Nhan());
        }

        private void Load_Xuat_Kho(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Load_Danh_Muc());
            //p_arrChuc_Nang.Add(Load_Nhap_Hang()); Tắt nhập hàng
            p_arrChuc_Nang.Add(Load_Ton_Kho());
            // p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            p_arrChuc_Nang.Add(Load_Xuat_Hang());
            p_arrChuc_Nang.Add(Load_Ca_Nhan());
        }

        private void Load_Nhap_Hang(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Load_Danh_Muc());
            p_arrChuc_Nang.Add(Load_Nhap_Hang());
            p_arrChuc_Nang.Add(Load_Ton_Kho());
            // p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            // p_arrChuc_Nang.Add(Load_Xuat_Hang()); Tắt Xuất hàng
            p_arrChuc_Nang.Add(Load_Ca_Nhan());
        }

        private void Load_Data(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Load_Danh_Muc());
            //p_arrChuc_Nang.Add(Load_Nhap_Hang()); Tắt nhập hàng
            p_arrChuc_Nang.Add(Load_Ton_Kho());
            //p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            //p_arrChuc_Nang.Add(Load_Xuat_Hang()); Tắt Xuất hàng
            p_arrChuc_Nang.Add(Load_Ca_Nhan());
        }

        private void Load_Dev(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Load_Danh_Muc());
            p_arrChuc_Nang.Add(Load_Nhap_Hang());
            p_arrChuc_Nang.Add(Load_Ton_Kho());
            p_arrChuc_Nang.Add(Load_Dev_Tool());
            p_arrChuc_Nang.Add(Load_Xuat_Hang());
            p_arrChuc_Nang.Add(Load_Ca_Nhan());
        }

        private AccordionControlElement Load_Danh_Muc()
        {
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
            Danh_Muc_Don_Vi_Tinh_Item.Click += Item_Click;
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

            return Danh_Muc;
        }

        private AccordionControlElement Load_Nhap_Hang()
        {
            // 
            // Nhap_Hang
            // 
            Nhap_Hang.Name = "Nhap_Hang";
            Nhap_Hang.Text = "Nhập Hàng";

            return Nhap_Hang;
        }

        private AccordionControlElement Load_Ton_Kho()
        {
            // 
            // Ton_Kho
            // 
            Ton_Kho.Name = "Ton_Kho";
            Ton_Kho.Text = "Tồn Kho";

            return Ton_Kho;
        }

        private AccordionControlElement Load_Dev_Tool()
        {
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

            return Dev_Tool;
        }

        private AccordionControlElement Load_Xuat_Hang()
        {
            // 
            // Xuat_Hang
            // 
            Xuat_Hang.Name = "Xuat_Hang";
            Xuat_Hang.Text = "Xuất Hàng";

            return Xuat_Hang;
        }

        private AccordionControlElement Load_Ca_Nhan()
        {
            // 
            // Ca_Nhan
            // 
            Ca_Nhan.Expanded = true;
            Ca_Nhan.Name = "Ca_Nhan";
            Ca_Nhan.Text = "Cá Nhân";

            return Ca_Nhan;
        }


        private void Item_Click(object? sender, EventArgs e)
        {
            // Chuyển sender thành AccordionControlElement để truy cập thuộc tính Name
            AccordionControlElement v_objClicked_Control = sender as AccordionControlElement;

            if (v_objClicked_Control != null)
            {
                Function_Code = v_objClicked_Control.Name;
            }

            Container_Control.Dock = DockStyle.Fill;

            switch (Function_Code)
            {
                case "Danh_Muc_Don_Vi_Tinh_Item":
                    Container_Control.Controls.Add(new uc_DM_Don_Vi_Tinh_List());
                    Bar_Static_Item.Caption = v_objClicked_Control.Text;
                    break;
            }

            Container_Control.BringToFront();
        }

    }
}
