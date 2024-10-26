// See https://aka.ms/new-console-template for more information

#region Bài tập 1

// INPUT
// số ngày
Console.WriteLine("Nhập số ngày:");
string days = Console.ReadLine();
int daysFormat = Convert.ToInt32(days);

// OUTPUT
// Bao nhiêu tuần và ngày còn lại
double weeks = 0.0;
double remainderDays = 0.0;

// PROCESS
// 1 tuần = 7ngày
weeks = (daysFormat * 1) / 7;
remainderDays = (daysFormat * 1) % 7;
Console.WriteLine($"Số tuần là: {weeks} và ngày còn lại là: {remainderDays}"); 

#endregion


#region Bài tập 2

// INPUT
// 1. Giá trị đơn hàng
// 2. Phần Trăm giảm giá
Console.WriteLine("Nhập giá trị đơn hàng:");
string priceOrder = Console.ReadLine();
int priceOrderFormat = Convert.ToInt32(priceOrder);

Console.WriteLine("Nhập phần trăm giảm giá:");
string discount = Console.ReadLine();
int discountFormat = Convert.ToInt32(discount);

// OUTPUT
// Số tiền giảm giá
// Tổng giá trị đơn hàng sau giảm giá
double priceDiscount = 0.0;
double orderDiscounted = 0.0;


// PROCESS
// Tính số tiền giảm giá: 1 đơn hàng 10.000 vnd + giảm giá 10% (10/100) = 1000 vnd
priceDiscount = priceOrderFormat * discountFormat / 100;


// Tổng số tiền thanh toán sau khi giảm giá: 10.000 vnd - 1000 vnd = 9000 vnd
orderDiscounted = priceOrderFormat - priceDiscount;

Console.WriteLine($"Số tiền giảm giá: {priceDiscount} vnd và Tổng số tiền thanh toán sau khi giảm giá: {orderDiscounted} vnd");

#endregion

#region Bài tập 3

// INPUT
// Nhập Phút
Console.WriteLine("Nhập Phút:");
string minuteString = Console.ReadLine();
int minuteFormat = Convert.ToInt32(minuteString);


// OUTPUT
// Giờ và Phút. 
int hour = 0;
int minute = 0;

// PROCESS
// convert phút sang giờ và phút eg: 1h = 60p
hour = minuteFormat * 1 / 60;
minute = minuteFormat * 1 % 60;

Console.WriteLine($"Kết quả chuyển đổi của {minuteFormat} phút là: {hour} giờ và minute {minute}");

#endregion

#region Bài tập 4

// INPUT
// 1. Số tiền ăn:
Console.WriteLine("Nhập số tiền ăn: ");
string priceAmount = Console.ReadLine();
int priceAmountFormat = Convert.ToInt32(priceAmount);

// 2. phần trăm VAT
Console.WriteLine("Nhập số phần trăm VAT: ");
string vatPercent = Console.ReadLine();
int vatPercentFormat = Convert.ToInt32(vatPercent);


// OUTPUT
// In ra số tiền đã có VAT
int sumPrice = 0;

// PROCESS. Số tiền ăn: 100.000 vnd, tính tiền phần trăm VAT: 10% = 100.000 * 10 / 100, tổng tiền = 100.000 + 10.000 = 110.000
int vatPrice = priceAmountFormat * vatPercentFormat / 100;
sumPrice = priceAmountFormat + vatPrice;

Console.WriteLine($"Số tiền sau cộng thêm VAT: {sumPrice}");

#endregion

#region Bài tập 5

// INPUT
// Nhập vào theo đơn vị USD
Console.WriteLine($"Nhập tiền với đơn vị $: ");
string moneyUSD = Console.ReadLine();
int moneyUSDFormat = Convert.ToInt32(moneyUSD);

// OUTPUT
// In tiền ra theo đơn vị VND
int moneyVND = 0;

//PROCESS
// 1 usd = 25.000 vnd -> x usd * 25.000 vnd 
moneyVND = moneyUSDFormat * 25000;
Console.WriteLine($"Số tiền {moneyUSDFormat}$ sau khi chuyển thành VND: {moneyVND} VND");

#endregion

// extra session2

#region Bài tập 6

//INPUT
/*
 * Số dư tài khoản hiện tại
 * Số tiền muốn rút
 */
Console.WriteLine("Nhập số dư trong tài khoản:");
string? balance = Console.ReadLine();
int balanceInt = Convert.ToInt32(balance);

Console.WriteLine("Nhap số tiện muốn rút:");
string? withdrawal = Console.ReadLine();
int withdrawalInt = Convert.ToInt32(withdrawal);

// OUTPUT
int balanceAfterWithDraw;

// PROCESS
int balanceAfterWithdraw = balanceInt - withdrawalInt;
Console.WriteLine($"Số dư sau khi rut: {balanceAfterWithdraw}");

#endregion

#region Bài tập 7

// INPUT
/*
 * Nhập vào quảng đường đã đi
 * Thời gian đã đi
 */
Console.WriteLine("Nhập vào quảng đường đã đi: ");
string? distance = Console.ReadLine();
int distanceInt = Convert.ToInt32(distance);

Console.WriteLine("Nhập vào thời gian đã đi: ");
string? time = Console.ReadLine();
int timeInt = Convert.ToInt32(time);

// OUTPUT
double averageSpeed;

// PROCESS
averageSpeed = distanceInt / timeInt;

Console.WriteLine($"Tốc độ trung bình: {averageSpeed} ");

#endregion


#region Bài tập 8

// INPUT
Console.WriteLine("Nhâp vào một số: ");
string? aNumber = Console.ReadLine();
double aNumberInt = Convert.ToDouble(aNumber);

Console.WriteLine("Nhập vào tổng số: ");
string? totalNumber = Console.ReadLine();
double totalNumberInt = Convert.ToDouble(totalNumber);

// OUTPUT
double percentage;

// PROCESS
percentage = aNumberInt * 100 / totalNumberInt;
Console.WriteLine($"Tỉ lệ phần trăm: {percentage}");

#endregion

#region Bài tập 9

// INPUT
Console.WriteLine("Nhập vận tốc theo đơn vị km/h: ");
string? speedKmH = Console.ReadLine();
double speedKmHDouble = Convert.ToDouble(speedKmH);

// OUTPUT
double speedMs;

// PROCESS
speedMs = speedKmHDouble / 3.6;
Console.WriteLine($"Vận tốc m/s: {speedMs}");

#endregion

#region Bài tập 10

// INPUT
/*
 * nhập số phút tập thể dục
 * loại hình tập thể dục -> chạy, đạp xe, bơi lội
 * Cân nặng
 */
Console.WriteLine("Nhập so phút tập thể dục: ");
string? minuteEx = Console.ReadLine();
double minuteExDouble = Convert.ToDouble(minuteEx);

Console.WriteLine(@"Nhập loại hình tập thể dục:
  running: type 1
  bicycle: type 2
  swimming: type 3
");
string? typeEx = Console.ReadLine();
double typeExDouble = Convert.ToDouble(typeEx);

Console.WriteLine("Cân nặng của bạn:");
string? weigh = Console.ReadLine();
double weighDouble = Convert.ToDouble(weigh);

double running = 8.0;
double bicycle = 8.0;
double swimming = 8.0;

var result = typeExDouble switch {
 1 =>  running * weighDouble * minuteExDouble / 60,
 2 =>  bicycle * weighDouble * minuteExDouble / 60,
 3 =>  swimming * weighDouble * minuteExDouble / 60,
 _ => 0
};

Console.WriteLine($"Calorie consumption: {result} ");

#endregion