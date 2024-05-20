using Microsoft.Data.SqlClient;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Controller.Xuat_Kho;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Ton_Kho;
using Quan_Ly_Kho_Data_Access.Data.Xuat_kho;
using Quan_Ly_Kho_Data_Access.Utility;
using System.Linq;

namespace Quan_Ly_Kho_Common
{
    public class CXuat_Kho_Common
    {
        public static string Auto_Tao_Ten_Phieu(string p_strKey, int p_iLengt)
        {
            DateTime v_dtm = DateTime.Now;

            string v_strRes = CConst.STR_VALUE_NULL;

            v_strRes = $"{p_strKey} - {v_dtm.ToString("ddMMyyyy") + CUtility.Create_Rand_ID(2)} - {CUtility.Create_Rand_ID(p_iLengt)}";


            return v_strRes;
        }

        public static string Check_Raw_Data_Info(CXNK_Xuat_Kho_Raw_Data p_objRaw_Data)
        {
            string v_strRes = CConst.STR_VALUE_NULL;
            string v_strError = CConst.STR_VALUE_NULL;
            try
            {
                long v_lngSP_ID = CUtility.Convert_To_Int64(p_objRaw_Data.San_Pham_ID);
                CDM_San_Pham v_objSP = CCache_San_Pham.Get_Data_By_ID(v_lngSP_ID);

                if (v_objSP == null)
                    v_strError += ("Sản phẩm không tồn tại \n");

                if (p_objRaw_Data.So_Luong <= 0)
                    v_strError += ("SL không được <= 0");

                if (p_objRaw_Data.Don_Gia <= 0)
                    v_strError += "Đơn giá không được <= 0";

                if (v_strError != CConst.STR_VALUE_NULL)
                    throw new Exception(v_strError);

            }
            catch (Exception ex)
            {
                v_strRes = ex.Message;
            }
            return v_strRes;
        }

