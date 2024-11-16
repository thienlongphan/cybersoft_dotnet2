namespace session8;

public class WordCount
{
    public static Dictionary<string, int> CheckCount(List<string> lst)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < lst.Count; i++)
        {
            if (dic.ContainsKey(lst[i]))
            {
                dic[lst[i]] += dic[lst[i]];
            }
            else
            {
                dic.Add(lst[i], 1);
            }    
        }
        return dic;
    }
}