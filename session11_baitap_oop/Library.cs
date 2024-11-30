namespace session11_baitap_oop;

public class Library
{
    public string libraryID;
    public string libraryName;
    public List<Book> books;

    public Library(string libraryID, string libraryName)
    {
        this.libraryID = libraryID;
        this.libraryName = libraryName;
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void Display()
    {
        foreach (Book book in books)
        {
            book.DisplayBook();
        }
    }

    public void FindBookByID(string bookID)
    {
        foreach (Book book in books)
        {
            if (book.bookID == bookID)
            {
                book.DisplayBook();
                return;
            }
        }
        
        Console.WriteLine("No book found");
    }
}