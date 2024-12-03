namespace exercise_session13;

public class Order
{
    private string orderID;

    public string OrderID
    {
        get => orderID;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("OrderId cannot be null or whitespace.");
            }
            orderID = value;
        }
    }

    private string productID;

    public string ProductID
    {
        get => productID;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ProductId cannot be null or whitespace.");
            }
            productID = value;
        }
    }

    private int quantitySold;

    public int QuantitySold
    {
        get => quantitySold;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("QuantitySold cannot be negative.");
            }
            
            quantitySold = value;
        }
    }

    private string orderName;

    public string OrderName
    {
        get => orderName;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("OrderName cannot be null or whitespace.");
            }
            
            orderName = value;
        }
    }
    
    public bool IsDelivered { get; set; }

    public Order(string orderID, string productID, int quantitySold, string orderName)
    {
        OrderID = orderID;
        ProductID = productID;
        QuantitySold = quantitySold;
        OrderName = orderName;
        IsDelivered = true;
    }
}