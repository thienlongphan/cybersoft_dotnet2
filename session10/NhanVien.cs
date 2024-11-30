namespace session10;

public class NhanVien
{
    protected string MaNhanVien;
    public string HoTen {set; get;}
    // mục đích dùng getter và setter để truy cập vào các thuộc tính private
    public string NgaySinh;
    public int Tuoi;
    public double Luong;
    public string GioiTinh;

    // overload 
    // override ghi de phuong thuc class
    public virtual double TinhLuong()
    {
        return 1000;
    }
}