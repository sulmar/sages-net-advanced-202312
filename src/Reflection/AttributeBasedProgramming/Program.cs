
using AttributeBasedProgramming;

Console.WriteLine("Hello, Attribute!");


Customer customer = new Customer();
customer.Pesel = "1234";


Type type = typeof(Customer);

// Odczytanie atrybutu na poziomie właściwości
var customerProperties = type.GetProperties();
foreach (var property in customerProperties)
{
    bool hasReadOnlyAttribute = Attribute.IsDefined(property, typeof(ReadOnlyAttribute));

    if (hasReadOnlyAttribute)
    {
        var readOnlyAttribute = Attribute.GetCustomAttribute(property, typeof(ReadOnlyAttribute)) as ReadOnlyAttribute;

        Console.WriteLine($"{property.Name} {readOnlyAttribute.IsReadOnly}");        
    }
}


// Odczytanie atrybutu na poziomie typu
ImageAttribute customAttribute = Attribute.GetCustomAttribute(type, typeof(ImageAttribute)) as ImageAttribute;

Console.WriteLine(customAttribute.Filename);


// Odczytanie atrybutu na poziomie metod
var methods = type.GetMethods();

foreach (var method in methods)
{
    bool hasImageAttribute = Attribute.IsDefined(method, typeof(ImageAttribute));

    if (hasImageAttribute)
    {
        var imageAttribute = Attribute.GetCustomAttribute(method, typeof(ImageAttribute)) as ImageAttribute;

        Console.WriteLine(imageAttribute?.Filename);
    }
}

// Odczytanie atrybutu na poziomie właściwości
var properties = type.GetProperties();
foreach (var property in properties)
{
    bool hasImageAttribute = Attribute.IsDefined(property, typeof(ImageAttribute));

    if (hasImageAttribute)
    {
        var imageAttribute = Attribute.GetCustomAttribute(property, typeof(ImageAttribute)) as ImageAttribute;

        Console.WriteLine(imageAttribute?.Filename);
    }
}