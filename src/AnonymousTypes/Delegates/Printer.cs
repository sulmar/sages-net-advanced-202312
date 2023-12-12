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

    public void Print(string content, byte copies = 1)
    {
        if (!(CanPrint == null || CanPrint.Invoke(copies)))
        {
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
    }



    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}