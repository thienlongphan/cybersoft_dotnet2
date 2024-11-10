

namespace exercise_session8;

public class Bai1
{
    public static void Method()
    {   
        List<int> IstNumber = new List<int> {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        int sum = 0;

        foreach (int item in IstNumber)
        {
            sum += item;
        }
        
        Console.WriteLine(sum);
    }
}