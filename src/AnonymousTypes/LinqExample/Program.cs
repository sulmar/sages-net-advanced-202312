
using Core;
using Core.Fakers;
using LinqExample;
using Microsoft.EntityFrameworkCore;

// Ozcode
// marketplace.visualstudio.com/items?itemName=CodeValueLtd.OzCode

Console.WriteLine("Hello, LINQ!");

var person1 = new Person("John",
    new List<Order>
    {
        new ("Order 1", 100),
        new("Order 2", 200),
        new ("Order 3", 300),
    });

var person2 = new Person("Kate",
    new List<Order>
    {
        new ("Order 4", 400),
        new("Order 5", 500),
    });

var people = new List<Person>() { person1, person2 };

// TODO: SelectMany
var query = people.SelectMany(p=>p.Orders).ToList();


// ZipLinqTest();

// GroupByLinqTest();

Console.WriteLine();


//MyDbContext db = new MyDbContext();

//var q = db.Customers
//    .TagWith("My query") // --- My query 
//    .Where(customer => customer.City == "Warsaw")
//    .OrderBy(customer => customer.FirstName)
//    .ToList();

// IQuerableTest();

# region Customers


/* 
var customerFaker = new CustomerFaker();

var customers = customerFaker.Generate(1_000);
*/

// Zapis imperatywny

/*
ICollection<Customer> filteredCustomersByCity = new List<Customer>();
foreach (var customer in customers)
{
    if (customer.City == selectedCity) // Predykat
        filteredCustomersByCity.Add(customer);
}

*/

// Zapis deklaratywny
// SQL: SELECT * FROM dbo.Customers WHERE City = @SelectedCity

// SQL: SELECT FirstName, LastName, City FROM dbo.Customers WHERE City = @SelectedCity

// SQL: SELECT FirstName, LastName, City FROM dbo.Customers WHERE City = @SelectedCity ORDER BY FirstName DESC
// CustomersLinqTest(customers);

static void CustomersLinqTest(List<Customer> customers)
{
    Console.WriteLine("Type city: ");

    string? selectedCity = Console.ReadLine();

    var filteredCustomersByCityLinq = customers.AsQueryable();

    if (!string.IsNullOrEmpty(selectedCity))
    {
        filteredCustomersByCityLinq = filteredCustomersByCityLinq.Where(customer => customer.City == selectedCity);
    }

    var query = filteredCustomersByCityLinq
        .Select(customer => new { customer.FirstName, customer.LastName, customer.City })
        .OrderByDescending(customer => customer.FirstName)
        .ToList();


    //var filteredCustomersByCityLinq = customers
    //    .Where(customer => customer.City == selectedCity)
    //    .Select(customer => new { customer.FirstName, customer.LastName, customer.City })
    //    .OrderByDescending(customer => customer.FirstName)
    //    .ToList();

    foreach (var customer in query)
    {
        Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.City}");
    }
}

#endregion

IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}

void IQuerableTest()
{
    var source = GetNumbers();

    IQueryable<int> query = source.AsQueryable()
        .Where(number => number > 2);

    query = query
        .Skip(1)
        .OrderBy(number => number);

    var fileredNumbers = query.ToList();

    fileredNumbers.Dump("Filtered numbers:");
}

static void GroupByLinqTest()
{
    List<Product> source =
    [
        new("Product 1", 1.99m, "a"),
        new("Product 3", 5.99m, "b"),
        new("Product 4", 201.99m, "a"),
        new("Product 5", 199.99m, "c"),
        new("Product 6", 9.99m, "c"),
        new("Product 7", 9.99m, "c"),
    ];

    // SQL: SELECT Category, COUNT(*) AS Qty , SUM(Price) AS Total FROM dbo.Products GROUP BY Category

    var customersGroupByCategory =
        source
        .GroupBy(p => p.Category)
        .Select(g => new
        {
            Category = g.Key,
            Qty = g.Count(),
            Total = g.Sum(p => p.Price)
        })
        .ToList();
}

static void ZipLinqTest()
{
    int[] numbers = { 10, 20, 30, 40, 50 };
    string[] users = { "Jack", "Tim", "Henry", "Tom" };

    var userNumbers = numbers.Zip(users)
        .Select(x => new { Number = x.First, User = x.Second })
        .Select(x => $"{x.Number} - {x.User}")
        .ToList();
}