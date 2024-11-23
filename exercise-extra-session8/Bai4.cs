namespace exercise_extra_session8;

public class Bai4
{
    public static int Method(List<int> numbers)
    {
        List<int> oddList = new List<int>();
        
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                oddList.Add(number);
            }
        }

        int sum = 0;
        foreach (int number in oddList)
        {
            sum += number;
        }
        
        int result = sum / oddList.Count;
        return result;
    }
}