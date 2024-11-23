namespace exercise_extra_session8;

public class Bai17
{
    public static string Method(List<string> strings)
    {
        int maxLength = 0;
        List<string> result = new List<string>();
        
        foreach (string s in strings)
        {
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
            }
        }

        int secondMax = 0;
        foreach (string s in strings)
        {
            if (s.Length > secondMax && s.Length < maxLength)
            {
                secondMax = s.Length;
            }
        }

        foreach (string s in strings)
        {
            if (s.Length == secondMax)
            {
                result.Add(s);
            }
        }
        return string.Join(", ", result);
    }
}