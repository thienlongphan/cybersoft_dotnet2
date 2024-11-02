internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // int ketQua = TinhTong(10, 11);
        // Console.WriteLine($"Tong 2 so la: {ketQua}");

        // Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
        // Console.WriteLine("Mời bạn nhập số: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // for(int count = 2; count <= number; count++){
        //     bool isCheckPrime = IsPrime(count);

        //     if(isCheckPrime == true) {
        //         Console.Write($"{count} ");
        //     }
        // }

        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number3;
        int reverseNumber = GetReverseNumber(number3);
        if (reverseNumber == originalNumber){
            Console.WriteLine($"Số {originalNumber} là số đối xứng");
        } else {
            Console.WriteLine($"Số {originalNumber} không là số đối xứng");
        }
    }

    private static int TinhTong(int num1, int num2) 
    {
        return num1 + num2;
    }

    private static bool IsPrime(int number) 
    {   
        if(number < 2) return false;

        for(int i = 2; i < Math.Sqrt(number); i++) 
        {
            if(number % i == 0) 
            {
                return false;
            }
        }

        return true;
    }

    private static int GetReverseNumber(int num) 
    {
        int reverseNumber = 0;
        while(num > 0){
            int lastDigit = num % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            num = num / 10;
        }

        return reverseNumber;
    }
}