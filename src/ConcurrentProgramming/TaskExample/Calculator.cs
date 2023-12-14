using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample;

internal class TaxCalculator
{
    const decimal Tax = 0.19M;

    public decimal Calculate(decimal income)
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Calculating...");

        Thread.Sleep(10_000);

        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Calculated.");

        return income * Tax;
    }

}
