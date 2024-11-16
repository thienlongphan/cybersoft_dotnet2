namespace session8;

public class TwoSum
{
    public static List<int>? TwoSumMethod(List<int> nums, int target)
    {
        for (int i = 0; i < nums.Count - 1; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new List<int> { nums[i], nums[j] };
                }
            }
        }
        
        return null;
    }

    public static List<int>? TwoSumDic(List<int> nums, int target)
    {
        // Khai báo Dictionary để đánh dấu từng số trong danh sách lst
        // key - 
        Dictionary<int, int> seenDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Count; i++)
        {
            int result = target - nums[i];
            if (seenDict.ContainsKey(result))
            {
                return new List<int> { seenDict[result], i};
            }
            else
            {
                seenDict.Add(nums[i], i);
            }
        }
        
        return null;
        
    }
}