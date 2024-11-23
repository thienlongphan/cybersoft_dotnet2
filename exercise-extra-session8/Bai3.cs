namespace exercise_extra_session8;

public class Bai3
{
    public static int Method(List<int> numbers)
    {
        int maxNumber = 0;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        return maxNumber;
    }
}