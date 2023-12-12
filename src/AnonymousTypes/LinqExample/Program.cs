
using Core;
using Core.Fakers;

Console.WriteLine("Hello, LINQ!");


var customerFaker = new CustomerFaker();

var customers = customerFaker.Generate(100_000);



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


Console.WriteLine("Type city: ");

string? selectedCity = Console.ReadLine();

var filteredCustomersByCityLinq = customers.AsQueryable();

if (!string.IsNullOrEmpty(selectedCity))
{
    filteredCustomersByCityLinq = filteredCustomersByCityLinq.Where(customer => customer.City == selectedCity);
}

var  query = filteredCustomersByCityLinq
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


