namespace session14;

public abstract class NhanVien
{
    private string maNhanVien;

    public string MaNhanVien
    {
        get => maNhanVien;
        set => maNhanVien = value;
    }
    
    private string hoTen;
    public string HoTen { get => hoTen; set => hoTen = value; }

    private double luongCoBan;
    public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

    public NhanVien(string maNhanVien, string hoTen, double luongCoBan)
    {
        MaNhanVien = maNhanVien;
        HoTen = hoTen;
        LuongCoBan = luongCoBan;
    }

    public void ChamCong()
    {
        Console.WriteLine("Cham Cong");
    }

    // Hàm abstract này không có thân hàm
    public abstract double TinhLuong();
}