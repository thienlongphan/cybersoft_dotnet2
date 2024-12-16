namespace exercise_session15._1;

public class ThanhToanBangThe : IThanhToan
{
    private int pin = 9999;

    public bool CheckPin()
    {
        Console.WriteLine($"Vui long Nhap ma pin cua ban");
        
        int inputPin = Convert.ToInt32(Console.ReadLine());

        if (inputPin != pin)
        {
            Console.WriteLine($"Ma Pin ban nhap sai");
            return false;
        }
        
        return true;
    }
    
    public void ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toan bang the voi so tien: {soTien}");
    }
}