
using Newtonsoft.Json;
using System.Dynamic;

Console.WriteLine("Hello, Expando Object!");

dynamic settings = new ExpandoObject();

settings.Theme = "Dark";
settings.Folder = "C:\\temp";
settings.SizeLimit = 100;
settings.LastDate = DateTime.Now;

//settings.Print = (Action)(() =>
//{
//    Console.WriteLine(settings.Theme);
//    Console.WriteLine(settings.Folder);
//    Console.WriteLine(settings.SizeLimit);
//});

// settings.Print();

// Przykład serializacji obiektu dynamicznego do json
string outputString = JsonConvert.SerializeObject(settings);

Console.WriteLine(outputString);


// Przykład deserializacji json do obiektu dynamicznego
dynamic input = JsonConvert.DeserializeObject(outputString);

Console.WriteLine(settings.Theme);
Console.WriteLine(settings.Folder);
Console.WriteLine(settings.SizeLimit);
Console.WriteLine(settings.LastDate);





