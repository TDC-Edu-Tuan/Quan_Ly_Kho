using DevExpress.DataAccess.ObjectBinding;
using System.ComponentModel;
using System.Data;

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
