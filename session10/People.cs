namespace session10;

public class People
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Birthday { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }

    public People(string id, string name, string birthday, string gender, string email)
    {
        ID = id;
        Name = name;
        Birthday = birthday;
        Gender = gender;
        Email = email;
    }
    
    public virtual void Display()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Birthday: {Birthday}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Email: {Email}");
    }
}