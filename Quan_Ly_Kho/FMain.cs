using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraVerticalGrid.Native;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Danh_Muc;
using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public CSys_Thanh_Vien Thanh_Vien { get; set; } = CSystem.Thanh_Vien;
        private List<CDM_Kho_User> m_arrKho_User = new();
        private List<CDM_Chu_Hang_User> m_arrCH_User = new();

        public FMain()
        {
            InitializeComponent();


        }

        private void FMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Load cây chức năng
                Load_Cay_Chuc_Nang_By_Nhom_Thanh_Vien(Thanh_Vien.Nhom_Thanh_Vien_ID);

                //Load kho - user
                m_arrKho_User = CCache_Kho_User.List_Data_By_Thanh_Vien_ID(Thanh_Vien.Auto_ID);

                m_arrCH_User = CCache_Chu_Hang_User.List_Data_By_Thanh_Vien_ID(Thanh_Vien.Auto_ID);

                if ((m_arrKho_User.Count == 0 || m_arrCH_User.Count == 0))
                {
                    FCommonFunction.Show_Alert(alert, this, "Thông báo", "Bạn không có quyền thực hiện thao tác này");
                    return;
                }

                //Load combo

                FCommonFunction.Load_Combo(cbbKho_User, m_arrKho_User, "Kho_ID", "Kho_Combo");

                FCommonFunction.Load_Combo(cbbChu_Hang_User, m_arrCH_User, "Chu_Hang_ID", "Chu_Hang_Combo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Cay_Chuc_Nang_By_Nhom_Thanh_Vien(long p_lngNhom_Thanh_Vien)
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


            Menu.Elements.Clear(); //Xóa đi menu cũ

            foreach (AccordionControlElement v_objItem in v_arrChuc_Nang)
                Menu.Elements.Add(v_objItem);
        }

        private void Load_User_Control(UCBase p_usControl, string v_strFunction_Code, string p_strFunction_Name)
        {
            if (p_usControl != null)
            {
                p_usControl.User_Name = Thanh_Vien.Ma_Dang_Nhap;
                Container_Control.Controls.Add(p_usControl);
                p_usControl.Function_Code = v_strFunction_Code + "Click";
                Title.Caption = CUtility.Tao_Combo_Text(p_strFunction_Name, v_strFunction_Code);
            }
        }

        /// <summary>
        /// Set disable double click in title bar
        /// </summary>
        /// <param name="m"></param>
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

        #region Tool
        private void Load_Quan_Tri(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Danh_Muc);
            p_arrChuc_Nang.Add(Nhap_Hang);
            p_arrChuc_Nang.Add(Ton_Kho);
            p_arrChuc_Nang.Add(Dev_Tool);
            p_arrChuc_Nang.Add(Xuat_Hang);
            p_arrChuc_Nang.Add(Ca_Nhan);
        }

        private void Load_Xuat_Kho(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Danh_Muc);
            //p_arrChuc_Nang.Add(Load_Nhap_Hang()); Tắt nhập hàng
            p_arrChuc_Nang.Add(Ton_Kho);
            // p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            p_arrChuc_Nang.Add(Xuat_Hang);
            p_arrChuc_Nang.Add(Ca_Nhan);
        }

        private void Load_Nhap_Hang(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Danh_Muc);
            p_arrChuc_Nang.Add(Nhap_Hang);
            p_arrChuc_Nang.Add(Ton_Kho);
            // p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            // p_arrChuc_Nang.Add(Load_Xuat_Hang()); Tắt Xuất hàng
            p_arrChuc_Nang.Add(Ca_Nhan);
        }

        private void Load_Data(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Danh_Muc);
            //p_arrChuc_Nang.Add(Load_Nhap_Hang()); Tắt nhập hàng
            p_arrChuc_Nang.Add(Ton_Kho);
            //p_arrChuc_Nang.Add(Load_Dev_Tool()); Tắt dev tool
            //p_arrChuc_Nang.Add(Load_Xuat_Hang()); Tắt Xuất hàng
            p_arrChuc_Nang.Add(Ca_Nhan);
        }

        private void Load_Dev(List<AccordionControlElement> p_arrChuc_Nang)
        {
            p_arrChuc_Nang.Add(Danh_Muc);
            // p_arrChuc_Nang.Add(Nhap_Hang);
            p_arrChuc_Nang.Add(Ton_Kho);
            p_arrChuc_Nang.Add(Dev_Tool);
            //  p_arrChuc_Nang.Add(Xuat_Hang);
            p_arrChuc_Nang.Add(Ca_Nhan);
        }
        #endregion End tool

        #region Event
        private void Item_Click(object p_objSender, EventArgs p_objEvent_Key)
        {
            AccordionControlElement v_objClicked = p_objSender as AccordionControlElement;

            if (v_objClicked != null)
            {
                UCBase v_objUS_Base = new();

                string v_strFunction_Code = v_objClicked.Name;
                string v_strFunction_Name = v_objClicked.Text;

                switch (v_strFunction_Code)
                {
                    case "Danh_Muc_Don_Vi_Tinh_Item":
                        v_objUS_Base = new uc_DM_Don_Vi_Tinh_List();
                        break;
                    case "Danh_Muc_Loai_San_Pham_Item":
                        v_objUS_Base = new uc_DM_Loai_San_Pham_List();
                        break;
                }

                //Load control
                Load_User_Control(v_objUS_Base, v_strFunction_Code, v_strFunction_Name);
            }

        }
        #endregion end event
    }
}
