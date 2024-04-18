using Quan_Ly_Kho_Common;
using Quan_Ly_Kho_Data_Access.Data.Sys;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Sys;
using System;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                CCommonFunction.Load_Config();

                CCommonFunction.Load_Cache();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FDang_Nhap());

                if (CSystem.Thanh_Vien == null)
                    Application.Exit();
                else
                    Application.Run(new FMain());


            }
            catch (Exception ex) //Nếu cache lỗi load => đóng chương trình
            {
                string v_strError_Message = ex.Message;

                DialogResult v_rs = MessageBox.Show(v_strError_Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (v_rs == DialogResult.OK || v_rs == DialogResult.Cancel)
                {
                    Application.Exit();
                }

            }

        }
    }
}