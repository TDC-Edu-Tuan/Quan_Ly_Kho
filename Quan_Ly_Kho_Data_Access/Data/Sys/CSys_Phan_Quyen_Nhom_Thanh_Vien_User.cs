using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Sys
{
    public class CSys_Phan_Quyen_Nhom_Thanh_Vien_User : CEntity_Base
    {
        private long m_lngThanh_Vien_ID;
        private long m_lngNhom_Thanh_Vien_ID;

        public long Thanh_Vien_ID { get => m_lngThanh_Vien_ID; set => m_lngThanh_Vien_ID = value; }
        public long Nhom_Thanh_Vien_ID { get => m_lngNhom_Thanh_Vien_ID; set => m_lngNhom_Thanh_Vien_ID = value; }

        public CSys_Phan_Quyen_Nhom_Thanh_Vien_User()
        {
            ResetData();
        }

        public override void ResetData()
        {
            m_lngThanh_Vien_ID = CConst.INT_VALUE_NULL;
            m_lngNhom_Thanh_Vien_ID = CConst.INT_VALUE_NULL;

            base.ResetData();
        }
    }
}
