namespace session7;

public class Bai4
{
    public static List<int> RemoveDuplicates(List<int> numbers)
    {
        List<int> result = new List<int> {numbers.ElementAt(0)};

        foreach (int number in numbers)
        {
            if (result.Contains(number) == false)
            {
                result.Add(number);
            }
        }
        
        return result;
    }
}