using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data.Sys
{
    public class CSys_Thanh_Vien : CEntity_Base
    {
        private string m_strMa_Dang_Nhap;
        private string m_strMat_Khau;
        private string m_strHo_Ten;
        private string m_strEmail;
        private string m_strSDT;
        private string m_strGioi_Tinh;

        public CSys_Thanh_Vien()
        {
            ResetData();
        }

        public string Ma_Dang_Nhap { get => m_strMa_Dang_Nhap; set => m_strMa_Dang_Nhap = value.Trim(); }
        public string Mat_Khau { get => m_strMat_Khau; set => m_strMat_Khau = value.Trim(); }
        public string Ho_Ten { get => m_strHo_Ten; set => m_strHo_Ten = value.Trim(); }
        public string Email { get => m_strEmail; set => m_strEmail = value.Trim(); }
        public string SDT { get => m_strSDT; set => m_strSDT = value.Trim(); }
        public string Gioi_Tinh { get => m_strGioi_Tinh; set => m_strGioi_Tinh = value.Trim(); }

        public override void ResetData()
        {
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_strMat_Khau = CConst.STR_VALUE_NULL;
            m_strHo_Ten = CConst.STR_VALUE_NULL;
            m_strEmail = CConst.STR_VALUE_NULL;
            m_strSDT = CConst.STR_VALUE_NULL;
            m_strGioi_Tinh = CConst.STR_VALUE_NULL;


            base.ResetData();
        }
    }
}
