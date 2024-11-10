namespace session7;

public class Bai1
{
    public static int TinhTongSoLonHon50(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number > 50)
            {
                sum += number;
            }
        }
        return sum;
    }
}