using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using Quan_Ly_Kho_Data_Access.Utility;
using Quan_Ly_Kho_Data_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Common
{
    public class FBase : Form
    {
        public static void Load_Chuc_Nang_By_Nhom_Thanh_Vien_ID(long[] p_arrNhom_Thanh_Vien_ID)
        {
            //
            Dictionary<long, List<CSys_Phan_Quyen_Chuc_Nang>> v_dicChuc_Nang = new();

            foreach (long v_iNhom_Thanh_Vien in p_arrNhom_Thanh_Vien_ID)
            {
                //Get danh sách chức nagnw by nhóm thành viên
                List<CSys_Phan_Quyen_Chuc_Nang> v_arrChuc_Nang = new();

                v_arrChuc_Nang = CCache_Phan_Quyen_Chuc_Nang.List_Chuc_Nang_By_Nhom_Thanh_Vien_ID(v_iNhom_Thanh_Vien);

                v_dicChuc_Nang.Add(v_iNhom_Thanh_Vien, v_arrChuc_Nang);
            }

        }
    }
}
