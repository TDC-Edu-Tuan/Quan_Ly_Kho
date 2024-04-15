using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Data_Access.Controller
{
    public abstract class CController_Base<T>
    {
        public abstract List<T> List_Data();

        public abstract T Get_Data_By_ID(long p_lngAuto_ID);

        public abstract long Add_Data(T p_objData);

        public abstract void Update_Data(T p_objData);

        public abstract void Delete_Data(long p_lngAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function);
    }
}
