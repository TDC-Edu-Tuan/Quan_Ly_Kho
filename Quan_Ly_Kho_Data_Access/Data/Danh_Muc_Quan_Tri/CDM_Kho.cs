using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Quan_Tri
{
    public class CDM_Kho : CEntity_Base
    {
        private string m_strMa_Kho;
        private string m_strTen_Kho;
        private string m_strGhi_Chu;
        private int m_iLoai_Hinh_Kho;

        public string Ma_Kho { get => m_strMa_Kho; set => m_strMa_Kho = value.Trim(); }
        public string Ten_Kho { get => m_strTen_Kho; set => m_strTen_Kho = value.Trim(); }
        public int Loai_Hinh_Kho { get => m_iLoai_Hinh_Kho; set => m_iLoai_Hinh_Kho = value; }
        public string Ghi_Chu { get => m_strGhi_Chu; set => m_strGhi_Chu = value.Trim(); }

        public CDM_Kho()
        {
            ResetData();
        }

        public override void ResetData()
        {
            m_strMa_Kho = CConst.STR_VALUE_NULL;
            m_strTen_Kho = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_iLoai_Hinh_Kho = CConst.INT_VALUE_NULL;

            base.ResetData();
        }
    }
}
