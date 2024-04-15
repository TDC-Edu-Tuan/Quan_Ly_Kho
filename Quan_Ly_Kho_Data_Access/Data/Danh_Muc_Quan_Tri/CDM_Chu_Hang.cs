using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri
{
    public class CDM_Chu_Hang : CEntity_Base
    {
        private string m_strMa_CH;
        private string m_strTen_CH;
        private string m_strGhi_Chu;

        public string Ma_Chu_Hang { get => m_strMa_CH; set => m_strMa_CH = value.Trim(); }
        public string Ten_Chu_Hang { get => m_strTen_CH; set => m_strTen_CH = value.Trim(); }
        public string Ghi_Chu { get => m_strGhi_Chu; set => m_strGhi_Chu = value.Trim(); }

        public CDM_Chu_Hang()
        {
            ResetData();
        }

        public override void ResetData()
        {
            m_strMa_CH = CConst.STR_VALUE_NULL;
            m_strTen_CH = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            base.ResetData();
        }
    }
}
