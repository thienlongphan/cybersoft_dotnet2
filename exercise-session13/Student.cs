namespace exercise_session13;

public class Student
{

    private string studentID;
    public string StudentID
    {
        get => studentID;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("StudentId cannot be null or empty.");
            }

            studentID = value;
        }
        
    }

    private string studentName;

    public string StudentName
    {
        get => studentName;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("StudentName cannot be null or empty.");
            }

            studentName = value;
        }
        
    }

    private int mathScore;

    public int MathScore
    {
        get => mathScore;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("MathScore cannot be less than zero.");
            }
            mathScore = value;
        } 
        
    }

    private int literatureScore;
    public int LiteratureScore 
    {   get => literatureScore;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("LiteratureScore cannot be less than zero.");
            }
            literatureScore = value;
        }
    }

    private int englishScore;

    public int EnglishScore
    {
        get => englishScore;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("EnglishScore cannot be less than zero.");
            }
            
            englishScore = value;
        }
    }

    public Student(string studentID, string studentName, int mathScore, int literatureScore, int englishScore)
    {
        StudentID = studentID;
        StudentName = studentName;
        MathScore = mathScore;
        LiteratureScore = literatureScore;
        EnglishScore = englishScore;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student ID: {0}", StudentID);
        Console.WriteLine("Student Name: {0}", StudentName);
        Console.WriteLine("Math Score: {0}", MathScore);
        Console.WriteLine("Literature Score: {0}", LiteratureScore);
        Console.WriteLine("English Score: {0}", EnglishScore);
    }

    public double CalculateAvarageScore()
    {
        double avarageScore = ((double)EnglishScore + (double)MathScore + (double)LiteratureScore) / 3;
        
        return avarageScore;
    }
    
}