
using Delegates;
using System.Net.WebSockets;

Console.WriteLine("Hello, Delegates!");

//Action<string> myAction = delegate (string message)
//{
//    Console.WriteLine(message);
//};

// Action<string> myAction = (message) => Console.WriteLine(message);

var myAction = (string message) => Console.WriteLine(message);

myAction("Hello Action!");

//Func<string, string> myFunc = delegate (string value)
//{
//    return "Some value";
//};

// Func<string, string> myFunc = (value) => "Some value";

var myFunc = (string value) => "Some value";

myFunc("Hello Func!");



Printer printer = new Printer();

printer.OnErrorPrint(DisplayError);

printer.OnErrorPrint(error => Console.WriteLine(error));

printer.PrintCompleted += OnPrintCompleted;
printer.Printed += Printer_Printed;

void Printer_Printed(object sender, PrintedEventArgs e)
{
    Console.WriteLine($"Printed {e.Copies} copies. Cost {e.Cost:C2}");
}


printer.CanPrint += CanPrint;

// Metoda anonimowa (inline)
printer.Log += delegate (string message)
{
    Console.WriteLine(message);
};

// Metoda anonimowa (wyrażenie lambda)
printer.Log += (message) => Console.WriteLine(message);

// Metoda nazwana
printer.Log += LogToFile;

printer.Log += Console.WriteLine;

printer.Log -= LogToFile;

// printer.Log = null;


var loggers = printer.Log?.GetInvocationList();

if (loggers != null)
{
    foreach (var logger in loggers)
    {
        Console.WriteLine(logger);
    }
}

decimal cost = 0.99M;

// printer.CalculateCost += CalculateCost;

//printer.CalculateCost = delegate (int copies)
//{
//    return copies * cost;
//};

// Wyrażenie lambda
printer.CalculateCost = copies => copies * cost;

// JS: copies -> copies * cost;
// R:  copies <- copies * cost

printer.Print("Lorem ipsum", 3);

printer.Print("Lorem ipsum");

Console.WriteLine();

void LogToFile(string message)
{
    File.WriteAllText("log.txt", message);
}


decimal CalculateCost(int copies)
{
    return copies * cost;
}

bool CanPrint(int copies)
{
    return copies < 5;
}


void OnPrintCompleted()
{
    Console.WriteLine("Print Completed!");
}

void DisplayError(string error)
{
    Console.WriteLine(error);
}