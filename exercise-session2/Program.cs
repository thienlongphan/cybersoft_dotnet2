// See https://aka.ms/new-console-template for more information
#region Bài tập 1
    // // INPUT
    // // số ngày
    // Console.WriteLine("Nhập số ngày:");
    // string days = Console.ReadLine();
    // int daysFormat = Convert.ToInt32(days);

    // // OUTPUT
    // // Bao nhiêu tuần và ngày còn lại
    // double weeks = 0.0;
    // double remainderDays = 0.0;

    // // PROCESS
    // // 1 tuần = 7ngày
    // weeks = (daysFormat * 1) / 7;
    // remainderDays = (daysFormat * 1) % 7;
    // Console.WriteLine($"Số tuần là: {weeks} và ngày còn lại là: {remainderDays}"); 
    
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