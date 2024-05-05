﻿using Quan_Ly_Kho_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho_Controls.Danh_Muc
{
    public partial class FControl_Don_Vi_Tinh_Combo : FControl_Combobox_Base
    {
        public static void Load_Combo(ComboBox p_objCombo, List<CDM_Don_Vi_Tinh> p_arrData, string p_strValue_Field,
              string p_strValue_Display)
        {
            if (p_arrData.Count == 0)
                return;

            CDM_Don_Vi_Tinh v_objFirst = p_arrData.FirstOrDefault();
            Check_Fields_Combo(v_objFirst, p_strValue_Field, p_strValue_Display);

            if (g_bIs_Success == false)
                return;

            p_objCombo.DataSource = p_arrData;
            p_objCombo.ValueMember = p_strValue_Field;
            p_objCombo.DisplayMember = p_strValue_Display;

        }
    }
}