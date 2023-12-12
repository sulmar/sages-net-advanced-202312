
using Core.Fakers;

Console.WriteLine("Hello, LINQ!");


var customerFaker = new CustomerFaker();

var customers = customerFaker.GenerateLazy(100);


