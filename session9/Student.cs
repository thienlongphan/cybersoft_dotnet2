namespace session9;

public class Student
{
    public string fullName;
    public int age;
    public string sex;
    public string email;
    public bool check;

    public void Display()
    {
        Console.WriteLine($"Full Name of student: {fullName}");
        Console.WriteLine($"Age of student: {age}");
        Console.WriteLine($"Email of student: {email}");
        Console.WriteLine($"Sex of student: {sex}");
        Console.WriteLine("------------------------------");
    }
}