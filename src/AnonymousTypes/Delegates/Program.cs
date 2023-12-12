
using Delegates;

Console.WriteLine("Hello, Delegates!");

Printer printer = new Printer();

printer.CanPrint += CanPrint;

// Metoda anonimowa (inline)
printer.Log += delegate (string message)
{
    Console.WriteLine(message);
};

printer.Log += Console.WriteLine;

// Metoda nazwana
printer.Log += LogToFile;

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

printer.CalculateCost += CalculateCost;

printer.Print("Lorem ipsum", 3);

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