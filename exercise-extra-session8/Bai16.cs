namespace exercise_extra_session8;

public class Bai16
{
    public static int Method(List<string> strings)
    {
        int count = 0;
        foreach (string s in strings)
        {
            if (s.Length < 6)
            {
                count++;
            }
        }
        return count;
    }
}