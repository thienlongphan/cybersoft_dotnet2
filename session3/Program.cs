// See https://aka.ms/new-console-template for more information


#region If else

// Nhập số nguyên từ bàn phím sẽ in ra số lẻ hay số chẵn
// INPUT


// Console.WriteLine("Mời nhập số");
//     string num = Console.ReadLine();
//     int formatNum = Convert.ToInt32(num);
//     if(formatNum % 2 == 0) 
//     {
//         Console.WriteLine($"Số {num} là số chẵn");
//     }
//     else {
//         Console.WriteLine($"Số {num} là số lẻ");
//     }

// OUTPUT

// PROCESS


// INPUT
// Nhập điểm trung bình hs
// Console.WriteLine("Nhập điểm trung bình của hs:");
// string? point = Console.ReadLine();

// OUTPUT

// PROCESS
// nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// >=9: Xuất sắc
// 8 <= điểm < 9: giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm <6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém
// double formatPoint = Convert.ToDouble(point);
// if(formatPoint >= 9) 
// {
//     Console.WriteLine("Xuất sắc");
// }
// else if (formatPoint > 8 && formatPoint < 9) {
//     Console.WriteLine("Giỏi");
// }
// else if (formatPoint >= 6.5 && formatPoint < 8) 
// {
//     Console.WriteLine("Khá");
// }
// else if (formatPoint >= 5 && formatPoint < 6.5) 
// {
//     Console.WriteLine("Trung Bình");
// }
// else if (formatPoint >= 3.5 && formatPoint < 5) {
//     Console.WriteLine("Yếu");
// }
// else 
// {
//     Console.WriteLine("Kém");
// }


// Nhập vào 1 số có 3 chữ số tính tổng 3 số đó
// Console.WriteLine("Nhập 3 chữ số:");
// string? num = Console.ReadLine();
// int formatNum = Convert.ToInt32(num);

// if(formatNum > 99 && formatNum <= 999) 
// {
//     int numOne = formatNum / 100;
//     int remain = formatNum % 100;
//     int numTwo = remain / 10;
//     int numThree = remain % 10;
//     int sum = numOne + numTwo + numThree;
//     Console.WriteLine($"Tổng 3 số {numOne} {numTwo} {numThree}: {sum}");

// }
// else 
// {
//     Console.WriteLine($"Bạn nhập khác 2 chữ số");
// }

// Dùng khi điều kiện độc lập nhau nhưng cost thực thi cao
// if()
// if()
// if()

// Dùng khi điều kiện liên quan nhau nhưng cost thực thi thấp
// if()
// else if()
// else if()

// Bài tập
// nhập ngày (dd/mm/yyyy). In ra thứ mấy trong tuần
// VD: 23/10/2024 => Thứ tư
// Lưu ý: không dùng thư viện

#region Bài tập Ngày tháng năm

// INPUT
/*
 * Nhập ngày (dd)
 * Nhập tháng (mm)
 * Nhập năm (yyyy)
 */
Console.WriteLine("Please input Date (mm): ");
string? inputDate = Console.ReadLine();
int inputDateInt = Convert.ToInt32(inputDate);

Console.WriteLine("Please input month(mm): ");
string? inputMonth = Console.ReadLine();
int inputMonthInt = Convert.ToInt32(inputMonth);

Console.WriteLine("Please input year(yyyy): ");
string? inputYear = Console.ReadLine();
int inputYearInt = Convert.ToInt32(inputYear);


// OUTPUT
string dayOfWeek;

// PROCESS
int d = inputDateInt;
int m;
if (inputMonthInt == 1)
{
    m = 13;
}
else if (inputMonthInt == 2)
{
    m = 14;
}
else
{
    m = inputMonthInt;
}

int k = inputYearInt % 100;
int j = inputYearInt / 100;

int f = (d + (13 * (m + 1)) / 5 + k  + k/4 + j/4 - 2 * j) % 7;
dayOfWeek = f switch
{
    0 => "Saturday",
    1 => "Sunday",
    2 => "Monday",
    3 => "Tuesday",
    4 => "Wednesday",
    5 => "Thursday",
    6 => "Friday",
    _ => "N/A"
};

Console.WriteLine($"Day of week is: {dayOfWeek}");

#endregion


// Switch case
// c1: dùng switch...case
// nhập số 1 -> 10


// Console.WriteLine("Nhập số:");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
//
// switch (formatNumber)
// {
//     case 1:
//         Console.WriteLine($"số 1");
//         break;
//     case 2:
//         Console.WriteLine($"số 2");
//         break;
//     case 3:
//         Console.WriteLine($"số 3");
//         break;
//     case 4:
//         Console.WriteLine($"số 4");
//         break;
//     case 5:
//         Console.WriteLine($"số 5");
//         break;
//     case 6:
//         Console.WriteLine($"số 6");
//         break;
//     case 7:
//         Console.WriteLine($"số 7");
//         break;
//     case 8:
//         Console.WriteLine($"số 8");
//         break;
//     case 9:
//         Console.WriteLine($"số 9");
//         break;
//     default:
//         Console.WriteLine("Số 10");
//         break;
// }
//
// // c2: dùng switch expression
// var result = formatNumber switch
// {
//     1 => "số 1",
//     _ => "Số 10"
// };

#endregion