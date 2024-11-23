namespace session9;

public class BaiViet
{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;
    
    // default khi khoi tao doi tuong thi c# se goi ham khởi tạo (constructor) mặc định
    // Hàm khởi tạo này sẽ tạo giá trị mặc định cho các thuộc tính
    // Cú pháp: <Tên class> {}

    public BaiViet()
    {
        Console.WriteLine("This is constructor of BaiViet");
    }
    
    // co 2 loai hàm constructor: có tham số và không có tham số
    // Lưu ý: trong class sẽ có thể nhiều constructor xuất hiện

    public BaiViet(string tieuDe, string noiDung, string hinhAnh)
    {
        this.tieuDe = tieuDe;
        this.noiDung = noiDung;
        this.hinhAnh = hinhAnh;
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Thong tin bai viet la: ");
        Console.WriteLine($"Title: {tieuDe}");
        Console.WriteLine($"Description: {noiDung}");
        Console.WriteLine($"Picture: {hinhAnh}");
        Console.WriteLine("----------------------");
    }
}