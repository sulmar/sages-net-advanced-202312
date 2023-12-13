
// CLR
// DLR (Dynamic Language Runtime)

using DynamicExample;

Console.WriteLine("Hello, Dynamic!");

dynamic x = 10;

Console.WriteLine(x);

x = "Hello";

Console.WriteLine(x);

x = new { FirstName = "John", LastName = "Smith", Age = 18 };

// int age = x.FirstName;

dynamic customer = new CustomerDTO { Name = "a", City = "b" };

Console.WriteLine(customer.Name);
