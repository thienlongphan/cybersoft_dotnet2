namespace session10;

public class QuanLy : TruongNhom
{
    public string ThuKy { get; set; }

    public override double TinhLuong()
    {
        double luongCoban = base.TinhLuong();
        return luongCoban + 500; 
    }
}