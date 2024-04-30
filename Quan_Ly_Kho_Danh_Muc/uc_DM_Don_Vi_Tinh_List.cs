using Quan_Ly_Kho_Data;
using Quan_Ly_Kho_Data_Access.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Danh_Muc
{
    public partial class uc_DM_Don_Vi_Tinh_List : UCBase
    {
        private List<CDM_Don_Vi_Tinh> m_arrData = new();

        public uc_DM_Don_Vi_Tinh_List()
        {
            InitializeComponent();

        }

        protected override void Load_Init()
        {
            dtmFrom.Value = CUtility_Date.Convert_To_Dau_Ngay(DateTime.Now.AddDays(-15));
            dtmTo.Value = (DateTime)CUtility_Date.Convert_To_Cuoi_Ngay(DateTime.Now);

            g_grdData = grdData;
        }

        protected override void Load_Data(object sender, EventArgs e)
        {
            CDM_Don_Vi_Tinh_Controller v_ctrlData = new();
            m_arrData = v_ctrlData.FQ_110_DVT_sp_sel_List_By_Created(dtmFrom.Value, dtmTo.Value);
            grdData.DataSource = m_arrData;

            g_grdData = grdData;

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
