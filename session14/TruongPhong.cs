namespace session14;

public class TruongPhong : NhanVien
{
    private double heSoLuong;
    public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
    
    public TruongPhong(string maNhanVien, string hoTen, double luongCoBan, double heSoLuong) : base(maNhanVien, hoTen, luongCoBan)
    {
        HeSoLuong = heSoLuong;
    }

    public override double TinhLuong()
    {
        LuongCoBan *= HeSoLuong;
        return LuongCoBan;
    }
}