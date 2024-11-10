namespace exercise_session8;

public class Bai5
{
    public static int CalBestPrice(List<int> prices)
    {
        List<int> results = new List<int>();
        int bestPrice = 0;
        for (int i = 0; i < prices.Count; i++)
        {
            
            for (int j = i + 1; j < prices.Count; j++)
            {
                results.Add(prices[j] - prices[i]);
            }
        }
        foreach (int item in results)
        {
            if (bestPrice < item)
            {
                bestPrice = item;
            }
        }
        return bestPrice;
    }
}