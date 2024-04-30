using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Common
{
    public partial class UCLayout_Tool : UserControl
    {
        public DateTime g_dtmFrom
        {
            get
            {
                return dtmFrom.Value;
            }
        }

        public DateTime g_dtmTo
        {
            get
            {
                return dtmTo.Value;
            }
        }

        public Button Add_Data
        {
            get
            {
                return btnAdd_Data;
            }
            set
            {
                btnAdd_Data = value;
            }
        }

        public Button Import_Excel
        {
            get
            {
                return btnImport;
            }
            set
            {
                btnImport = value;
            }
        }

        public Button Export_Excel
        {
            get
            {
                return btnExport;
            }
            set
            {
                btnExport = value;
            }
        }

        public Button Search
        {
            get
            {
                return btnSearch;
            }
            set
            {
                btnSearch = value;
            }
        }

        public UCLayout_Tool()
        {
            InitializeComponent();
        }

        private void btnAdd_Data_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
