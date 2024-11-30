namespace session10;

public class TruongNhom: NhanVien
{
    public string MaQuanLyNhom;

    public string GetMaNV()
    {
        return MaNhanVien;
    }

    public override double TinhLuong()
    {
        double luongCoban = base.TinhLuong();
        return luongCoban + luongCoban * 1.5;
    }
}