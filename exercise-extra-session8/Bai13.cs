namespace exercise_extra_session8;

public class Bai13
{
    public static string Method(List<string> strings)
    {
        string result = "";
        foreach (string str in strings)
        {
            if (str.Length > result.Length)
            {
                result = str;
            }
        }
        return result;
    }
}