using session14;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        NhanVien nguyenVanA = new TruongPhong("NV001", "NguyenVanA", 1000, 1.5);
        Console.WriteLine($"Luong cua Nguyen Van A: {nguyenVanA.TinhLuong()}");

        Animal dog = new Animal("Dog");
        dog.Sleep();
        dog.Eat();
        
        
        // bai tap ve quan ly khách sạn
        // abstract class: room
        // -roomId: string
        // -roomName: string
        // -basePrice: double
        
        // class Con:
        // - NormalRoom: Room
        // - LuxuryRoom: Room
        //   + extraService: string
        // - SuitedRoom : Room
        //   + extraService: string
        //   + premiumService: string
        
        // Class Hotel

        Room normalRoom = new NormalRoom("01", "Normal Room 1", 400000);
        Room luxuryRoom = new LuxuryRoom("02", "Luxury Room 1", 400000, "Fee Breakfast");
        Room suitRoom = new SuitRoom("03", "Suit Room 1", 400000, "Fee Breakfast", "Fee Massage");
        
        Console.WriteLine($"Price of normal room: {normalRoom.CalculatePrice()}");
        Console.WriteLine($"Price of luxury room: {luxuryRoom.CalculatePrice()}");
        Console.WriteLine($"Price of suite room: {suitRoom.CalculatePrice()}");
    }
}