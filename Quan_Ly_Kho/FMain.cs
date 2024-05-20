using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_DM;
using Quan_Ly_Kho_Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Quan_Ly_Kho
{
    public partial class FMain : FluentDesignForm
    {
        private List<CDM_Kho_User> m_arrKho_User = new();
        private List<CDM_Chu_Hang_User> m_arrCH_User = new();
        private CSys_Thanh_Vien m_objThanh_Vien = new();
        private bool m_bIs_First_Load = false;

        public FMain()
        {
            InitializeComponent();
            // Chuyển đổi mã màu hex thành màu Color
            // Đặt màu nền cho Fluent Design Form
            this.BackColor = ColorTranslator.FromHtml("#6edada");
            // Đặt màu nền cho Fluent Design FormControl
            fluentDesignFormControl1.BackColor = ColorTranslator.FromHtml("#6edada");

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            DateTime v_dtmStart = DateTime.Now;
            do
            {
                try
                {
                    //Clear
                    Container.Controls.Clear();

                    //ẩn đi
                    if (CSystem.State != (int)EStatus_Type.Success)
                        Hide();

                    // Kiểm tra trạng thái đăng nhập
                    if (CSystem.State != (int)EStatus_Type.Success)
                    {
                        FDang_Nhap v_frmDang_Nhap = new FDang_Nhap();
                        v_frmDang_Nhap.ShowDialog();

                        // Kiểm tra nếu người dùng đã thoát form đăng nhập
                        if (CSystem.State == (int)EStatus_Type.Closed)
                        {
                            Close();
                            return;
                        }
                    }

                    //Dừng khoản 5s
                    Loading_Control.ShowWaitForm();

                    // Load dữ liệu và các tác vụ khởi động ở đây
                    m_objThanh_Vien = CSystem.Thanh_Vien; // Set thành viên để xử lý

                    // Load cây chức năng
                    Load_Cay_Chuc_Nang_By_Nhom_Thanh_Vien(m_objThanh_Vien.Nhom_Thanh_Vien_ID);

                    // Load kho, chủ hàng - User
                    m_arrKho_User = CCache_Kho_User.List_Data_By_Thanh_Vien_ID(m_objThanh_Vien.Auto_ID);
                    m_arrCH_User = CCache_Chu_Hang_User.List_Data_By_Thanh_Vien_ID(m_objThanh_Vien.Auto_ID);

                    // Nếu người dùng không được phân quyền vào kho hoặc chủ hàng thì không cho sử dụng ứng dụng
                    if ((m_arrKho_User.Count == 0 || m_arrCH_User.Count == 0) && m_objThanh_Vien.Ma_Dang_Nhap.ToLower() != "admin")
                    {
                        CSystem.Thanh_Vien = null;

                        CSystem.State = (int)EStatus_Type.Closed_And_Reload; // Đặt state

                        throw new Exception("Bạn không có quyền sử dụng chức năng này.");
                    }

                    // Đặt state
                    CSystem.State = (int)EStatus_Type.Success;

                    // Xóa các control
                    Container.Controls.Clear();
                    Title.Caption = "";

                    Thread.Sleep(5000); //Chờ 5s

                    //Dừng khoản 5s
                    Loading_Control.CloseWaitForm();

                    // Hiển thị lại form chính
                    if (CSystem.State == (int)EStatus_Type.Success)
                        Show();

                    m_bIs_First_Load = true;
                }
                catch (Exception ex)
                {
                    TimeSpan v_span = DateTime.Now - v_dtmStart;
                    FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
                    CLogger.Save_Trace_Error_Log("System", "Load", "Main Load", ex.Message, v_span.TotalSeconds);

                    Loading_Control.CloseWaitForm();

                }

            } while (CSystem.State == (int)EStatus_Type.Closed_And_Reload); // Nếu người dùng rơi vào lỗi khác lỗi đóng thì cho phép đăng nhập lại
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

            }


            //Kiểm tra nếu là lần đăng nhập là 2 lần trở lên thì clear sự kiện click cũ đi
            if (m_bIs_First_Load == true)
            {
                foreach (AccordionControlElement v_objItems_1 in v_arrChuc_Nang)//Menu C1
                {
                    //Kiểm tra nếu Có menu C2
                    if (v_objItems_1.Elements.Count > 0)
                    {
                        foreach (AccordionControlElement v_objItems_2 in v_objItems_1.Elements) //Menu C2
                        {
                            //Kiểm tra nếu Có menu C3
                            if (v_objItems_2.Elements.Count > 0)
                                foreach (AccordionControlElement v_objItem_3 in v_objItems_2.Elements)// Menu C3                            
                                    v_objItem_3.Click -= Item_Click;
                            else
                                v_objItems_2.Click -= Item_Click;
                        }
                    }
                    else
                        v_objItems_1.Click -= Item_Click;
                }
            }

            Menu.Elements.Clear(); // Xóa đi menu cũ
            ((ISupportInitialize)Menu).BeginInit();
            SuspendLayout();
            foreach (AccordionControlElement v_objItems_1 in v_arrChuc_Nang)//Menu C1
            {
                //Kiểm tra nếu Có menu C2
                if (v_objItems_1.Elements.Count > 0)
                {
                    foreach (AccordionControlElement v_objItems_2 in v_objItems_1.Elements) //Menu C2
                    {
                        //Kiểm tra nếu Có menu C3
                        if (v_objItems_2.Elements.Count > 0)
                            foreach (AccordionControlElement v_objItem_3 in v_objItems_2.Elements)// Menu C3                            
                                v_objItem_3.Click += Item_Click;
                        else
                            v_objItems_2.Click += Item_Click;
                    }
                }
                else
                    v_objItems_1.Click += Item_Click;

                Menu.Elements.Add(v_objItems_1);
            }
            ((ISupportInitialize)Menu).EndInit();
            ResumeLayout(false); // Resume layout để áp dụng các thay đổi giao diện người dùng

        }

        private void Load_User_Control(UCBase p_usControl, string p_strActive_User_Name, string p_strFunction_Code, string p_strFunction_Name)
        {
            if (p_usControl != null)
            {
                Container.Controls.Clear();
                p_usControl.User_Name = p_strActive_User_Name;
                p_usControl.g_arrChu_Hang_Users = m_arrCH_User.ToList();
                p_usControl.g_arrKho_Users = m_arrKho_User.ToList();

                if (m_arrKho_User.Count != CConst.INT_VALUE_NULL)
                {
                    p_usControl.g_lngKho_ID = m_arrKho_User.FirstOrDefault(it => it.Thanh_Vien_ID == m_objThanh_Vien.Auto_ID).Kho_ID;
                }

                if (m_arrCH_User.Count != CConst.INT_VALUE_NULL)
                {
                    p_usControl.g_lngChu_Hang_ID = m_arrCH_User.FirstOrDefault(it => it.Thanh_Vien_ID == m_objThanh_Vien.Auto_ID).Chu_Hang_ID;
                }

                p_usControl.Dock = DockStyle.Fill;
                Container.Controls.Add(p_usControl);
                p_usControl.Function_Code = p_strFunction_Code;
                Title.Caption = CUtility.Tao_Combo_Text(p_strFunction_Name, p_strFunction_Code);
                Container.BringToFront();
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
            p_arrChuc_Nang.Add(Tool_Quan_Tri);
            p_arrChuc_Nang.Add(Ton_Kho);
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

                //Nếu không khai báo mã chức năng thì đóng mẹ nó đi
                if (v_strFunction_Code == CConst.STR_VALUE_NULL)
                    return;

                switch (v_strFunction_Code)
                {
                    #region Danh mục
                    case "FDM_01_Don_Vi_Tinh":
                        v_objUS_Base = new FDM_01_01_Don_Vi_Tinh_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_02_Loai_San_Pham":
                        v_objUS_Base = new FDM_02_01_Loai_San_Pham_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_03_San_Pham":
                        v_objUS_Base = new FDM_03_01_San_Pham_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_04_Day_Ke":
                        v_objUS_Base = new FDM_04_01_Day_Ke_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_05_Vi_Tri":
                        v_objUS_Base = new FDM_05_01_Vi_Tri_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_06_NCC":
                        v_objUS_Base = new FDM_06_01_NCC_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_07_Noi_Xuat_Den":
                        v_objUS_Base = new FDM_07_01_Noi_Xuat_Den_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_08_Kho":
                        v_objUS_Base = new FDM_08_01_Kho_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_09_Kho_User":
                        v_objUS_Base = new FDM_09_01_Kho_User_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_10_Chu_Hang":
                        v_objUS_Base = new FDM_10_01_Chu_Hang_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_11_Chu_Hang_User":
                        v_objUS_Base = new FDM_11_01_Chu_Hang_User_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FDM_12_Nhan_Vien_Kho":
                        v_objUS_Base = new FDM_12_01_Nhan_Vien_Kho_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    #endregion

                    #region Nhập Kho
                    case "FXNK_001_Ke_Hoach_Nhap":
                        v_objUS_Base = new FXNK_001_01_Ke_Hoach_Nhap_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    case "FXNK_002_Quan_Ly_NK":
                        v_objUS_Base = new FXNK_002_01_Quan_Ly_Nhap_Kho_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;

                    #endregion

                    #region Tồn Kho
                    case "FXNK_001_Vi_Tri_Co_Hang":
                        v_objUS_Base = new FXNK_001_01_Vi_Tri_Co_Hang();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    #endregion

                    #region Sys
                    case "FSys_001_Thanh_Vien":
                        v_objUS_Base = new FSys_001_01_Thanh_Vien_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;

                    case "FSys_002_Frozen_Column":
                        v_objUS_Base = new FSys_002_01_Frozen_Column_List();
                        CSystem.State = (int)EStatus_Type.New;
                        break;
                    #endregion

                    #region Tool
                    case "Dang_Xuat_Item":
                        CSystem.State = (int)EStatus_Type.Closed_And_Reload;
                        break;
                        #endregion
                }
                //Load control
                switch (CSystem.State)
                {
                    case (int)EStatus_Type.New:
                        Load_User_Control(v_objUS_Base, m_objThanh_Vien.Ma_Dang_Nhap, v_strFunction_Code, v_strFunction_Name);
                        break;

                    case (int)EStatus_Type.Closed_And_Reload:
                        FMain_Load(p_objSender, p_objEvent_Key);
                        break;

                }
            }

        }

        private void Reload_Item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CSystem.State = (int)EStatus_Type.Success;
            CCommonFunction.Load_Cache();
            FMain_Load(sender, e);
        }

        #endregion end event

    }
}
