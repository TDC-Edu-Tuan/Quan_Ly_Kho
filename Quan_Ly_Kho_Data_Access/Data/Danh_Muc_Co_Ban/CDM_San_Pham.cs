using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban
{
    public class CDM_San_Pham
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private long m_lngDVT_ID;
        private string m_strTen_Don_Vi_Tinh;
        private long m_lngLSP_ID;
        private string m_strMa_LSP;
        private string m_strTen_LSP;
        private string m_strMa_SP;
        private string m_strTen_SP;
        private string m_strGhi_Chu;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public CDM_San_Pham()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_lngDVT_ID = CConst.INT_VALUE_NULL;
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_lngLSP_ID = CConst.INT_VALUE_NULL;
            m_strMa_LSP = CConst.STR_VALUE_NULL;
            m_strTen_LSP = CConst.STR_VALUE_NULL;
            m_strMa_SP = CConst.STR_VALUE_NULL;
            m_strTen_SP = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
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
            get { return m_lngAuto_ID; }
            set { m_lngAuto_ID = value; }
        }

        public long Chu_Hang_ID
        {
            get { return m_lngChu_Hang_ID; }
            set { m_lngChu_Hang_ID = value; }
        }

        public long DVT_ID
        {
            get { return m_lngDVT_ID; }
            set { m_lngDVT_ID = value; }
        }

        public string Ten_Don_Vi_Tinh
        {
            get { return m_strTen_Don_Vi_Tinh; }
            set { m_strTen_Don_Vi_Tinh = value.Trim(); }
        }

        public long LSP_ID
        {
            get { return m_lngLSP_ID; }
            set { m_lngLSP_ID = value; }
        }

        public string Ma_LSP
        {
            get { return m_strMa_LSP; }
            set { m_strMa_LSP = value.Trim(); }
        }

        public string Ten_LSP
        {
            get { return m_strTen_LSP; }
            set { m_strTen_LSP = value.Trim(); }
        }

        public string Ma_SP
        {
            get { return m_strMa_SP; }
            set { m_strMa_SP = value.Trim(); }
        }

        public string Ten_SP
        {
            get { return m_strTen_SP; }
            set { m_strTen_SP = value.Trim(); }
        }

        public string Ghi_Chu
        {
            get { return m_strGhi_Chu; }
            set { m_strGhi_Chu = value.Trim(); }
        }

        public int Deleted
        {
            get { return m_intdeleted; }
            set { m_intdeleted = value; }
        }

        public DateTime? Created
        {
            get { return m_dtmCreated; }
            set { m_dtmCreated = value; }
        }

        public string Created_By
        {
            get { return m_strCreated_By; }
            set { m_strCreated_By = value.Trim(); }
        }

        public string Created_By_Function
        {
            get { return m_strCreated_By_Function; }
            set { m_strCreated_By_Function = value.Trim(); }
        }

        public DateTime? Last_Updated
        {
            get { return m_dtmLast_Updated; }
            set { m_dtmLast_Updated = value; }
        }

        public string Last_Updated_By
        {
            get { return m_strLast_Updated_By; }
            set { m_strLast_Updated_By = value.Trim(); }
        }

        public string Last_Updated_By_Function
        {
            get { return m_strLast_Updated_By_Function; }
            set { m_strLast_Updated_By_Function = value.Trim(); }
        }
    }

}
