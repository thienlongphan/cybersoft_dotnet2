namespace session11_baitap_oop;

public class Book
{
    public string bookID;
    public string bookName;
    public string author;
    public int price;

    public Book(string bookID, string bookName, string author, int price)
    {
        this.bookID = bookID;
        this.bookName = bookName;
        this.author = author;
        this.price = price;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Book: bookID = {bookID}, bookName = {bookName}, author = {author}, price = {price}");
    }
}