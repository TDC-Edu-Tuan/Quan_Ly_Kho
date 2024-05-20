using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data_Access.Data.Xuat_kho
{
    public class CXNK_Xuat_Kho
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private long m_lngKho_ID;
        private long m_lngNXD_ID;
        private string m_strSo_Phieu_Xuat;
        private DateTime? m_dtmNgay_Xuat_kho;
        private double m_dblTong_SL;
        private double m_dblTong_Tri_Gia;
        private int m_intTrang_Thai_XK_ID;
        private string m_strGhi_Chu;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        private string m_strMa_NXD;
        private string m_strTen_NXD;
        private string m_strDia_Chi;

        private List<CXNK_Xuat_Kho_Raw_Data> m_arrDetails;
        public CXNK_Xuat_Kho()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_lngKho_ID = CConst.INT_VALUE_NULL;
            m_lngNXD_ID = CConst.INT_VALUE_NULL;
            m_strSo_Phieu_Xuat = CConst.STR_VALUE_NULL;
            m_dtmNgay_Xuat_kho = CConst.DTM_VALUE_NULL;
            m_dblTong_SL = CConst.FLT_VALUE_NULL;
            m_dblTong_Tri_Gia = CConst.FLT_VALUE_NULL;
            m_intTrang_Thai_XK_ID = CConst.INT_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

            m_strMa_NXD = CConst.STR_VALUE_NULL;
            m_strTen_NXD = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;

            m_arrDetails = new();
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

        public long NXD_ID
        {
            get
            {
                return m_lngNXD_ID;
            }
            set
            {
                m_lngNXD_ID = value;
            }
        }

        public string So_Phieu_Xuat
        {
            get
            {
                return m_strSo_Phieu_Xuat;
            }
            set
            {
                m_strSo_Phieu_Xuat = value.Trim();
            }
        }

        public DateTime? Ngay_Xuat_Kho
        {
            get
            {
                return m_dtmNgay_Xuat_kho;
            }
            set
            {
                m_dtmNgay_Xuat_kho = value;
            }
        }

        public double Tong_SL
        {
            get
            {
                return m_dblTong_SL;
            }
            set
            {
                m_dblTong_SL = value;
            }
        }

        public double Tong_Tri_Gia
        {
            get
            {
                return m_dblTong_Tri_Gia;
            }
            set
            {
                m_dblTong_Tri_Gia = value;
            }
        }

        public int Trang_Thai_XK_ID
        {
            get
            {
                return m_intTrang_Thai_XK_ID;
            }
            set
            {
                m_intTrang_Thai_XK_ID = value;
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

        public string Trang_Thai_XK_Text
        {
            get
            {
                string v_strRes = CConst.STR_VALUE_NULL;
                switch (m_intTrang_Thai_XK_ID)
                {
                    case (int)ETrang_Thai_Xuat_Kho.New:
                        v_strRes += "Kế hoạch";
                        break;
                }

                return v_strRes;
            }

        }


        public string Ma_NXD { get => m_strMa_NXD; set => m_strMa_NXD = value.Trim(); }

        public string Ten_NXD { get => m_strTen_NXD; set => m_strTen_NXD = value.Trim(); }

        public string Dia_Chi { get => m_strDia_Chi; set => m_strDia_Chi = value.Trim(); }
        public List<CXNK_Xuat_Kho_Raw_Data> Details { get => m_arrDetails; set => m_arrDetails = value; }
    }
}
