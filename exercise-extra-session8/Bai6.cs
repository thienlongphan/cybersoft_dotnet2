namespace exercise_extra_session8;

public class Bai6
{
    public static int Method(List<int> numbers)
    {
        int resultIndex = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 20)
            {
                resultIndex = i;
                break;
            }
        }
        return resultIndex;
    }
}