namespace exercise_extra_session8;

public class Bai12
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            if (str.Length > 5)
            {
                result.Add(str);
            }
        }
        return result;
    }
}