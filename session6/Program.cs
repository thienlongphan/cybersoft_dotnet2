// See https://aka.ms/new-console-template for more information

using session6;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Kiểm tra số nguyên tố

        // Console.WriteLine("Please enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // if (Method.IsPrime(number))
        // {
        //     Console.WriteLine("The number {0} is prime.", number);
        // }
        // else
        // {
        //     Console.WriteLine("The number {0} is not prime.", number);
        // }
        #endregion

        #region In ra tam giác vuông

        // Console.WriteLine("Please enter a number: ");
        // int number = int.Parse(Console.ReadLine());
        // Method.PrintTriangle(number);
        #endregion

        #region Collection trong C#
        // Data structure
        // List
        // List<int> numbers = new List<int>();
        // List<string> names = new List<string> { "Long", "Thien", "Phan" };
        // Console.WriteLine($"name 1: {names[1]}");
        // Console.WriteLine($"nghich dao: {names[^2]}");
        // Lưu ý: Writeline chỉ in được kiểu dữ liệu nguyên thủy in, float, string, double..
        // Còn kiểu dữ liệu collection thì chỉ in ra địa chỉ vùng nhớ của biến đó
        // Console.WriteLine(String.Join(", ", names));
        
        // mini ex
        Console.WriteLine("please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Please enter value of {i}: ");
            int item = Convert.ToInt32(Console.ReadLine());
            numbers.Insert(i, item);
        }
        // c1: for
        // Console.WriteLine("List items: ");
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.Write("{0}, ", numbers[i]);
        // }
        
        //c2: foreach
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
        #endregion
    }
}
