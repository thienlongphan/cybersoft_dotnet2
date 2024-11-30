using session11_phudao_oop;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        #region Bài 1: Quản lý thư viện
        // 1. Tạo class Book để quản lý sách (class cha)
        // - bookId: mã sách
        // - bookName: tên sách
        // - author: tác giả
        // - price: giá sách
        // 1.1  Tạo class TextBook kế thừa từ Book
        // - Subject: môn học
        // - grade: lớp
        // 1.2 Tạo class ReferenceBook kế thừa từ Book
        // - Topic: chủ đề
        // - publisher: nhà xuất bản
        // 1.3 Tạo class FictionBook kế thừa từ Book
        // - genre: thể loại
        // - year: năm sản xuất
        // -------------------
        // 2. Tạo class Library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // - file json lưu thong tin sách (nâng cáo)
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện (Lưu danh sách mới vào file JSON (sử dụng thư viện Newtonsoft.Json))
        // * check xem mã sách đã tồn tại chưa. Nếu có rồi thì bao lỗi
        // - Hiển thị danh sách sách trong thư viện
        // - Tìm sách theo mã sách
        // - Thoát
        
        // Console.WriteLine("Enter library number: ");
        // string libraryId = Console.ReadLine();
        //
        // Console.WriteLine("Enter library name: ");
        // string libraryName = Console.ReadLine();
        //
        //
        // LibraryManager libraryManager = new LibraryManager(libraryId, libraryName);
        //
        // // tạo menu
        // bool isRunning = true;
        //
        // while (isRunning)
        // {
        //     Console.WriteLine("\n=== Library Management menu ===\n");
        //     Console.WriteLine("1. Add text book to library");
        //     Console.WriteLine("2. Add reference book to library");
        //     Console.WriteLine("3. Display book list");
        //     Console.WriteLine("4. Exit");
        //     Console.WriteLine("Enter your choice 1-4: ");
        //     
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //
        //     switch (choice)
        //     {
        //         case 1:
        //             libraryManager.AddTextBook();
        //             break;
        //         case 2:
        //             libraryManager.AddReferenceBook();
        //             break;
        //         case 3:
        //             libraryManager.DisplayAllBooks();
        //             break;
        //         case 4:
        //             isRunning = false;
        //             break;
        //         default:
        //             Console.WriteLine("Invalid choice, please try again.");
        //             break;
        //     }
        // }

        #endregion

        #region Bài 2: Quản lý phương tiện giao thông (xe hơi, xe máy, xe đạp)

        // 1. Tạo class cha Vehicle
        // - vehicleId: mã phương tiện
        // - brand: hãng xe
        // - year: năm sản xuất
        // - price: giá xe
        // 1.1 Tạo class Car kế thừa từ Vehicle
        // - model: dòng xe
        // - color: màu xe
        // - engine: dung tích động cơ
        // 1.2 Tạo class Motor kế thừa từ Vehicle
        // - type: loại xe (số tay, số tự động)
        // - power: công suất
        // Tạo class VehicleManager để quản lý phương tiện giao thông
        // - danh sách phương tiện
        // - file json lưu thông tin phương tiện (nâng cao)
        // 3. Yêu cầu chức năng
        // - Thêm phương tiện vào danh sách
        // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
        // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
        // - Hiển thị danh sách phương tiện
        // - Tìm phương tiện theo mã phương tiện
        // - Thoát
        #endregion
    }
}
