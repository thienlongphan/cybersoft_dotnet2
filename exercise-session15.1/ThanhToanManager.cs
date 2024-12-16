using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace exercise_session15._1;

public class ThanhToanManager
{
    public List<string>? HistoryTransactions { get; set; }
    
    private string _pathFile = "historyTransaction.txt";

    public ThanhToanManager()
    {
        ReadFromFile();
    }

    private void WriteToFile()
    {
        string json = JsonConvert.SerializeObject(HistoryTransactions, Formatting.Indented);
        File.WriteAllText(_pathFile, json);
        Console.WriteLine($"Luu lich su giao dich thanh cong");
    }

    private void ReadFromFile()
    {
        if (File.Exists(_pathFile))
        {
            string json = File.ReadAllText(_pathFile);
            HistoryTransactions = JsonConvert.DeserializeObject<List<string>>(json);
            Console.WriteLine("Load data thanh cong");
        }
        else
        {
            HistoryTransactions = new List<string>();
        }
    }

    public void ThanhToanBangTienMatMethod()
    {
        Console.WriteLine("Nhap so tien can thanh toan bang tien mat");
        double inputTien = Convert.ToDouble(Console.ReadLine());

        if (inputTien <= 0)
        {
            Console.WriteLine("So tien ban nhap khong hop le. Vui long nhap lai");
            return;
        }
        
        ThanhToanTienMat thanhToanTienMat = new ThanhToanTienMat();
        thanhToanTienMat.ThanhToan(inputTien);
        HistoryTransactions?.Add($"Da thanh toan tien mat: {inputTien}");
        WriteToFile();
    }
    
    public void ThanhToanTheMethod()
    {
        Console.WriteLine("Nhap so tien can thanh toan bang the");
        double inputTien = Convert.ToDouble(Console.ReadLine());

        if (inputTien <= 0)
        {
            Console.WriteLine("So tien ban nhap khong hop le. Vui long nhap lai");
            return;
        }
        
        ThanhToanBangThe thanhToanThe = new ThanhToanBangThe();
        bool isPinValid = thanhToanThe.CheckPin();
        if (isPinValid)
        {
            thanhToanThe.ThanhToan(inputTien);
            HistoryTransactions?.Add($"Da thanh toan bang the: {inputTien}");
            WriteToFile();
        }
       
    }
    
    public void ThanhToanOnlineMethod()
    {
        Console.WriteLine("Nhap so tien can thanh toan Online");
        double inputTien = Convert.ToDouble(Console.ReadLine());

        if (inputTien <= 0)
        {
            Console.WriteLine("So tien ban nhap khong hop le. Vui long nhap lai");
            return;
        }
        
        ThanhToanOnline thanhToanOnline = new ThanhToanOnline();
        bool isOtpValid = thanhToanOnline.CheckOTP();
        if (isOtpValid)
        {
            thanhToanOnline.ThanhToan(inputTien);
            HistoryTransactions?.Add($"Da thanh toan online: {inputTien}");
            WriteToFile();
        }
    }

    public void DisplayHistoryTransactions()
    {
        foreach (string transaction in HistoryTransactions!)
        {
            Console.WriteLine(transaction);
        }
    }
}