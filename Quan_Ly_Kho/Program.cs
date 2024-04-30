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
                Application.Run(new FMain());
            }
            catch (Exception ex)
            {
                FCommonFunction.Show_Message_Box("Thông báo", ex.Message, (int)EMessage_Type.Error);
            }
        }
    }
}