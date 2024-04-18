using Quan_Ly_Kho_Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Sys
{
    public class CSystem
    {
        private static CSys_Thanh_Vien m_objThanh_Vien = null;

        public static CSys_Thanh_Vien Thanh_Vien { get => m_objThanh_Vien; set => m_objThanh_Vien = value; }
    }
}
