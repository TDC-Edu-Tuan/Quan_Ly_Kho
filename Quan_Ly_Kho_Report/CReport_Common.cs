using DevExpress.DataAccess.ObjectBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Kho_Report
{
    [DisplayName("Employees")]
    [HighlightedClass]
    public class CReport_Common
    {
        public DataTable rptReport_Header()
        {
            return new DataTable();
        }
    }
}
