namespace exercise_session15._1;

public class ThanhToanOnline : IThanhToan
{
    private int _otp = 12334;

    public bool CheckOTP()
    {
        Console.WriteLine($"Ma OTP cua ban la: {_otp}");
        
        Console.WriteLine($"Vui long nhap lai OTP");
        int inputOTP = Convert.ToInt32(Console.ReadLine());

        if (inputOTP != _otp)
        {
            Console.WriteLine($"Ban nhap OTP khong dung vui long nhap lai");
            return false;
        }
        
        return true;
    }

    public void ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh Toan Online voi so tien: {soTien}");
    }
}