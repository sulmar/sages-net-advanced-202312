using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NET8Examples;

// Immutable (niezmienny)
record Vehicle([Description] string Model, decimal Price, string Vin);

class Vehicle2
{
    public string Model { get; init; }
    public decimal Price { get; init; }
    public string Vin { get; init; }

    public Vehicle2(string model, decimal price, string vin)
    {
        Model = model;
        Price = price;
        Vin = vin;
    }
}

internal record VipCustomer : Customer
{
    public string Class { get; set; }
}

// Primary Constructors
class House(string name, string? flatNumber = null, decimal? price = null)
{
}

class Person
{
    required
    public string FirstName { get; set; }

    public string? SecondName { get; set; }

    required
    public string LastName { get; set; }
}


// Krotki
internal record Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    required
    public string LastName { get; set; }

    public void DoWork()
    {

    }

    //public override bool Equals(object? obj)
    //{
    //    if (obj == null || GetType() != obj.GetType())
    //        return false;

    //    Customer otherCustomer = (Customer)obj;

    //    return StructuralComparisons.StructuralEqualityComparer.Equals(Id, otherCustomer.Id) 
    //        && StructuralComparisons.StructuralEqualityComparer.Equals(FirstName, otherCustomer.FirstName)
    //        && StructuralComparisons.StructuralEqualityComparer.Equals(LastName, otherCustomer.LastName);
    //}

    //public override int GetHashCode()
    //{
    //    return base.GetHashCode();
    //}

}
