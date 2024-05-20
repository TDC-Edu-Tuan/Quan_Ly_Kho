using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Data.Xuat_kho
{
    public class CXNK_Xuat_Kho_Raw_Data
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private long m_lngKho_ID;
        private long m_lngXuat_Kho_ID;
        private long m_lngSan_Pham_ID;
        private double m_dblSo_Luong;
        private double m_dblDon_Gia;
        private string m_strGhi_Chu;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;


        private string m_strMa_SP;
        private string m_strTen_SP;
        private string m_StrSo_Phieu_Xuat;
        public CXNK_Xuat_Kho_Raw_Data()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_lngKho_ID = CConst.INT_VALUE_NULL;
            m_lngXuat_Kho_ID = CConst.INT_VALUE_NULL;
            m_lngSan_Pham_ID = CConst.INT_VALUE_NULL;
            m_dblSo_Luong = CConst.FLT_VALUE_NULL;
            m_dblDon_Gia = CConst.FLT_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

            m_strMa_SP = CConst.STR_VALUE_NULL;
            m_strTen_SP = CConst.STR_VALUE_NULL;
            m_StrSo_Phieu_Xuat = CConst.STR_VALUE_NULL;

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

        public long Kho_ID
        {
            get
            {
                return m_lngKho_ID;
            }
            set
            {
                m_lngKho_ID = value;
            }
        }

        public long Xuat_Kho_ID
        {
            get
            {
                return m_lngXuat_Kho_ID;
            }
            set
            {
                m_lngXuat_Kho_ID = value;
            }
        }

        public long San_Pham_ID
        {
            get
            {
                return m_lngSan_Pham_ID;
            }
            set
            {
                m_lngSan_Pham_ID = value;
            }
        }

        public double So_Luong
        {
            get
            {
                return m_dblSo_Luong;
            }
            set
            {
                m_dblSo_Luong = value;
            }
        }

        public double Don_Gia
        {
            get
            {
                return m_dblDon_Gia;
            }
            set
            {
                m_dblDon_Gia = value;
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

        public string Ma_SP { get => m_strMa_SP; set => m_strMa_SP = value.Trim(); }
        public string Ten_SP { get => m_strTen_SP; set => m_strTen_SP = value.Trim(); }
        public string So_Phieu_Xuat { get => m_StrSo_Phieu_Xuat; set => m_StrSo_Phieu_Xuat = value.Trim(); }

        public double Tri_Gia
        {
            get
            {
                return m_dblSo_Luong * m_dblDon_Gia;
            }
        }
    }
}
