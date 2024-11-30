namespace session10;

public class Student : People
{
    public string AverageScore {get; set;}
    public string ClassRoom {get; set;}
    
    public Student(string id, string name, string birthday, string gender, string email, string averageScore, string classRoom) : base(id, name ,birthday, gender, email)
    {
        
        AverageScore = averageScore;
        ClassRoom = classRoom;
    }
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Classname: {0}", ClassRoom);
        Console.WriteLine("AverageScore: {0}", AverageScore);
    }
}