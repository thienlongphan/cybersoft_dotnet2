namespace exercise_session13;

public class OrderManager
{
    public void OrderProduct(List<Product> products)
    {
        Console.WriteLine("==== OrderProduct ====");
        Console.WriteLine("Enter Order code: ");
        string orderCode = Console.ReadLine();
        
        Console.WriteLine("Enter Product Code: ");
        string productCode = Console.ReadLine();
        
        Console.WriteLine("Enter Orderer Name: ");
        string ordererName = Console.ReadLine();
        
        Console.WriteLine("Enter Quantity Sold: ");
        int quantitySold = Convert.ToInt32(Console.ReadLine());
        
        Product product = products.FirstOrDefault(item => item.ProductCode == productCode);
        
        if(product == null) throw new Exception("Product not found");

        Order order = new Order(orderCode, productCode,  quantitySold, ordererName);

        if (order.IsDelivered)
        {
            product.InventoryQuantity -= order.QuantitySold;
            Console.WriteLine("Product has been delivered");
            product.DisplayInfo();
        }
    }
}