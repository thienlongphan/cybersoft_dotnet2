using session9;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        // Bản chất của oop đó chính là gom nhóm các biến với nhau
        // Các bien dc goi la các thuộc tính
        BaiViet baiViet1 = new BaiViet();
        baiViet1.tieuDe = "Hello 1";
        baiViet1.hinhAnh = "hinh1.png";
        baiViet1.noiDung = "Study oop 1";
        //Console.WriteLine($"Article 1: Title-{baiViet1.tieuDe} Picture-{baiViet1.hinhAnh} Content-{baiViet1.noiDung}");
        baiViet1.XuatThongTin();
        
        BaiViet baiViet2 = new BaiViet("defaulTitle", "defaulDescription", "defaultPicture");
        baiViet2.tieuDe = "Hello 2";
        baiViet2.hinhAnh = "hinh2.png";
        baiViet2.noiDung = "Study oop 2";
        //baiViet2.XuatThongTin();
        
        BaiViet baiviet3 = new BaiViet("defaulTitle3", "defaulDescription3", "defaultPicture3");
        baiviet3.XuatThongTin();
        
        // Bai tap nhap mon
        // tạo doi tuong hoc sinh (họ tên, tuổi, giới tính, email)
        // Xuat thong tin
        Student student1 = new Student();
        student1.fullName = "John Doe";
        student1.age = 25;
        student1.sex = "Male";
        student1.email = "john@doe.com";
        student1.Display();

        // Bài tập về nhà luyện thêm
        // Bai1: Tạo đối tượng sản phẩm (mã sản phẩm, tên sản phẩm, giá bán, số lượng tồn kho)
        // nhap và xuất thông tin sản phẩm

        // Bai2: 
        // Tạo lớp Rectangle với các thuộc tính:

        // length (chieu dai)
        // width (chieu rong)
        // Va cac phuong thuc: 
        // Nhap thong tin
        // Tinh dien tich
        // Tinh chu vi
    } 
}
