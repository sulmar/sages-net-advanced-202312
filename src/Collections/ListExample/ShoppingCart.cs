namespace ListExample;

internal class ShoppingCart
{
    private readonly ICollection<CartItem> items = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(string productName)
    {
        CartItem item = items.FirstOrDefault(x => x.ProductName == productName);

        items.Remove(item);
    }

    public IEnumerable<CartItem> GetItems() 
    {
        return items;
    }

    public void Clear()
    {
        items.Clear();
    }

    public decimal CalculateTotal()
    { 
        return items.Sum(p=>p.Quantity * p.Price);
    }
}

