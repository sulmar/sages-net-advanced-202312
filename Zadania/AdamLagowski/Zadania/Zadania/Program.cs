using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Zadania.Model;

namespace Zadania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1
            Console.WriteLine("Zadanie 1.");
            Console.WriteLine("Raport zamówień w podziale na godziny posortowane po ilości zamówień malejąco");
            Zadanie1.GetOrderHours(18, 21, 1_000).Dump<OrderRaportPosition>();
            Console.WriteLine("Press any kay to next");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Zadanie 3.");
            Console.WriteLine("Autostrada");
            Zadanie3.AutostradaTest(5,22);
            Console.ReadKey();
        }
    }
}
