

namespace exercise_session8;

public class Bai2
{
    public static List<int> Method(int target)
    {
        List<int> istNumber = new List<int> { 2, 7, 11, 15 };

        List<int> result = new List<int> { };
        for (int i = 0; i < istNumber.Count; i++)
        {
            for (int j = istNumber.Count - 1; j >= 0; j--)
            {
                int sum = istNumber[i] + istNumber[j];

                if (sum == target && i != j)
                {
                    result = new List<int> { i, j };
                    break;
                }
            }

            if (result.Count > 0)
            {
                break;
            }
        }
        
        return result;
    }
}