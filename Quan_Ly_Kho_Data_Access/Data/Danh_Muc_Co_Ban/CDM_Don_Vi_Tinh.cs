using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban
{
    public class CDM_Don_Vi_Tinh : CEntity_Base
    {
        private string m_strTen_Don_Vi_Tinh;
        private string m_strGhi_Chu;

        public CDM_Don_Vi_Tinh()
        {
            ResetData();
        }

        public string Ten_Don_Vi_Tinh { get => m_strTen_Don_Vi_Tinh; set => m_strTen_Don_Vi_Tinh = value.Trim(); }
        public string Ghi_Chu { get => m_strGhi_Chu; set => m_strGhi_Chu = value.Trim(); }

        public override void ResetData()
        {
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;

            base.ResetData();
        }
    }
}
