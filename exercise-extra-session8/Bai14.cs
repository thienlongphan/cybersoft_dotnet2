namespace exercise_extra_session8;

public class Bai14
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            if (str.Contains("a"))
            {
                result.Add(str);
            }  
        }
        return result;
    }
}