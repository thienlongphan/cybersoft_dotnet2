namespace session10;

public class Officers : People
{
    public string Position {get; set;}
    public string Departments {get; set;}

    public Officers(string id, string name, string birthday, string gender, string email, string position, string departments) : base(id, name, birthday, gender, email)
    {
        Position = position;
        Departments = departments;
    }
}