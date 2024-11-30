namespace session10;

public class Lecturer : People
{
    public string Specialized { get; set; }
    public string Degree { get; set; }

    public Lecturer(string id, string name, string birthday, string gender, string email, string specialized, string degree) : base(id, name, birthday, gender, email)
    {
        Specialized = specialized;
        Degree = degree;
    }
}