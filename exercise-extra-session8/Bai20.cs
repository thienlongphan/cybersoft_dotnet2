namespace exercise_extra_session8;

public class Bai20
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            result.Add(str == "banana" ? "pear" : str);
        }
        return result;
    }
}