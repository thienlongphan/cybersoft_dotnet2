namespace session6;

public class Method
{
    /// <summary>
    /// Hàm kiểm tra số nguyên tố
    /// </summary>
    /// <param name="number">number có kiểu số nguyên dương</param>
    /// <returns>True: là số nguyên tố. False: không phải số nguyên tố</returns>
    public static bool IsPrime(int number)
    {
        if(number < 2) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0) return false;
        }
        return true;
    }

    public static void PrintTriangle(int number)
    {
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}