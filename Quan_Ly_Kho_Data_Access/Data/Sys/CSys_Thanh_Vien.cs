using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Data.Sys
{
    public class CSys_Thanh_Vien
    {
        private long m_lngAuto_ID;
        private string m_strMa_Dang_Nhap;
        private string m_strMat_Khau;
        private string m_strHo_Ten;
        private string m_strEmail;
        private string m_strSDT;
        private string m_strGioi_Tinh;
        private int m_iNhom_Thanh_Vien_ID;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public CSys_Thanh_Vien()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_strMat_Khau = CConst.STR_VALUE_NULL;
            m_strHo_Ten = CConst.STR_VALUE_NULL;
            m_strEmail = CConst.STR_VALUE_NULL;
            m_strSDT = CConst.STR_VALUE_NULL;
            m_strGioi_Tinh = CConst.STR_VALUE_NULL;
            m_iNhom_Thanh_Vien_ID = CConst.INT_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }

        public long Auto_ID
        {
            get
            {
                return m_lngAuto_ID;
            }
            set
            {
                m_lngAuto_ID = value;
            }
        }

        public string Ma_Dang_Nhap
        {
            get
            {
                return m_strMa_Dang_Nhap;
            }
            set
            {
                m_strMa_Dang_Nhap = value.Trim();
            }
        }

        public string Mat_Khau
        {
            get
            {
                return m_strMat_Khau;
            }
            set
            {
                m_strMat_Khau = value.Trim();
            }
        }

        public string Ho_Ten
        {
            get
            {
                return m_strHo_Ten;
            }
            set
            {
                m_strHo_Ten = value.Trim();
            }
        }

        public string Email
        {
            get
            {
                return m_strEmail;
            }
            set
            {
                m_strEmail = value.Trim();
            }
        }

        public string SDT
        {
            get
            {
                return m_strSDT;
            }
            set
            {
                m_strSDT = value.Trim();
            }
        }

        public string Gioi_Tinh
        {
            get
            {
                return m_strGioi_Tinh;
            }
            set
            {
                m_strGioi_Tinh = value.Trim();
            }
        }

        public int deleted
        {
            get
            {
                return m_intdeleted;
            }
            set
            {
                m_intdeleted = value;
            }
        }

        public DateTime? Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public string Created_By_Function
        {
            get
            {
                return m_strCreated_By_Function;
            }
            set
            {
                m_strCreated_By_Function = value.Trim();
            }
        }

        public DateTime? Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

        public string Last_Updated_By_Function
        {
            get
            {
                return m_strLast_Updated_By_Function;
            }
            set
            {
                m_strLast_Updated_By_Function = value.Trim();
            }
        }

        public int Nhom_Thanh_Vien_ID
        {
            get
            {
                return m_iNhom_Thanh_Vien_ID;
            }
            set
            {
                m_iNhom_Thanh_Vien_ID = value;
            }
        }

        public string Nhom_Thanh_Vien_Text
        {
            get
            {
                string v_strRes = CConst.STR_VALUE_NULL;
                switch (m_iNhom_Thanh_Vien_ID)
                {
                    case (int)ENhom_Thanh_Vien.Quan_Tri:
                        v_strRes = "Quản Trị"; break;
                    case (int)ENhom_Thanh_Vien.Xuat_Kho:
                        v_strRes = "Xuất Kho"; break;
                    case (int)ENhom_Thanh_Vien.Nhap_Hang:
                        v_strRes = "Nhập Hàng"; break;
                    case (int)ENhom_Thanh_Vien.Data:
                        v_strRes = "Data"; break;
                }
                return v_strRes;
            }
        }
    }
}
