using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample;

internal class Person
{
    public string FirstName { get; set; }
    public IEnumerable<Order> Orders { get; set; }

    public Person(string firstName, IEnumerable<Order> orders)
    {
        FirstName = firstName;
        Orders = orders;
    }
}

internal class Order
{
    public string Number { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(string number, decimal totalAmount)
    {
        Number = number;
        TotalAmount = totalAmount;
    }
}
