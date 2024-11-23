namespace exercise_extra_session8;

public class Bai5
{
    public static List<int> Method(List<int> numbers)
    {
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }
        
        return result;
    }
}