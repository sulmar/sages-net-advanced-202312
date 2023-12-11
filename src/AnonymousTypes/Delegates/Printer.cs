using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates;

public class Printer
{
    public void Print(string content, byte copies = 1)
    {
        for (int copy = 0; copy < copies; copy++)
        {
            // TODO: Log to Console and/or to LogFile
            Console.WriteLine($"{DateTime.Now} Printing {content} copy #{copy}");
        }

        // TODO: How to add discount?
        decimal? cost = CalculateCost(copies, 0.99M);

        if (cost.HasValue)
        {
            DisplayLCD(cost.Value);
        }

        // TODO: Send printed signal 
        Console.WriteLine($"Printed {copies} copies.");
    }

    private decimal CalculateCost(int copies, decimal cost)
    {
        return copies * cost;
    }

    private void DisplayLCD(decimal cost)
    {
        Console.WriteLine($"LCD: {cost}");
    }
}