using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample;

internal class TaxCalculator
{
    const decimal Tax = 0.19M;

    public decimal Calculate(decimal income, CancellationToken cancellationToken = default, IProgress<int> progress = default)
    {
        Console.Write($"Thread #{Thread.CurrentThread.ManagedThreadId} Calculating");

        for (int i = 0; i < 10; i++)
        {
            //if (cancellationToken.IsCancellationRequested)
            //{
            //    Console.WriteLine("IsCancellationRequested");
            //    throw new OperationCanceledException();
            //}

            cancellationToken.ThrowIfCancellationRequested();

            // Console.Write(".");
            progress.Report(i);            

            Thread.Sleep(1000);

        }

        Console.WriteLine();

        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Calculated.");

        return income * Tax;
    }

}
