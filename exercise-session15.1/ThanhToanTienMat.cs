namespace exercise_session15._1;

public class ThanhToanTienMat : IThanhToan 
{
    public void ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toan tien mat voi so tien: {soTien}");
    }
}