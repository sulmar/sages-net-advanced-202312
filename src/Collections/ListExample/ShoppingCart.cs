using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample;

internal class ShoppingCart
{
    public void AddItem(CartItem item)
    {
        throw new NotImplementedException();
    }

    public void RemoveItem(string productName)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CartItem> GetItems() 
    { 
        throw new NotImplementedException(); 
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public decimal CalculateTotal()
    { 
        throw new NotImplementedException();
    }
}

