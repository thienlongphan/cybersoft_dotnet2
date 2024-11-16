  using session8;

  internal class Program
  {
      private static void Main(string[] args)
      {
          // Console.WriteLine("Please enter a number: ");
          // int target = Convert.ToInt32(Console.ReadLine());
          // List<int> lst = new List<int> {2 ,7 ,11, 9 ,8};
          // List<int>? result = TwoSum.TwoSumDic(lst, target);
          // if (result != null)
          // {
          //     Console.WriteLine(String.Join(" ", result));
          // }

          #region Bai 2
            List<string> lst = new List<string> {"apple", "mango", "melon", "apple", "pineapple", "mango"};
            Dictionary<string, int> result = WordCount.CheckCount(lst);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            #endregion
            
            #region Khai niem 
            #endregion
      }
  }
