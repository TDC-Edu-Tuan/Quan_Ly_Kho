using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Data
{
    public class CEntity_Base
    {
        private long m_lngAuto_ID;

        private int m_ideleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public long Auto_ID { get => m_lngAuto_ID; set => m_lngAuto_ID = value; }
        public int deleted { get => m_ideleted; set => m_ideleted = value; }
        public DateTime? Created { get => m_dtmCreated; set => m_dtmCreated = value; }
        public string Created_By { get => m_strCreated_By; set => m_strCreated_By = value.Trim(); }
        public string Created_By_Function { get => m_strCreated_By_Function; set => m_strCreated_By_Function = value.Trim(); }
        public DateTime? Last_Updated { get => m_dtmLast_Updated; set => m_dtmLast_Updated = value; }
        public string Last_Updated_By { get => m_strLast_Updated_By; set => m_strLast_Updated_By = value.Trim(); }
        public string Last_Updated_By_Function { get => m_strLast_Updated_By_Function; set => m_strLast_Updated_By_Function = value.Trim(); }

        public virtual void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_ideleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }
    }
}
