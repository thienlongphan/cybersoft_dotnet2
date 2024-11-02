// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//
// Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
//
// Console.WriteLine("Bài 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
// ____*
// ___* *
// __*__ *
// _*     *
// *********

// Console.WriteLine("Bài 3: Nhập vào số n từ bàn phím. Kiểm tra số đó có phải là số đôi xứng không");
// Console.WriteLine("VD: Số 121, 1221, 12321,... là những số đối xứng");

#region bai 1
// Console.WriteLine("Please enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 2; i <= userInput; i++)
// {
//     bool isPrime = true;
//
//     for (int j = 2; j <= Math.Sqrt(userInput); j++)
//     {
//         if(i != j && i % j == 0) { isPrime = false; break; }
//     }
//
//     if (isPrime)
//     {
//         Console.Write($"{i} ,");
//     }
// }


#endregion

#region bai 2
Console.WriteLine("Please enter a number: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < height - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < 2 * i + 1; k++)
    {
        if (i != height - 1)
        {
            if (k == 0 || k == 2 * i)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else
        {
            Console.Write("*");
        }
       
        
    }
    Console.WriteLine();
}
#endregion

#region bai 3
// Console.WriteLine("Please enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int originNumber = userInput;
// int reversed = 0;
//
// while (userInput > 0)
// {
//     reversed = reversed * 10 + userInput % 10;
//     userInput /= 10;
// }
//
// if (reversed == originNumber)
// {
//     Console.WriteLine($"The {originNumber} is doi xung");
// }
// else
// {
//     Console.WriteLine($"The {originNumber} is not doi xung");
// }

#endregion