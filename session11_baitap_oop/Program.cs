using Newtonsoft.Json;
using session11_baitap_oop;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        #region Bài 1
        // Bài tập 1: Quản lý lớp học
        // 1. Lớp học
        // Tạo lop Classroom để quản lý lớp học
        // ClassId: Mã lớp học
        // ClassName: tên lớp học
        // Danh sách sinh viên trong lớp học
        // 2. Sinh viên
        // StudentId: Mã Sinh viên
        // StudentName: tên sinh viên
        // age: tuổi
        // 3. Yêu cầu chức năng
        // - Thêm sinh viên vào lớp 
        // - Hiển thi danh sach 
        
        // Tạo lớp học
        ClassRoom classRoom = new ClassRoom("C02", "Dotnet 02");
        // Tạo Menu quản lý sinh viên
        // 1. Thêm Sinh Viên
        // 2. Hiển thị danh sách sinh viên
        // 3. Tìm kiếm Sinh viên theo mã sinh viên
        // 4. Thoát

        // while (true)
        // {
        //     Console.WriteLine($"\n Classroom management---------");
        //     Console.WriteLine("1. Add Student");
        //     Console.WriteLine("2. Show Students");
        //     Console.WriteLine("3. Find Student by ID");
        //     Console.WriteLine("4. Exit");
        // int choice = Convert.ToInt32(Console.ReadLine());
        //     switch (choice)
        //     {
        //         case 1: 
        //             // Thêm Sinh viên
        //             Console.WriteLine("Enter Student ID: ");
        //             string studentID = Console.ReadLine();
        //             Console.WriteLine("Enter Student Name: ");
        //             string studentName = Console.ReadLine();
        //             Console.WriteLine("Enter Student age: ");
        //             int age = Convert.ToInt32(Console.ReadLine());
        //             
        //             Student student = new Student(studentID, studentName, age);
        //             classRoom.AddStudent(student);
        //             
        //             // Lưu danh sách sinh viên vào json
        //             
        //             // chuyển danh sách sinh viên thành json
        //             var jsons = JsonConvert.SerializeObject(classRoom.students, Formatting.Indented);
        //             
        //             // lưu json vào File
        //             File.WriteAllText("students.json", jsons);
        //             Console.WriteLine("Add Student Successfully");
        //             
        //             break;
        //         case 2:
        //             var studentJsons = File.ReadAllText("students.json");
        //             classRoom.students = JsonConvert.DeserializeObject<List<Student>>(studentJsons);
        //             classRoom.ShowStudents();
        //             break;
        //         case 3:
        //             // Tìm kiếm sinh viên theo mã sinh viên
        //             Console.WriteLine("Enter Student ID: ");
        //             string id = Console.ReadLine();
        //             if (id == null)
        //             {
        //                 Console.WriteLine("Student ID is required");
        //                 break;
        //             }
        //             classRoom.FindStudentById(id);
        //             break;
        //         case 4:
        //             return;
        //         default:
        //             Console.WriteLine("Invalid Choice. Please enter 1 -> 4");
        //             break;
        //             
        //     }
        // }
        

        #endregion

        #region Bai2: Quản lý thư viện

        // 1. Tạo class Book để quản lý sách
        // - bookId: mã sách
        // - bookName: tên sách
        // - author: tác giả
        // - price: giá sách
        // -------------------
        // 2. Tạo class Library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện
        // - Hiển thị danh sách sách trong thư viện
        // - Tìm sách theo mã sách
        // - Thoát

        Library library = new Library("L001", "Long's Library");

        // while (true)
        // {
        //     Console.WriteLine("\n Library management---------");
        //     Console.WriteLine("1. Add book to library");
        //     Console.WriteLine("2. Show books from library");
        //     Console.WriteLine("3. Find book by ID");
        //     Console.WriteLine("4. Exit");
        //     int choice2 = Convert.ToInt32(Console.ReadLine());
        //     
        //     switch (choice2)
        //     {
        //         case 1:
        //             Console.WriteLine("Enter Book ID: ");
        //             string bookID = Console.ReadLine();
        //             Console.WriteLine("Enter Book Name: ");
        //             string bookName = Console.ReadLine();
        //             Console.WriteLine("Enter Author Book: ");
        //             string authorBook = Console.ReadLine();
        //             Console.WriteLine("Enter Book Price: ");
        //             int bookPrice = Convert.ToInt32(Console.ReadLine());
        //             Book book = new Book(bookID, bookName, authorBook, bookPrice);
        //             library.books.Add(book);
        //             break;
        //         case 2:
        //             library.Display();
        //             break;
        //         case 3:
        //             Console.WriteLine("Enter Book ID: ");
        //             string bookIDLocal = Console.ReadLine();
        //             if (bookIDLocal == null)
        //             {
        //                 Console.WriteLine("Book ID is required");
        //                 break;
        //             }
        //             library.FindBookByID(bookIDLocal);
        //             break;
        //         case 4:
        //             return;
        //         default:
        //             Console.WriteLine("Invalid choice. Please enter 1 -> 4");
        //             break;
        //             
        //     }
        // }
        

        #endregion
    }
}
