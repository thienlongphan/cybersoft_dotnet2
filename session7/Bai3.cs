namespace session7;

public class Bai3
{
    public static List<string> TimChuoiBatDauM(List<string> strings)
    {
        List<string> result = new List<string>();
        foreach (string s in strings)
        {
            if (s.StartsWith("m"))
            {
                result.Add(s);
            }
        }
        return result;
    }
}