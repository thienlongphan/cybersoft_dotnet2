namespace session11_phudao_oop;

public class Book
{
    public string bookId;
    public string bookName;
    public string author;
    public double price;

    public Book(string bookId, string bookName, string author, double price)
    {
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }

    // Dùng virtual để cho phép các class con override lại phương thức này
    // override: ghi đè
    // - dùng lại phương thức class cha
    // - thay đổi cách thức hoạt động của phương thức
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book: BookId-{bookId}, Book name-{bookName}, Book author-{author}, Book price-{price}");
    }
}