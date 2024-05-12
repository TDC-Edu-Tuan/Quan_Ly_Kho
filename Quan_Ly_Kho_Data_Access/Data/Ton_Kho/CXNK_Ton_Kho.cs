using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Data
{
    public class CXNK_Ton_Kho
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private long m_lngKho_ID;
        private long m_lngVi_Tri_ID;
        private long m_lngNhap_Kho_ID;
        private long m_lngSan_Pham_ID;
        private long m_lngNhap_Kho_Raw_ID;
        private double m_dblSo_Luong;
        private int m_intTrang_Thai_Ton_Kho;
        private string m_strGhi_Chu;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;


        private string m_strMa_Vi_Tri;
        private string m_strTen_Vi_Tri;
        private string m_strSo_Phieu_Nhap;
        private string m_strMa_SP;
        private string m_strTen_SP;
        private string m_strTen_Don_Vi_Tinh;
        private string m_strMa_LSP;
        private string m_strTen_LSP;


        public CXNK_Ton_Kho()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_lngKho_ID = CConst.INT_VALUE_NULL;
            m_lngVi_Tri_ID = CConst.INT_VALUE_NULL;
            m_lngNhap_Kho_ID = CConst.INT_VALUE_NULL;
            m_lngSan_Pham_ID = CConst.INT_VALUE_NULL;
            m_lngNhap_Kho_Raw_ID = CConst.INT_VALUE_NULL;
            m_dblSo_Luong = CConst.FLT_VALUE_NULL;
            m_intTrang_Thai_Ton_Kho = CConst.INT_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

            m_strMa_Vi_Tri = CConst.STR_VALUE_NULL;
            m_strTen_Vi_Tri = CConst.STR_VALUE_NULL;
            m_strSo_Phieu_Nhap = CConst.STR_VALUE_NULL;
            m_strMa_SP = CConst.STR_VALUE_NULL;
            m_strTen_SP = CConst.STR_VALUE_NULL;
            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strMa_LSP = CConst.STR_VALUE_NULL;
            m_strTen_LSP = CConst.STR_VALUE_NULL;

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

        public long Vi_Tri_ID
        {
            get
            {
                return m_lngVi_Tri_ID;
            }
            set
            {
                m_lngVi_Tri_ID = value;
            }
        }

        public long Nhap_Kho_ID
        {
            get
            {
                return m_lngNhap_Kho_ID;
            }
            set
            {
                m_lngNhap_Kho_ID = value;
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

        public long Nhap_Kho_Raw_ID
        {
            get
            {
                return m_lngNhap_Kho_Raw_ID;
            }
            set
            {
                m_lngNhap_Kho_Raw_ID = value;
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

        public int Trang_Thai_Ton_Kho
        {
            get
            {
                return m_intTrang_Thai_Ton_Kho;
            }
            set
            {
                m_intTrang_Thai_Ton_Kho = value;
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

        public string Ma_Vi_Tri { get => m_strMa_Vi_Tri; set => m_strMa_Vi_Tri = value.Trim(); }

        public string Ten_Vi_Tri { get => m_strTen_Vi_Tri; set => m_strTen_Vi_Tri = value.Trim(); }

        public string So_Phieu_Nhap { get => m_strSo_Phieu_Nhap; set => m_strSo_Phieu_Nhap = value.Trim(); }

        public string Ma_SP { get => m_strMa_SP; set => m_strMa_SP = value.Trim(); }

        public string Ten_SP { get => m_strTen_SP; set => m_strTen_SP = value.Trim(); }

        public string Ten_Don_Vi_Tinh { get => m_strTen_Don_Vi_Tinh; set => m_strTen_Don_Vi_Tinh = value.Trim(); }

        public string Ma_LSP { get => m_strMa_LSP; set => m_strMa_LSP = value.Trim(); }

        public string Ten_LSP { get => m_strTen_LSP; set => m_strTen_LSP = value.Trim(); }
        public string Trang_Thai_TK_Text
        {
            get
            {
                string v_strRes = CConst.STR_VALUE_NULL;
                switch (m_intTrang_Thai_Ton_Kho)
                {
                    case (int)ETrang_Thai_TK_ID.New:
                        v_strRes = "Mới";
                        break;


                }

                return v_strRes;
            }
        }
    }
}
