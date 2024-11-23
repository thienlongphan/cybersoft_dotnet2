using exercise_extra_session8;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World! extra session 8");

        #region Extra1

        List<int> numbers = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };

        #region Bai1
        int result1 = Bai1.Method(numbers);
        Console.WriteLine($"Bai1 result: {result1}");
        #endregion
        
        #region Bai2
        int result2 = Bai2.Method(numbers);
        Console.WriteLine($"Bai2 result: {result2}");
        #endregion
        
        #region Bai3
        int result3 = Bai3.Method(numbers);
        Console.WriteLine($"Bai3 result: {result3}");
        #endregion
        
        #region Bai4
        int result4 = Bai4.Method(numbers);
        Console.WriteLine($"Bai4 result: {result4}");
        #endregion
        
        #region Bai5

        List<int> result5 = Bai5.Method(numbers);
        Console.WriteLine($"Bai4 result: {string.Join(", ", result5)}");

        #endregion
        
        #region Bai6
        int result6 = Bai6.Method(numbers);
        Console.WriteLine($"Bai6 result: {result6}");
        #endregion
        
        #region Bai7
        int result7 = Bai7.Method(numbers);
        Console.WriteLine($"Bai7 result: {result7}");
        #endregion
        
        #region Bai8
        int result8 = Bai8.Method(numbers);
        Console.WriteLine($"Bai8 result: {result8}");
        #endregion
        
        #region Bai9
        int result9 = Bai9.Method(numbers);
        Console.WriteLine($"Bai9 result: {result9}");
        #endregion
        
        #region Bai10
        List<int> result10 = Bai10.Method(numbers);
        Console.WriteLine($"Bai10 result: {string.Join(", ", result10)}");
        #endregion

        #endregion
        
        #region Extra2
        List<string> strings = new List<string> { "banana", "apple","orange", "mango", "pineapple", "grape", "melon", "kiwi" };
        
        #region Bai11
        int result11 = Bai11.Method(strings);
        Console.WriteLine($"Bai11 result: {result11}");
        #endregion
        
        #region Bai12
        List<string> result12 = Bai12.Method(strings);
        Console.WriteLine($"Bai12 result: {string.Join(", ", result12)}");
        #endregion
        
        #region Bai13
        string result13 = Bai13.Method(strings);
        Console.WriteLine($"Bai13 result: {result13}");
        #endregion
        
        #region Bai14
        List<string> result14 = Bai14.Method(strings);
        Console.WriteLine($"Bai14 result: {string.Join(", ", result14)}");
        #endregion
        
        #region Bai15
        List<string> result15 = Bai15.Method(strings);
        Console.WriteLine($"Bai15 result: {string.Join(", ", result15)}");
        #endregion
        
        #region Bai16
        int result16 = Bai16.Method(strings);
        Console.WriteLine($"Bai16 result: {result16}");
        #endregion
        
        #region Bai17
        string result17 = Bai17.Method(strings);
        Console.WriteLine($"Bai17 result: {result17}");
        #endregion

        #region Bai18
        List<string> result18 = Bai18.Method(strings);
        Console.WriteLine($"Bai18 result: {string.Join(", ", result18)}");
        #endregion

        #region Bai19
        List<string> result19 = Bai19.Method(strings);
        Console.WriteLine($"Bai19 result: {string.Join(", ", result19)}");
        #endregion
        
        #region Bai20
        List<string> result20 = Bai20.Method(strings);
        Console.WriteLine($"Bai20 result: {string.Join(", ", result20)}");
        #endregion
        
        #endregion
    }
}
