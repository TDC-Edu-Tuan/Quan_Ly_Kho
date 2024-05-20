using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban
{
    public class CDM_NCC
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private string m_strMa_NCC;
        private string m_strTen_NCC;
        private string m_strDia_Chi;
        private string m_strDien_Thoai;
        private string m_strEmail;
        private string m_strGhi_Chu;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public CDM_NCC()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_strMa_NCC = CConst.STR_VALUE_NULL;
            m_strTen_NCC = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;
            m_strDien_Thoai = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

            m_strEmail = CConst.STR_VALUE_NULL;
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

        public long Chu_Hang_ID
        {
            get
            {
                return m_lngChu_Hang_ID;
            }
            set
            {
                m_lngChu_Hang_ID = value;
            }
        }

        public string Ma_NCC
        {
            get
            {
                return m_strMa_NCC;
            }
            set
            {
                m_strMa_NCC = value.Trim();
            }
        }

        public string Ten_NCC
        {
            get
            {
                return m_strTen_NCC;
            }
            set
            {
                m_strTen_NCC = value.Trim();
            }
        }

        public string Dia_Chi
        {
            get
            {
                return m_strDia_Chi;
            }
            set
            {
                m_strDia_Chi = value.Trim();
            }
        }

        public string Dien_Thoai
        {
            get
            {
                return m_strDien_Thoai;
            }
            set
            {
                m_strDien_Thoai = value.Trim();
            }
        }

        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
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

        public string NCC_Combo
        {
            get
            {
                return CUtility.Tao_Combo_Text(m_strMa_NCC, m_strTen_NCC);
            }
        }

        public string Email { get => m_strEmail; set => m_strEmail = value.Trim(); }
    }
}
