namespace exercise_extra_session8;

public class Bai7
{
    public static int Method(List<int> numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number == 15)
            {
                count++;
            }
        }
        return count;
    }
}