using Newtonsoft.Json;

namespace session11_phudao_oop;

public class LibraryManager
{
    public string libraryId;
    public string libraryName;
    public List<Book> books; // dùng class cha làm đại diện danh sách trong thư viện
    public string filePath = "library.json";
    
    
    public LibraryManager(string libraryId, string libraryName)
    {
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        LoadFromFile();
    }

    private void LoadFromFile() // dùng khi khởi tạo class LibraryManager
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath); // đọc file;
            
            // chuyển json thành danh sách 
            books = JsonConvert.DeserializeObject<List<Book>>(json);
            Console.WriteLine("Load file successfully");
        }
        else
        {
            books = new List<Book>();
            Console.WriteLine("File not exist. So create new list books");
        }
    }

    private void SaveToFile() // dùng sau khi add hoặc remove sách
    {
        // B1: Chuyển danh sách thành json
        string json = JsonConvert.SerializeObject(books, Formatting.Indented);
        
        // B2: Lưu vào file json
        File.WriteAllText(filePath, json);
        Console.WriteLine("Save file successfully");
    }

    public void AddBook(Book book)
    {
        // Kiem tra ma sach da ton tai chua
        // lamda expression
        if (books.Any(item => item.bookId == book.bookId))
        {
            Console.WriteLine("Book already exist. Please choose another one.");
        }
        else
        {
            books.Add(book);
            SaveToFile(); // Lưu vào file json
            Console.WriteLine("Add book successfully");
        }
    }

    public void AddTextBook()
    {
        Console.WriteLine("enter book code");
        string bookId = Console.ReadLine();
        
        Console.WriteLine("enter book name");
        string bookName = Console.ReadLine();
        
        Console.WriteLine("enter book author");
        string bookAuthor = Console.ReadLine();
        
        Console.WriteLine("enter book price");
        double bookPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("enter book subject");
        string bookSubject = Console.ReadLine();
        
        Console.WriteLine("enter book grade");
        string bookGrade = Console.ReadLine();

        TextBook textBook = new TextBook(bookId, bookName, bookAuthor, bookPrice, bookSubject, bookGrade);
        AddBook(textBook);
    }
    
    // Hàm thêm reference book
    public void AddReferenceBook()
    {
        Console.WriteLine("enter book code");
        string bookId = Console.ReadLine();
        
        Console.WriteLine("enter book name");
        string bookName = Console.ReadLine();
        
        Console.WriteLine("enter book author");
        string bookAuthor = Console.ReadLine();
        
        Console.WriteLine("enter book price");
        double bookPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("enter book subject");
        string bookSubject = Console.ReadLine();
        
        Console.WriteLine("enter book publisher");
        string bookPublisher = Console.ReadLine();

        ReferenceBook referenceBook = new ReferenceBook(bookId, bookName, bookAuthor, bookPrice, bookSubject, bookPublisher);
        AddBook(referenceBook);
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("\n==== Library Books ====");
        if (books.Count == 0)
        {
            Console.WriteLine("There are no books in this library.");
            return;
        }
        
        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }

}