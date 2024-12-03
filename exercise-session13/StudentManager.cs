using Newtonsoft.Json;
using Exception = System.Exception;

namespace exercise_session13;

public class StudentManager
{
    private string pathName = "students.json";
    public List<Student> Students { get; set; }

    public StudentManager()
    {
        LoadData();
    }

    private void LoadData()
    {
        if (File.Exists(pathName))
        {
            Students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(pathName));
            Console.WriteLine("Load data successful");
        }
        else
        {
            Students = new List<Student>();
            Console.WriteLine("Data does not exist, creating a new instance");
        }
    }

    private void SaveData()
    {
        File.WriteAllText(pathName, JsonConvert.SerializeObject(Students, Formatting.Indented));
        Console.WriteLine("Save Data Successful");
    }

    public void AddStudent()
    {
        Console.WriteLine("====== Adding student =======");
        Console.WriteLine("Enter Student Id: ");
        string studentId = Console.ReadLine();
        
        Console.WriteLine("Enter Student Name: ");
        string studentName = Console.ReadLine();
        
        Console.WriteLine("Enter Student Math score: ");
        int mathScore = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Student Literature score: ");
        int literatureScore = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Student English score: ");
        int englishScore = Convert.ToInt32(Console.ReadLine());

        Student student = new Student(studentId, studentName, mathScore, literatureScore, englishScore);
        
        if (Students.Any(item => item.StudentID == student.StudentID))
        {
            throw new Exception("Student already exists");
        }
        else
        {
            Students.Add(student);
            SaveData();
            Console.WriteLine("Add Student Successful");
        }
    }

    public void SearchStudent()
    {
        Console.WriteLine("===== Search Student ===========");
        Console.WriteLine("Enter Student Name: ");
        string studentName = Console.ReadLine();
        if (string.IsNullOrEmpty(studentName))
        {
            throw new Exception("Student name is empty");
        }
        
        Student student = Students.FirstOrDefault(item => item.StudentName == studentName);
        
        if (student == null)
        {
            throw new Exception("Student not found");
        }
        
        student.DisplayInfo();
    }
    
    public void UpdateScore()
    {
        Console.WriteLine("===== Update Score ===========");
        Student student = FindStudent();
        
        Console.WriteLine("Input Math score");
        int mathScore = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Input Literature Score");
        int literatureScore = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Input English Score");
        int englishScore = Convert.ToInt32(Console.ReadLine());
        
        student.MathScore = mathScore;
        student.LiteratureScore = literatureScore;
        student.EnglishScore = englishScore;
        SaveData();
        Console.WriteLine("Update Student Score Successful");
        student.DisplayInfo();
    }

    public void CalculateAvarageScore()
    {
        Console.WriteLine("===== Calculate Avarage Score ===========");
        Student student = FindStudent();
        double calculateAvarageScore = student.CalculateAvarageScore();

        if (calculateAvarageScore >= 8 && calculateAvarageScore <= 10)
        {
           Console.WriteLine("Avarage Score is Excellent");
        } 
        else if (calculateAvarageScore >= 6.5 && calculateAvarageScore < 8)
        {
            Console.WriteLine("Avarage Score is Good");
        }
        else if (calculateAvarageScore >= 5 && calculateAvarageScore <= 6.5)
        {
            Console.WriteLine("Avarage Score is Average");
        }
        else
        {
            Console.WriteLine("Avarage Score is Poor");
        }

    }

    public void DeleteStudent()
    {
        Console.WriteLine("===== Delete Student ===========");
        Student student = FindStudent();
        
        Students.Remove(student);
        SaveData();
        Console.WriteLine($"Delete Student {student.StudentName} Successful");
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("========= Display Student Info ============");
        foreach (Student student in Students)
        {
            student.DisplayInfo();
            double calculateAvarageScore = student.CalculateAvarageScore();

            if (calculateAvarageScore >= 8 && calculateAvarageScore <= 10)
            {
                Console.WriteLine("Avarage Score is Excellent");
            } 
            else if (calculateAvarageScore >= 6.5 && calculateAvarageScore < 8)
            {
                Console.WriteLine("Avarage Score is Good");
            }
            else if (calculateAvarageScore >= 5 && calculateAvarageScore <= 6.5)
            {
                Console.WriteLine("Avarage Score is Average");
            }
            else
            {
                Console.WriteLine("Avarage Score is Poor");
            }
            
            Console.WriteLine("=============================================");
        }
    }

    public void DisplayStudentInfo(string orderBy)
    {
        Console.WriteLine($"========= Display Student Info {orderBy} ============");
        if (orderBy == "avarageScore")
        {
            List<Student> students = Students.OrderBy(student => student.CalculateAvarageScore()).ToList();
            foreach (Student student in students)
            {
                student.DisplayInfo();
                double calculateAvarageScore = student.CalculateAvarageScore();

                if (calculateAvarageScore >= 8 && calculateAvarageScore <= 10)
                {
                    Console.WriteLine("Avarage Score is Excellent");
                } 
                else if (calculateAvarageScore >= 6.5 && calculateAvarageScore < 8)
                {
                    Console.WriteLine("Avarage Score is Good");
                }
                else if (calculateAvarageScore >= 5 && calculateAvarageScore <= 6.5)
                {
                    Console.WriteLine("Avarage Score is Average");
                }
                else
                {
                    Console.WriteLine("Avarage Score is Poor");
                }
            }
        }
        else if(orderBy == "studentName")
        {
            List<Student> students = Students.OrderBy(student => student.StudentName).ToList();

            foreach (Student student in students)
            {
                student.DisplayInfo();
            }
        }
        Console.WriteLine("=============================================");
    }

    private Student FindStudent()
    {
        Console.WriteLine("Enter Student ID: ");
        string studentID = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(studentID))
        {
            throw new Exception("Student ID is empty");
        }
        
        Student student = Students.FirstOrDefault(item => item.StudentID == studentID);
        
        if(student == null) throw new Exception("Student not found");
        return student;
    }
    
}