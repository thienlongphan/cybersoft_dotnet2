namespace exercise_extra_session8;

public class Bai15
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            if (str[0].ToString().ToLower() == "m")
            {
                result.Add(str);
            }
        }
        return result;
    }
}