
using ReflectionExample;
using System.Reflection;
using System.Text;

Console.WriteLine("Hello, Reflection!");

string path = "PluginClass.dll";

FileInfo fileInfo = new FileInfo(path);

if (System.IO.File.Exists(path))
{

    Assembly pluginAssembly = Assembly.LoadFile(fileInfo.FullName);

    Type pluginType = pluginAssembly.GetType("PluginNamespace.PluginClass");

    object pluginInstance = Activator.CreateInstance(pluginType);

    pluginType.InvokeMember("DoWork", BindingFlags.InvokeMethod, null, pluginInstance, null);
}


// InvokeMethodTest();

// InvokeMethodAndReturnsValueTest();

// Przykład zastosowania refleksji do dynamicznego aktywowania i wykonywania komend
// CommandReflectionTest();


// Typ pobrany w czasie działania aplikacji

Customer customer = new Customer { Id = 1, Name = "a", Address = "Dworcowa 1" };

// Type type = DateTime.Now.GetType();
// Type type = customer.GetType();

// Typ pobrany w czasie kompilacji
// Type type = typeof(Customer);

// Typ pobrany na podstawie nazwy
Type type = Assembly.GetExecutingAssembly().GetType("ReflectionExample.Customer");

// Type type = typeof(System.Text.StringBuilder);

Console.WriteLine(type.Namespace);
Console.WriteLine(type.Name);
Console.WriteLine(type.FullName);
Console.WriteLine(type.BaseType);
Console.WriteLine(type.IsPublic);

MemberInfo[] members = type.GetMembers();

// Lista wszystkich składowych
foreach (MemberInfo member in members)
    Console.WriteLine(member.Name);

// Lista metod
foreach (var method in type.GetMethods())
    Console.WriteLine($"Method {method.Name} returns {method.ReturnParameter.Name} {method.ReturnParameter.ParameterType.Name}");

// Lista interfejsów
foreach (var iType in type.GetInterfaces())
    Console.WriteLine(iType.Name);


// Inspekcja typu dynamicznego
dynamic person = new { FirstName = "John", LastName = "Smith", Age = 18 };

var personMembers = person.GetType().GetMembers();

foreach (var item in personMembers)
{
    Console.WriteLine(item.Name);
}

// Odczyt i zapis właściwości

Type customerType = Assembly.GetExecutingAssembly().GetType("ReflectionExample.Customer");

PropertyInfo? propertyInfoName = customerType.GetProperty("Name");

var value = propertyInfoName.GetValue(customer);

propertyInfoName.SetValue(customer, "b", null);

string propertyName = "Name";

customer[propertyName] = "c";
Console.WriteLine(customer[propertyName]);


// Dostęp do prywatnych pól

FieldInfo field = customer.GetType().GetField("isRemoved", BindingFlags.NonPublic | BindingFlags.Instance);

Console.WriteLine(field.Name);

// Ustawienie wartości prywatnego pola
field.SetValue(customer, true);

// Pobranie wartości prywatnego pola
bool isRemoved = (bool)field.GetValue(customer);

// Console.WriteLine($"{propName.Name} = {value}");

// Utworzenie instacji na podstawie nazwy klasy

Type mySelectedType = Assembly.GetExecutingAssembly().GetType("ReflectionExample.Vehicle");

object instance = Activator.CreateInstance(mySelectedType);

string csv = ExportToCSV(customer);

Console.WriteLine(csv);

static string ExportToCSV(Customer customer)
{
    Type customerType = customer.GetType();

    StringBuilder stringBuilder = new StringBuilder();

    PropertyInfo[] properties = customerType.GetProperties();

    // Header
    foreach (var property in properties)
    {
        stringBuilder.Append(property.Name);
        stringBuilder.Append(";");
    }

    stringBuilder.AppendLine(string.Empty);

    // Row
    foreach (var property in properties)
    {

        var propertyValue = property.GetValue(customer);
        stringBuilder.Append(propertyValue);
        stringBuilder.Append(";");
    }

    string csv = stringBuilder.ToString();

    return csv;
}

static void CommandReflectionTest()
{
    string[] operations = ["Move", "Rotate", "Move", "Down", "Drill"];

    Printer3D printer = new Printer3D();

    foreach (string operation in operations)
    {
        string commandName = $"ReflectionExample.{operation}Command";

        Type commandType = Assembly.GetExecutingAssembly().GetType(commandName);

        ICommand command = Activator.CreateInstance(commandType) as ICommand;

        command?.Execute();

    }
}

static void InvokeMethodTest()
{
    object printer = new Printer3D();

    while (true)
    {
        Console.WriteLine("Type operation: ");
        string selectedOperation = Console.ReadLine();

        var printerResult = printer.GetType().InvokeMember(selectedOperation, BindingFlags.InvokeMethod, null, printer, null);
    }
}

static void InvokeMethodAndReturnsValueTest()
{
    var calculatorType = typeof(Calculator);

    object calculator = Activator.CreateInstance(calculatorType);

    object[] parameters = [5, 10];

    var result = (int)calculatorType.InvokeMember("Add", BindingFlags.InvokeMethod, null, calculator, parameters);

    Console.WriteLine(result);
}