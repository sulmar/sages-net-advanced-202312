using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample;

public sealed class Printer
{
    public void Print(string content)
    {
        Console.WriteLine(content);
    }    
}

// Utworzenie klasy rozszerzającej do typu referencyjnego
public static class PrinterExtensions
{
    public static void Print(this Printer printer, string content, byte copies)
    {
        for (int i = 0; i < copies; i++)
        {
            printer.Print(content);
        }
    }
}