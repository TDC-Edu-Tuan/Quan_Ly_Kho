using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Controller.Nhap_Kho;
using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Data.Nhap_Kho;
using Quan_Ly_Kho_Data_Access.Data.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Utility;

namespace Quan_Ly_Kho_Common
{
    public class CTon_Kho_Common
    {
        public static void Update_Ton_Kho(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Ton_Kho p_objData)
        {
            CXNK_Ton_Kho_Controller v_objCtrlData = new();
            CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();
            CXNK_Nhap_Kho_Controller v_ctrlNK_Data = new();
            try
            {
                //Lấy thông tin của raw data
                CXNK_Nhap_Kho_Raw_Data v_objRaw = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_Get_By_ID(p_conn, p_trans, p_objData.Nhap_Kho_Raw_ID);

                if (v_objRaw == null)
                    throw new Exception("Dòng data này không tồn tại trong phiếu nhập.");

                //Kiểm tra số lượng
                if (p_objData.Trang_Thai_Ton_Kho == (int)ETrang_Thai_TK_ID.Dang_Xuat)
                    throw new Exception("Dòng tồn này đã xuất một phần.");

                if (p_objData.Trang_Thai_Ton_Kho == (int)ETrang_Thai_TK_ID.Da_Xuat)
                    throw new Exception("Dòng tồn này đã xuất.");

                v_objRaw.San_Pham_ID = p_objData.San_Pham_ID;
                v_objRaw.So_Luong = p_objData.So_Luong;
                v_objRaw.Ghi_Chu = p_objData.Ghi_Chu;
                v_objRaw.Last_Updated_By = p_objData.Last_Updated_By;
                v_objRaw.Last_Updated_By_Function = p_objData.Last_Updated_By_Function;

                //Update raw data của phiếu
                v_objCtrlRaw_Data.FQ_719_NKRD_sp_upd_Update(p_conn, p_trans, v_objRaw);

                //Update tồn
                v_objCtrlData.FQ_722_TK_sp_upd_Update(p_conn, p_trans, p_objData);

                //Update phiếu
                CXNK_Nhap_Kho v_objNK = v_ctrlNK_Data.FQ_718_NK_sp_sel_Get_By_ID(v_objRaw.Nhap_Kho_ID);

                if (v_objNK == null)
                    throw new Exception("Phiếu nhập không tồn tại.");
                v_objNK.Details = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(p_conn, p_trans, v_objNK.Auto_ID);

                CNhap_Kho_Common.Updated_Total_Phieu_Nhap(p_conn, p_trans, v_ctrlNK_Data, v_objNK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
