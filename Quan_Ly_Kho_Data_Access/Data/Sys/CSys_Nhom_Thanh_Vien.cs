using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Sys
{
    public class CSys_Nhom_Thanh_Vien : CEntity_Base
    {
        private string m_strTen_Nhom_Thanh_Vien;
        private string m_strGhi_Chu;

        public CSys_Nhom_Thanh_Vien()
        {
            ResetData();
        }

        public string Ten_Nhom_Thanh_Vien { get => m_strTen_Nhom_Thanh_Vien; set => m_strTen_Nhom_Thanh_Vien = value.Trim(); }
        public string Ghi_Chu { get => m_strGhi_Chu; set => m_strGhi_Chu = value.Trim(); }

        public override void ResetData()
        {
            m_strTen_Nhom_Thanh_Vien = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;

            base.ResetData();
        }
    }
}
