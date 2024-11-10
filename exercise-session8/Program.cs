// See https://aka.ms/new-console-template for more information


using exercise_session8;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Bài 1

        Bai1.Method();

        #endregion

        #region Bài 2
        Console.WriteLine("Please enter a number: ");
        int target = Convert.ToInt32(Console.ReadLine());
        
        List<int> rerult = Bai2.Method(target);
        Console.WriteLine(String.Join(", ", rerult));

        #endregion

        #region Bai 3

        List<int> numbers = new List<int> {1, 1, 2, 2, 2, 3, 4, 4, 5};
        numbers.Sort();
        List<int> result3 = Bai3.RemoveDup(numbers);
        Console.WriteLine(String.Join(", ", result3));
        #endregion
        
        #region Bai 4

        List<int> numbers4 = new List<int> { 1, 1, 1, 2, 2, 3 };
        List<int> result4 = Bai4.GetNumsFrequent(numbers4);
        Console.WriteLine(String.Join(", ", result4));
        #endregion
        
        #region Bai 5

        List<int> prices = new List<int> {7, 1, 5, 3, 6, 4 };
        int bestPrice = Bai5.CalBestPrice(prices);
        Console.WriteLine(bestPrice);
        #endregion
    }
}
