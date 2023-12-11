using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes;

internal class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


internal class Order
{
    public int OrderId { get; set; }
    public string Number { get; set; }
    public decimal TotalAmount { get; set; }
}


