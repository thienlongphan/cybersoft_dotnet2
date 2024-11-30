namespace session11_baitap_oop;

public class Student
{
    public string studentId;
    public string studentName;
    public int age;

    public Student(string studentId, string studentName, int age)
    {
        this.studentId = studentId;
        this.studentName = studentName;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Id: {studentId}, Student Name: {studentName}, Age: {age}");
    }
}