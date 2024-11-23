namespace exercise_extra_session8;

public class Bai8
{
    public static int Method(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number < 40)
            {
                sum += number;
            }
        }
        
        return sum;
    }
}