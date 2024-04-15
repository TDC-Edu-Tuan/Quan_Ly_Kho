using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri
{
    public class CDM_Phan_Quyen_Chu_Hang_User : CEntity_Base
    {
        private long m_lngThanh_Vien_ID;
        private long m_lngChu_Hang_ID;

        public long Thanh_Vien_ID { get => m_lngThanh_Vien_ID; set => m_lngThanh_Vien_ID = value; }
        public long Chu_Hang_ID { get => m_lngChu_Hang_ID; set => m_lngChu_Hang_ID = value; }

        public CDM_Phan_Quyen_Chu_Hang_User()
        {
            ResetData();
        }

        public override void ResetData()
        {
            m_lngThanh_Vien_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;

            base.ResetData();
        }
    }
}
