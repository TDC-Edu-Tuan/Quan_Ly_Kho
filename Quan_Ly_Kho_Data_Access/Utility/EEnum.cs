namespace Quan_Ly_Kho_Data_Access.Utility
{

    public enum ENhom_Thanh_Vien
    {
        Quan_Tri = 0,
        Xuat_Kho = 1,
        Nhap_Hang = 2,
        Data = 3,
        Dev = 4,
    }

    public enum EMessage_Type
    {
        None = 0,
        Error = 1,
        Warning = 2,
        Stop = 3,
        Success = 4,
        Question = 5,
    }

    public enum EStatus_Type
    {
        Closed = 1000,
        Closed_And_Reload = 1001,
        Message_Box = 1002,
        Custom_Status = 1003,
        Success = 1004,
        Reload = 1005,
        New = 1006,
        None = 0,
    }

    public enum ETrang_Thai_Nhap_Kho
    {
        New = 0,
        Da_Nhan = 1,
        Dang_Vao_Ton = 2,
        Hoan_Thanh_Vao_Ton = 3,


    }
    public enum ETrang_Thai_TK_ID
    { 
        New = 1,
        Dang_Xuat = 2,
        Da_Xuat = 3,

    }

    public enum ETrang_Thai_Xuat_Kho
    {
        New = 1,
    }
}
