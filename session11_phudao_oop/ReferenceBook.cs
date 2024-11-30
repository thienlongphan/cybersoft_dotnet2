namespace session11_phudao_oop;

public class ReferenceBook : Book
{
    public string topic;
    public string subject;

    public ReferenceBook(
        string bookId, 
        string bookName, 
        string author, 
        double price, 
        string topic, 
        string subject) : base(bookId, bookName, author, price)
    {
        this.topic = topic;
        this.subject = subject;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Topic: {topic}, Subject: {subject}");
    }
}