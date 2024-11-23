namespace exercise_extra_session8;

public class Bai9
{
    public static int Method(List<int> numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 5 == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}