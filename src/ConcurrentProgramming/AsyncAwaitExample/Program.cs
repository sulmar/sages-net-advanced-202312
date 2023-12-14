
using AsyncAwaitExample;
using TaskExample;

Console.WriteLine("Hello, World!");

TaxProcess taxProcess = new TaxProcess();

Console.WriteLine("Calculating Total...");

decimal total = await taxProcess.CalculateTotalAsync();

Console.WriteLine(total);
