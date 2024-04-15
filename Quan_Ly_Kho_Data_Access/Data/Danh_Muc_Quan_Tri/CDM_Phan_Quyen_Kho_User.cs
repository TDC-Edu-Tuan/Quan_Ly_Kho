using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri
{
    public class CDM_Phan_Quyen_Kho_User : CEntity_Base
    {
        private long m_lngThanh_Vien_ID;
        private long m_lngKho_ID;

        public long Thanh_Vien_ID { get => m_lngThanh_Vien_ID; set => m_lngThanh_Vien_ID = value; }
        public long Kho_ID { get => m_lngKho_ID; set => m_lngKho_ID = value; }

        public CDM_Phan_Quyen_Kho_User()
        {
            ResetData();
        }

        public override void ResetData()
        {
            m_lngThanh_Vien_ID = CConst.INT_VALUE_NULL;
            m_lngKho_ID = CConst.INT_VALUE_NULL;

            base.ResetData();
        }
    }
}
