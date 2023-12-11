using ExtensionMethodsExample;
using ExtensionMethodsExample.Course;

Console.WriteLine("Hello, World!");

Printer printer = new Printer();
printer.Print("Hello World", 3);

DateTime dateTime = DateTime.Now;

if (dateTime.IsHoliday())
{
    Console.WriteLine("Już wolne :)");
}

dateTime.AddWorkDays(3);
