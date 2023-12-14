using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskExample;

namespace AsyncAwaitExample;

internal class TaxProcess
{
    // Synchroniczny
    public decimal CalculateTotal()
    {
        TaxCalculator taxCalculator = new TaxCalculator();

        var result1 = taxCalculator.Calculate(1000);
        var result2 = taxCalculator.Calculate(result1);

        return result2;
    }

    // Asynchroniczny
    public async Task<decimal> CalculateTotalAsync()
    {
        TaxCalculator taxCalculator = new TaxCalculator();

        var result1 = await taxCalculator.CalculateAsync(1000);
        var result2 = await taxCalculator.CalculateAsync(result1);

        return result2;
    }
}
