namespace exercise_session8;

public class Bai4
{
    public static List<int> GetNumsFrequent(List<int> nums)
    {
        List<int> frequent = new List<int>();
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            int k = 0;
            for (int j = 0; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    k++;
                }
            }

            if (k >= 2)
            {
                frequent.Add(nums[i]);
            }
        }

        foreach (int item in frequent)
        {
            if(!result.Contains(item)) { result.Add(item); }
        }

        return result;
    }
}