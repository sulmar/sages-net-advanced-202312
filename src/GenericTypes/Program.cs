using GenericTypes;
using GenericTypes.Model;

Console.WriteLine("Hello, Generic Types!");

LocalStorage localStorage = new LocalStorage();
localStorage.Set("Key1", "Foo");
localStorage.Set("temp", 21);

string stringValue = localStorage.Get<string>("Key1");

int intValue = localStorage.Get<int>("temp");

Console.WriteLine(stringValue);
Console.WriteLine(intValue);

Customer customer = Factory.Create<Customer>();