using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates;

public class Printer
{
    /*
    // Definicja metody (tylko sygnatury metody)
    public delegate void LogDelegate(string message);

    // Zmienna, która przechowuje referencję do metod(y)
    public LogDelegate? Log;
    */

    // Action - gotowa sygnatura delegatu typu void
    public Action<string>? Log;


    /*
    public delegate decimal CalculateCostDelegate(int copies);
    public CalculateCostDelegate? CalculateCost;
    */

    // Func - gotowa sygnatura delegatu typu T
    public Func<int, decimal>? CalculateCost;

    // Predicate - Func, który zwraca typ boolean Func<int, bool>
    public Predicate<int>? CanPrint;

    public delegate void PrintCompletedDelegate();
    public event PrintCompletedDelegate? PrintCompleted;

    public delegate void PrintedDelegate(object sender, PrintedEventArgs e);
    public event PrintedDelegate? Printed;

    // Zdarzenie (event) to jest to samo co delegat, ale prywatny 
    // w takim znaczeniu, że zdarzenie może wywołać tylko właściciel 
    // a na zewnątrz możemy tylko nasłuchiwać

    private Action<string>? _onError;

    // Przekazywanie Action poprzez metodę
    public void OnErrorPrint(Action<string> action)
    {
        this._onError = action;
    }

    public void Print(string content, byte copies = 1)
    {
        if (!(CanPrint == null || CanPrint.Invoke(copies)))
        {
            _onError?.Invoke("Błąd wydruku");

            throw new InvalidOperationException();



        }

        for (int copy = 0; copy < copies; copy++)
        {
            Log?.Invoke($"{DateTime.Now} Printing {content} copy #{copy}");
        }

        decimal? cost = CalculateCost?.Invoke(copies);

        if (cost.HasValue)
        {
            DisplayLCD(cost.Value);
        }

        Log?.Invoke($"Printed {copies} copies.");

        // TODO: Send printed signal 

        PrintCompleted?.Invoke();

        Printed?.Invoke(this, new PrintedEventArgs(copies, cost));
    }



    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}

public class PrintedEventArgs : EventArgs
{
    public int Copies { get; }
    public decimal? Cost { get; }

    public PrintedEventArgs(int copies, decimal? cost)
    {
        Copies = copies;
        Cost = cost;
    }
}