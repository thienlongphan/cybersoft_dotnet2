namespace exercise_extra_session8;

public class Bai19
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            result.Add(str.ToUpper());
        }
        return result;
    }
}