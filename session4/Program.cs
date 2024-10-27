// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// while
// for
// do...while

#region while statement

// in ra cac so tu 1 den n voi n la so duoc nhap tu ban phim
// B1. Khoi tao gia tri lap
// B2. Xac dinh dieu kien lap (tinh toi truong hop dung)
// B3. Thay doi dieu kien lap
// Console.WriteLine("Press any number...");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
//
// int count = 1;
//
// while (count <= formatNumber)
// {
//     Console.WriteLine(count);
//     count++;
// }

// Nhap so n tu ban phim in ra tong cac so tu 1 -> n
// s = 1 + 2 + 3...n;
// Console.WriteLine("Press any number...");
// string? number2 = Console.ReadLine();
// int formatNumber2 = Convert.ToInt32(number2);
// int count2 = 1;
// int sum = 0;
// while (count2 <= formatNumber2)
// {
//     sum += count2;
//     count2++;
// }
// Console.WriteLine($"The sum is {sum}");

// Tinh giai thua cua 1 so
// s = 1 * 2 * 3 * 4 ...n;
// Console.WriteLine("Press any number...");
// string? number3 = Console.ReadLine();
// int formatNumber3 = Convert.ToInt32(number3);
//
// int count3 = 1;
// int giaiThua = 1;
//
// while (count3 <= formatNumber3)
// {
//     giaiThua *= count3;
//     count3++;
// }
//
// Console.WriteLine("Giai Thua: {0}", giaiThua);

// In bang cuu chuong cua n voi n nhap tu ban phim
// Console.WriteLine("Press any type number...");
// int number4 = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (count <= 10)
// {
//     Console.WriteLine($"{number4} * {count} = {number4 * count}");
//     count++;
// }

// Kiem tra co phai so nguyen to
// Console.WriteLine("Press any type number...");
// int number5 = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// bool flag = false;
// while (count < number5)
// {
//     if (number5 % count == 0)
//     {
//         Console.WriteLine("Break it's not Nguyen To");
//         flag = true;
//         break;
//     }
//     count++;
// }
//
// if (!flag)
// {
//     Console.WriteLine("it's Nguyen To");
// }

#endregion

#region For statement 
// In bang cuu chuong
// Console.WriteLine("Press any type number...");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{number} * {i} = {number * i}");
// }

// So nguyen to 
// Console.WriteLine("Press any type number...");
// int number2 = Convert.ToInt32(Console.ReadLine());
// bool flag = false;
// for (int i = 2; i < Math.Sqrt(number2); i++)
// {
//     if (number2 % i == 0)
//     {
//         Console.WriteLine("It's not nguyen to");
//         flag = true;
//         break;
//     }
// }
//
// if (!flag)
// {
//     Console.WriteLine("It's nguyen to");
// }

// for long nhau => ma tran (nhieu mang ket hop voi nhau)
/*
 * 1234
 * 4567
 */
// Console.WriteLine("Please enter row: ");
// int row = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Please enter col: ");
// int col = Convert.ToInt32(Console.ReadLine());
// string result = "";
// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < col; j++)
//     {
//         result += "*";
//     }
//
//     result += "\n";
// }
// Console.WriteLine(result);

// nhap vo la so n. In ra tam giac can
//    *
//   **
//   ***
//  ****
// *****
// ******
// Console.WriteLine("Please enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 0; i < num; i++)
// {
//     for (int j = 0; j < num - i - 1; j++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int k = 0; k < 2 * i + 1; k++)
//     {
//         Console.Write("*");
//     }
//
//     Console.WriteLine();
// }

// Bai tap -> cho chieu dai va chieu rong
// in 
// ***********
// *         *
// *         *
// *         *
// ***********

#endregion

