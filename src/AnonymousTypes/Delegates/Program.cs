
using Delegates;

Console.WriteLine("Hello, Delegates!");

Printer printer = new Printer();

printer.OnErrorPrint(DisplayError);

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