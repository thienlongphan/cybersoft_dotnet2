namespace session11_baitap_oop;

public class ClassRoom
{
    public string classId;
    public string className;
    public List<Student> students;

    public ClassRoom(string classId, string className)
    {
        this.classId = classId;
        this.className = className;
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }

    public void ShowStudents()
    {
        foreach (Student student in students)
        {
            student.DisplayInfo();
        }
    }

    public void FindStudentById(string studentId)
    {
        // c1: vòng lặp
        foreach (Student student in students)
        {
            if (student.studentId == studentId)
            {
                student.DisplayInfo();
                return;
            }
        }
        
        Console.WriteLine($"Student {studentId} not found in class {className}");
    }
}