namespace ListExample;

public class CartItem
{
    public string ProductName { get; }
    public decimal Price { get; }
    public int Quantity { get;  }

    public CartItem(string productName, decimal price, int quantity = 1)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
    public override string ToString()
    {
        return $"Product: {ProductName} Price: ${Price}, Quantity: {Quantity}";
    }

}

