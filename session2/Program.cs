// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Học phép toán cơ bản
// // +
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");

// // -
// int minus = 1231231 - 34546;
// Console.WriteLine($"Kết quả trừ hai số 1231231 và 34546 là: {minus}");

// // *
// int mutily = 10 * 10;
// Console.WriteLine($"Kết quả trừ hai số 10 và 10 là: {mutily}");

// // /
// double divideOne = 5 / 2;
// Console.WriteLine($"Kết quả chia hai số 5 và 2 là: {divideOne}");

// // %
// decimal divideTwo = 5 % 2;
// Console.WriteLine($"Kết quả chia hai số 5 và 2 là: {divideTwo}");
#endregion

Console.WriteLine("--------------------------------------------");

#region Numeric Toán tử
// int cong = 0; // định nghĩa cong có giá trị mặc đình bằng 0
// cong += 10;
// Console.WriteLine($"Numeric Toán tử cộng: {cong}");

// int tru = 0;
// tru += 10;
// Console.WriteLine($"Numeric Toán tử Trừ: {tru}");

// int nhan = 1;
// nhan *= 100;
// Console.WriteLine($"Numeric Toán tử nhân: {nhan}");
#endregion

#region ép kiểu c1 dùng Convert
    // // Convert
    // // Nhập dữ liệu từ bàn phím => ReadLine (string)
    // Console.WriteLine("Mời bạn nhập số");

    // string number = Console.ReadLine();
    // int convertNumber = Convert.ToInt32(number);
    // int sum = convertNumber + 1;

    // Console.WriteLine($"Value number: {sum}");
#endregion

#region Tính chỉ số BMI
    // // INPUT
    // // Chiều cao và cân nặng được nhận từ bàn phím
    // Console.WriteLine("Mời bạn nhập chiều cao (m)");
    // string chieuCao = Console.ReadLine();
    // // convert string sang double
    // double formatChieuCao = Convert.ToDouble(chieuCao);

    // Console.WriteLine("Mời bạn nhập cân nặng (kg)");
    // string canNang = Console.ReadLine();
    // double formatCanNang = Convert.ToDouble(canNang);

    // // OUTPUT
    // // in ra chỉ số BMI
    // // Khỏi tạo biến BMI để lưu giá trị BMI
    // double bmi = 0.0;

    // // PROCESS
    // // BMI = (Cân nặng) / (Chiều cao) * (Chiều cao)
    // bmi = formatCanNang / (formatChieuCao * formatChieuCao);
    // Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

#endregion

#region Tính Chu Vi và Diện tích hình Tròn
    // INPUT
    // B1: Nhập bán kính hình tròn
    Console.WriteLine($"Nhập bán kính:");
    string banKinh = Console.ReadLine();
    // B2: Convert string to double
    double formatBanKinh = Convert.ToDouble(banKinh);

    // OUTPUT
    // Chu Vi diện tích
    double p = 0.0;
    double s = 0.0;

    // PROCESS
    // p = 2 * pi * r
    p = 2 * Math.PI * formatBanKinh;
    Console.WriteLine($"Chu vi hình tròn: {p}");

    // S = pi * r * r
    s = Math.PI * formatBanKinh * formatBanKinh;
    Console.WriteLine($"Diện tích hình tròn: {s}");
#endregion