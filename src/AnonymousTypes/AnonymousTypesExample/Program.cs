
using AnonymousTypesExample;
using Bogus;

Console.WriteLine("Hello, Anonymous Types!");

// Typ anonimowy
var person = new
{
    FirstName = "John",
    LastName = "Smith",
    Age = 18
};

var customerFaker = new Faker<Customer>()
    .RuleFor(p => p.Id, f => f.IndexFaker)
    .RuleFor(p => p.FirstName, f => f.Person.FirstName)
    .RuleFor(p => p.LastName, f => f.Person.LastName)
    .RuleFor(p => p.Email, (f, customer) => $"{customer.FirstName}.{customer.LastName}@domain.com") // {firstname}.{lastname}@domain.com
    .RuleFor(p => p.Address, f => f.Address.StreetAddress())
    .RuleFor(p => p.City, f => f.Address.City())
    .RuleFor(p => p.HashedPassword, f => f.Lorem.Word())
    .RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.3f))
    ;

var customers = customerFaker.GenerateLazy(100);

var customerInfos = customers
    .Select(customer => new { customer.FirstName, customer.LastName, customer.City} )
    .ToList();

foreach (var customer in customerInfos)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.City}");
}
