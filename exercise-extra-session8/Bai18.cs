namespace exercise_extra_session8;

public class Bai18
{
    public static List<string> Method(List<string> strings)
    {
        List<string> result = new List<string>();
        result = result.Concat(strings).ToList();
        result.Sort();
        return result;
    }
}