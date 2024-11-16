namespace session_optional;

public class WordCount
{
    public static void Process()
    {
        Console.WriteLine("Enter Paragraph:");
        string text = Console.ReadLine();
        // B1: Tách từ
        string[] words = text.Split(new[] {" ", ",", ".", "!", "?"}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            // Convert word to lowercase
            string wordLower = word.ToLower();
            if (wordCount.ContainsKey(wordLower))
            {
                wordCount[wordLower]++;
            }
            else
            {
                wordCount.Add(wordLower, 1);
            }
        }
        Console.WriteLine("Frequent of each word: ");
        foreach (KeyValuePair<string, int> pointer in wordCount)
        {
            Console.WriteLine($"{pointer.Key}: {pointer.Value}");
        }
    }
}