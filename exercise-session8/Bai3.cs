namespace exercise_session8;

public class Bai3
{
    public static List<int> RemoveDup(List<int> listNums)
    {
        List<int> result = new List<int>();
        foreach (int item in listNums)
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }
        
        return result;
    }
}