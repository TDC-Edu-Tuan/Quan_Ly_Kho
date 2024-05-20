using DevExpress.DataAccess.ObjectBinding;
using Quan_Ly_Kho_Data_Access.Controller.Cache;
using Quan_Ly_Kho_Data_Access.Controller.Nhap_Kho;
using Quan_Ly_Kho_Data_Access.Data.Danh_Muc_Co_Ban;
using Quan_Ly_Kho_Data_Access.Data.Nhap_Kho;
using Quan_Ly_Kho_Data_Access.Utility;
using System.ComponentModel;

[DisplayName("rptNhap_Kho")]
[HighlightedClass]
public class rptNhap_Kho
{
    [HighlightedMember]
    public CReport_Header rptReport_Header()
    {
        CReport_Header v_objHeader = new();
        return v_objHeader;
    }

    [HighlightedMember]
    public CXNK_Nhap_Kho rptFXNK_001_Get_Nhap_Kho_By_ID(long p_lngAuto_ID)
    {
        CXNK_Nhap_Kho_Controller v_objCtrlData = new();
        CXNK_Nhap_Kho v_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(p_lngAuto_ID);
        if (v_objData != null)
        {
            CDM_NCC v_objNCC = CCache_NCC.Get_Data_By_ID(v_objData.NCC_ID);
            if (v_objNCC != null)
            {
                v_objData.Ma_NCC = v_objNCC.Ma_NCC;
                v_objData.Ten_NCC = v_objNCC.Ten_NCC;

            }
        }
        CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();
        List<CXNK_Nhap_Kho_Raw_Data> v_arrRes = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(p_lngAuto_ID);
        v_objData.Details = v_arrRes.ToList();
        return v_objData;
    }

    [HighlightedMember]
    public List<CXNK_Nhap_Kho> rpt_XNK_NK_Phieu_Nhap_Hang_Multi(long[] p_arrNhap_Kho_ID)
    {
        CXNK_Nhap_Kho_Controller v_objCtrlData = new();
        CXNK_Nhap_Kho_Raw_Data_Controller v_objCtrlRaw_Data = new();

        List<CXNK_Nhap_Kho> v_arrRes = new();

        for (int i = 0; i < p_arrNhap_Kho_ID.Length; i++)
        {
            CXNK_Nhap_Kho v_objData = v_objCtrlData.FQ_718_NK_sp_sel_Get_By_ID(p_arrNhap_Kho_ID[i]);
            if (v_objData != null)
            {
                v_objData.Details = v_objCtrlRaw_Data.FQ_719_NKRD_sp_sel_List_By_Nhap_Kho_ID(p_arrNhap_Kho_ID[i]);
                v_arrRes.Add(v_objData);
            }
        }

        return v_arrRes;
    }
}

public class CReport_Header
{
    public string Product_Version { get; set; } = CConfig.Product_Version;
    public string Product_Name { get; set; } = CConfig.Product_Name;
    public string Product_Auth { get; set; } = CConfig.Product_Auth;
    public string Created_By { get; set; } = CConfig.Created_By;
    public DateTime? Created { get; set; } = CConfig.Created;
}