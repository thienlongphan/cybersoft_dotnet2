using session10;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        // 4 tính chất trong OOP
        // Tính kế thừa: class con kế thừa các thuộc tính và phương thức các class cha
        // Tính đóng gói
        // Tính trừu tượng
        // Tính đa hình
        
        // BT mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý.
        // Lập trình quản lý nhân sự trong cty
        // Nhân viên: mã nhân vien, tên, ngay sinh, giói tính, tuổi, lương
        // Trưởng nhóm: mã nhân vien, tên, ngay sinh, giói tính, tuổi, lương, mã quan ly nhom
        // Quản lý: mã nhân vien, tên, ngay sinh, giói tính, tuổi, lương, mã quan ly nhom, thư ký
        
        TruongNhom truongNhom = new TruongNhom();
        truongNhom.HoTen = "Nguyen Van A";
        //Console.WriteLine($"Luong truong nhom: {truongNhom.TinhLuong()}");
        
        //Console.WriteLine($"Tên Trưởng nhóm: {truongNhom.HoTen}");
        //Console.WriteLine($"Mã nhân viên Trưởng nhóm: {truongNhom.GetMaNV()}");
        // Pham vi truy cap của thuoc tinh va phuong thuc
        // public: có thể truy cập từ bất kỳ đâu: Class con, bên ngoài class
        
        // private: class con và từ bên ngoài class không thể truy cập. Chỉ có thể truy cập từ chính class đó. 
        
        // internal
        
        // protected: Class con có thể truy cập các thuộc tính và phương thức của class cha, nhưng bên ngoài class ko được truy cập
        
        QuanLy quanLy = new QuanLy();
        quanLy.Luong = 1000;
         // Console.WriteLine($"Salary of manager: {quanLy.Luong}");
        //Console.WriteLine($"Luong truong nhom: {quanLy.TinhLuong()}");
        
        // C# check class QuanLy để tìm thuoc tinh luong,
        // Neu khong co thi check  class cha (TruongNhom)
        // Neu khong co thi check class cha của class cha (NhanVien)
        
        // Lưu ý: override
        // Nếu class con không muốn cac logic phuong thuc class cha
        // => Có thể viết lại phương thức đó trong class con
        // Nếu class con muốn dùng lại logic phương thức class cha 
        // => có thể dùng từ khóa base.tenPhuongThuc() để gọi hàm của class cha
        
        // BT ôn lại
        // - Sinh viên, giảng vien, cán bộ trong trường học
        // Viết chuong trinh quan ly những đối tượng trên
        // Class: nguoi: ID, ten, ngay sinh, gioi tinh, email.
        // Sinh Vien: ID, ten, ngay sinh, gioi tinh, email, lớp, điểm, trung bình.
        // Giảng Vien: ID, ten, ngay sinh, gioi tinh, email, chuyên ngành, học vị.
        // Cán bộ: ID, ten, ngay sinh, gioi tinh, email, chức vụ, phòng ban.

        Student student = new Student("SV001", "Nguyen Van A", "1/1/2025", "Male", "nguyenvan@gmail.com", "300", "IT001");
        student.Display();
        // C# chỉ hỗ trợ đơn Kế thừa
    }
}
