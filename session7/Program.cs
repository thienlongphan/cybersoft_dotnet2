using System.Text.RegularExpressions;
using session7;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        #region Function trong List cua Collection
        // Khoi tao danh sach
        // List<int> numbers = new List<int>();
        // // Nhap n tu ban phim voi n la so luong phan tu cua mang
        // string? n = Console.ReadLine();
        // int nFormat = Convert.ToInt32(n);
        // for (int i = 0; i < nFormat; i++)
        // {
        //     Console.WriteLine("Please enter a number: ");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }
        //
        // Console.WriteLine("Danh sach phan tu da nhap la: ");
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        //
        // // sort
        // numbers.Sort();
        // Console.WriteLine("Danh sach phan tu da sort la: {0}", String.Join(", ", numbers));
        //
        // // Reverse
        // numbers.Reverse();
        // Console.WriteLine("Danh sach phan tu da reverse la: {0}", String.Join(", ", numbers));

        #endregion
        
        #region Bai 1

        // List<int> numbers = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        // int sum = Bai1.TinhTongSoLonHon50(numbers);
        // Console.WriteLine(sum);
        
        #endregion
        
        #region Bai 2: Tim so lan nhat cua mang
        // List<int> numbersTwo = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        // int max = Bai2.TimSoLonNhatMang(numbersTwo);
        // Console.WriteLine($"Max number is {max}");
        #endregion
        
        #region Bai 3: Tim Chuoi bat dau bang chu 'm'
        // List<string> chuoiList = new List<string> { "max", "min", "height", "width", "hello", "masstransit"};
        // Console.WriteLine(String.Join(", ", Bai3.TimChuoiBatDauM(chuoiList)));
        #endregion

        #region Bai 4: Remove Duplicate

        // List<int> numbers4 = new List<int> { 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 6 };
        // List<int> result = Bai4.RemoveDuplicates(numbers4);
        // Console.WriteLine("Remove duplicte: {0}", String.Join(", ", result));

        #endregion
        
        #region Tim hieu Dictionary trong Collection
        Dictionary<string, string> dic = new Dictionary<string, string>();
        // Them key - value vao dic
        dic.Add("name", "Long");
        dic["email"] = "long@long.com";
        
        // duyet dic
        // foreach (KeyValuePair<string, string> item in dic)
        // {
        //     Console.WriteLine($"{item.Key}: {item.Value}");
        // }
        
        // Chi duyet moi key hoac value => Y chang nhu list
        // c1
        // foreach (string str in dic.Keys)
        // {
        //     Console.WriteLine($"Key: {str}");
        // }
        
        // c2
        // for (int i = 0; i < dic.Keys.Count; i++)
        // {
        //     Console.WriteLine(dic.Keys.ElementAt(i));
        // }
        
        // update dic
        // dic["name"] = "Thien";
        // foreach (KeyValuePair<string, string> str in dic)
        // {
        //     Console.WriteLine("dic after update key {0} and value {1}", str.Key, str.Value);
        // }
        //
        // Xoa key value in dic
        // dic.Remove("name");
        // foreach (KeyValuePair<string, string> str in dic)
        // {
        //     Console.WriteLine("dic after delete key {0} and value {1}", str.Key, str.Value);
        // }
        #endregion
    }
}