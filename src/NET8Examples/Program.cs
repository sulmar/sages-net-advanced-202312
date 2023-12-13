using NET8Examples;

Console.WriteLine("Hello, News!");

Person person = new Person { FirstName = "John", LastName = "Smith" };

IEnumerable<Vehicle> vehicles = new List<Vehicle>();

House house = new House("home");

Vehicle vehicle = new Vehicle("Mazda", 10000, "1234");


var source1Customer = new Customer { Id = 1, FirstName = "John", LastName = "Smith" };

var source2Customer = new Customer { Id = 1, FirstName = "John", LastName = "Smith" };

source1Customer.LastName = "Spider";

if (source1Customer.Equals(source2Customer))
{
    Console.WriteLine("The same customer!");
}
else
{
    Console.WriteLine("Different customer!");
}