        public static void Auto_Tao_Phieu(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData,
            CXNK_Xuat_Kho_Raw_Data_Controller p_objCtrlRaw, CXNK_Xuat_Kho p_objData)
        {

            string v_strError = CConst.STR_VALUE_NULL;

            try
            {
                v_strError = Check_Data_Phieu_Xuat(p_objData);

                //Ins phiếu
                long v_lngXuat_Kho_ID = p_objData.Auto_ID = p_objCtrlData.FQ_728_XK_sp_ins_Insert(p_conn, p_trans, p_objData);

                //Ins details
                foreach (CXNK_Xuat_Kho_Raw_Data v_objRaw in p_objData.Details)
                {
                    v_objRaw.Xuat_Kho_ID = v_lngXuat_Kho_ID;
                    v_objRaw.Chu_Hang_ID = p_objData.Chu_Hang_ID;
                    v_objRaw.Kho_ID = p_objData.Kho_ID;
                    v_objRaw.Last_Updated_By = p_objData.Last_Updated_By;
                    v_objRaw.Last_Updated_By_Function = p_objData.Last_Updated_By_Function;

                    p_objCtrlRaw.FQ_734_XKRD_sp_ins_Insert(p_conn, p_trans, v_objRaw);
                }

                Updated_Total_Phieu_Xuat(p_conn, p_trans, p_objCtrlData, p_objData);

                if (v_strError != CConst.STR_VALUE_NULL)
                    throw new Exception(v_strError);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static string Check_Data_Phieu_Xuat(CXNK_Xuat_Kho p_objData)
        {
            string v_strError = CConst.STR_VALUE_NULL;

            //Check số phiếu
            if (p_objData.So_Phieu_Xuat == CConst.STR_VALUE_NULL)
                p_objData.So_Phieu_Xuat = Auto_Tao_Ten_Phieu("SPX", 5);

            //Check NCC
            if (p_objData.NXD_ID == CConst.INT_VALUE_NULL)
                v_strError += "Vui lòng chọn nơi xuất đến" + "\n";

            if (p_objData.Details.Count == CConst.INT_VALUE_NULL)
                v_strError += "Phiếu xuất không chứa chi tiết" + "\n";

            return v_strError;
        }

        public static void Updated_Total_Phieu_Xuat(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData, CXNK_Xuat_Kho p_objData)
        {
            p_objData.Tong_SL = p_objData.Details.Sum(v_objRaw_Data => v_objRaw_Data.So_Luong);
            p_objData.Tong_Tri_Gia = p_objData.Details.Sum(v_objRaw_Data => v_objRaw_Data.Tri_Gia);

            p_objCtrlData.FQ_728_XK_sp_upd_Update_Totals_Phieu(p_conn, p_trans, p_objData);
        }

        public static void Update_Data_Phieu_Xuat(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData,
           CXNK_Xuat_Kho_Raw_Data_Controller p_objCtrlRaw, CXNK_Xuat_Kho p_objData)
        {
            CXNK_Ton_Kho_Controller v_objCtrl_TK = new();
            string v_strError = CConst.STR_VALUE_NULL;

            try
            {
                v_strError = Check_Data_Phieu_Xuat(p_objData);

                //upd
                p_objCtrlData.FQ_728_XK_sp_upd_Update(p_conn, p_trans, p_objData);

                //Ins details
                foreach (CXNK_Xuat_Kho_Raw_Data v_objRaw in p_objData.Details)
                {
                    CXNK_Ton_Kho v_objTK = v_objCtrl_TK.FQ_722_TK_sp_sel_Get_NK_ID(p_conn, p_trans, v_objRaw.Auto_ID);

                    if (v_objTK != null)
                    {
                        if (v_objTK.Trang_Thai_Ton_Kho != (int)ETrang_Thai_TK_ID.New)
                            throw new Exception("Phiếu nhập chứa dòng chi tiết đã xuất nên không chỉnh sửa được.");
                    }

                    v_objRaw.Last_Updated_By = p_objData.Last_Updated_By;
                    v_objRaw.Last_Updated_By_Function = p_objData.Last_Updated_By_Function;

                    p_objCtrlRaw.FQ_734_XKRD_sp_upd_Update(p_conn, p_trans, v_objRaw);
                }

                Updated_Total_Phieu_Xuat(p_conn, p_trans, p_objCtrlData, p_objData);

                if (v_strError != CConst.STR_VALUE_NULL)
                    throw new Exception(v_strError);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void Xoa_Phieu_Xuat(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData,
           CXNK_Xuat_Kho_Raw_Data_Controller p_objCtrlRaw, long p_lngNK_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            CXNK_Ton_Kho_Controller v_objCtrl_TK = new();
            try
            {
                CXNK_Xuat_Kho v_objData = p_objCtrlData.FQ_728_XK_sp_sel_Get_By_ID(p_conn, p_trans, p_lngNK_ID);
                if (v_objData == null)
                    throw new Exception("Phiếu nhập không tồn tại.");

                //Kiểm tra tồn
                CXNK_Ton_Kho v_objTK = v_objCtrl_TK.FQ_722_TK_sp_sel_Get_NK_ID(p_conn, p_trans, p_lngNK_ID);

                if (v_objTK != null)
                {
                    if (v_objTK.Trang_Thai_Ton_Kho != (int)ETrang_Thai_TK_ID.New)
                        throw new Exception("Phiếu nhập chứa dòng chi tiết đã xuất nên không xóa được.");
                }

                //Xóa phiếu
                p_objCtrlData.FQ_728_XK_sp_del_Delete_By_ID(p_conn, p_trans, p_lngNK_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);

                //Xóa deltail
                p_objCtrlRaw.FQ_734_XKRD_sp_del_Delete_By_XK_ID(p_conn, p_trans, p_lngNK_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Xoa_Details_Phieu_Xuat(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData,
           CXNK_Xuat_Kho_Raw_Data_Controller p_objCtrlRaw, CXNK_Ton_Kho_Controller p_objCtrl_TK, long p_lngNK_Raw_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CXNK_Xuat_Kho_Raw_Data v_objData = p_objCtrlRaw.FQ_734_XKRD_sp_sel_Get_By_ID(p_conn, p_trans, p_lngNK_Raw_ID);
                if (v_objData == null)
                    throw new Exception("Chi tiết phiếu không tồn tại.");

                //Xóa deltail
                p_objCtrlRaw.FQ_734_XKRD_sp_del_Delete_By_ID(p_conn, p_trans, p_lngNK_Raw_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);

                CXNK_Xuat_Kho v_objNK = p_objCtrlData.FQ_728_XK_sp_sel_Get_By_ID(p_conn, p_trans, v_objData.Xuat_Kho_ID);
                if (v_objNK == null)
                    throw new Exception("Phiếu nhập không tồn tại.");

                v_objNK.Details = p_objCtrlRaw.FQ_734_XKRD_sp_sel_List_By_Xuat_kho_ID(p_conn, p_trans, v_objNK.Auto_ID);

                //Kiêm tra trong tồn
                CXNK_Ton_Kho v_objTK = p_objCtrl_TK.FQ_722_TK_sp_sel_Get_By_Raw_Data_ID(p_conn, p_trans, p_lngNK_Raw_ID);

                if (v_objTK != null)
                {
                    //Nếu nó khác trạng thái new tức là đã xuất thì k cho xóa
                    if (v_objTK.Trang_Thai_Ton_Kho != (int)ETrang_Thai_TK_ID.New)
                    {
                        throw new Exception("Dòng data này đã xuất nên không thể xóa.");
                    }
                }

                //Kiểm tra nếu phiếu xuất hết details thì xóa luôn phiếu
                if (v_objNK.Details.Count == CConst.INT_VALUE_NULL)
                {
                    p_objCtrlData.FQ_728_XK_sp_del_Delete_By_ID(p_conn, p_trans, v_objNK.Auto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
                }
                else // update tại số lượng tổng trị giá của phiếu
                {
                    Updated_Total_Phieu_Xuat(p_conn, p_trans, p_objCtrlData, v_objNK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Xuat_Kho_To_NXD_By_XK_ID(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Controller p_objCtrlData,
           CXNK_Xuat_Kho_Raw_Data_Controller p_objCtrlRaw, CXNK_Ton_Kho_Controller p_objCtrl_TK, CXNK_Xuat_Kho p_objData)
        {
            string v_strError = CConst.STR_VALUE_NULL;
            int v_iRow_Count = CConst.INT_VALUE_NULL;
            try
            {
                //Kiểm tra phiếu xuất
                if (p_objData.Trang_Thai_XK_ID == (int)ETrang_Thai_Xuat_Kho.Shipped)
                    throw new Exception($"Phiếu {p_objData.So_Phieu_Xuat} đã xuất.");

                //KIểm tra details
                foreach (CXNK_Xuat_Kho_Raw_Data v_objRaw_Data in p_objData.Details)
                {
                    v_iRow_Count++;
                    string v_strCheck_Error = Check_Raw_Data_Info(v_objRaw_Data);
                    if (v_strCheck_Error != CConst.STR_VALUE_NULL)
                    {
                        v_strError += $"Dòng thứ {v_iRow_Count}: " + v_strCheck_Error;
                    }
                }

                if (v_strError != CConst.STR_VALUE_NULL)
                    throw new Exception(v_strError);

                //Kiểm tra tồn kho

                //B1. Kiểm tra tồn kho của mỗi sp
                Dictionary<long, double> v_dicSP_ID = new Dictionary<long, double>();
                foreach (CXNK_Xuat_Kho_Raw_Data v_objRaw_Data in p_objData.Details)
                {
                    if (!v_dicSP_ID.ContainsKey(v_objRaw_Data.San_Pham_ID))
                        v_dicSP_ID.Add(v_objRaw_Data.San_Pham_ID, v_objRaw_Data.So_Luong);
                    else
                        v_dicSP_ID[v_objRaw_Data.San_Pham_ID] += v_objRaw_Data.So_Luong;
                }

                //B2.Lấy danh sách tồn kho bởi sản phẩm id
                //Tính số lượng trong detail
                foreach (long v_lngSP_ID in v_dicSP_ID.Keys)
                {
                    List<CXNK_Ton_Kho> v_arrTon_Kho = new();
                    v_arrTon_Kho = p_objCtrl_TK.FQ_722_TK_sp_sel_List_By_San_Pham_ID(p_conn, p_trans, v_lngSP_ID, p_objData.Chu_Hang_ID, p_objData.Kho_ID);

                    CDM_San_Pham v_objSP = CCache_San_Pham.Get_Data_By_ID(v_lngSP_ID);

                    //B2.1 Kiểm tra sản phẩm đã xóa chưa
                    if (v_objSP == null)
                        throw new Exception("Mã sản phẩm không tồn tại.");

                    //B2.2 Kiểm tra sản phẩm có trong tồn không
                    if (v_arrTon_Kho.Count == 0)
                        throw new Exception($"Trong tồn không tồn tại sản phẩm {v_objSP.Ma_SP}.");

                    //B2.3 Kiểm tra số lượng của của mã
                    double v_dblSL_Ton = v_arrTon_Kho.Sum(it => it.So_Luong);

                    List<CXNK_Xuat_Kho_Raw_Data> v_arrTemp = p_objData.Details.Where(it => it.San_Pham_ID == v_lngSP_ID).ToList();
                    double v_dblSL_Phieu_Xuat = v_arrTemp.Sum(it => it.So_Luong);

                    if (v_dblSL_Ton < v_dblSL_Phieu_Xuat)
                        throw new Exception($"SL {v_objSP.Ma_SP} trong tồn không đủ.");

                    //B3. Trừ tồn
                    //B3.1 Sắp xếp tồn theo số lượng từ thấp đến cao
                    v_arrTon_Kho = v_arrTon_Kho.OrderBy(it => it.So_Luong).ToList();

                    //B3.2 Tiến hành trừ tồn (Chắc tồn lúc này luôn lớn hơn hoặc bẳng raw data phiếu xuất)
                    double v_dblSL_Raw_Data = v_dicSP_ID[v_lngSP_ID];

                    foreach (CXNK_Ton_Kho v_objTK in v_arrTon_Kho)
                    {
                        double v_dblSL_TK = v_objTK.So_Luong;

                        //Nếu mà nó lớn hơn 0 và SL raw sau mỗi lần lặp lớn hơn sl tồn thì hàng đó trừ luôn bằng 0 và luôn có phần dư
                        if (v_dblSL_Raw_Data > 0 && v_dblSL_Raw_Data >= v_dblSL_TK)
                        {
                            v_objTK.So_Luong = 0; //Dòng này luôn bằng 0                        
                            v_objTK.Trang_Thai_Ton_Kho = (int)ETrang_Thai_TK_ID.Da_Xuat;
                        }


                        if (v_dblSL_Raw_Data > 0 && v_dblSL_Raw_Data < v_dblSL_TK)
                        {
                            v_objTK.So_Luong = v_dblSL_TK - v_dblSL_Raw_Data;                  
                            v_objTK.Trang_Thai_Ton_Kho = (int)ETrang_Thai_TK_ID.Dang_Xuat;
                        }

                        v_objTK.Last_Updated_By = p_objData.Last_Updated_By;
                        v_objTK.Last_Updated_By_Function = p_objData.Last_Updated_By_Function;
                        p_objCtrl_TK.FQ_722_TK_sp_upd_Update(p_conn, p_trans, v_objTK);
                        v_dblSL_Raw_Data -= v_dblSL_TK;

                        if (v_dblSL_Raw_Data <= 0)
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
