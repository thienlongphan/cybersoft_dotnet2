namespace exercise_extra_session8;

public class Bai1
{
    public static int Method(List<int> numbers)
    {
        int result = 0;
        foreach (int number in numbers)
        {
            if (number > 50)
            {
                result += number;
            }
        }
        
        return result;
    }
}