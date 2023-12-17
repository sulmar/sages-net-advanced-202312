using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zadania.Model;

namespace Zadania
{
    public static class Zadanie3
    {
        private static Autostrada _autostrada;

        public static void AutostradaTest(int bramkiCnt, int carCount)
        {
            _autostrada = new Autostrada(bramkiCnt, carCount);
            Console.WriteLine("Rozpoczecię na autostradzie");
            Console.WriteLine(_autostrada.ToString());
            Console.WriteLine("Naciśnij klawisz by rozpocząć obsługe samochodów");
            Console.ReadKey();
            
            Thread t1 = new Thread(() => AddCarsTest(10,200,600));

            Thread t2 = new Thread(() => GetCarsTest(300,700));
            Thread t3 = new Thread(() => WyswietlajAutostrade(2000));
            t1.Start();    
            t2.Start();
            t3.Start();


        }

        static void AddCarsTest(int numberOfCars, int milisecondsTimoutStart, int milisecondsTimoutEnd)
        {
            int milisecondsTimout;
            Random rnd = new Random();
            for (int i = 0; i < numberOfCars; i++)
            {
                milisecondsTimout = rnd.Next(milisecondsTimoutStart, milisecondsTimoutEnd);
                _autostrada.AddCar(milisecondsTimout);
            }
        }

        static void GetCarsTest( int milisecondsTimoutStart, int milisecondsTimoutEnd)
        {
            int milisecondsTimout;
            Random rnd = new Random();
            while (_autostrada.CarCount > 0)
            {
                for (int i = 0; i < _autostrada.Bramki.Count; i++)
                {
                    milisecondsTimout = rnd.Next(milisecondsTimoutStart, milisecondsTimoutEnd);
                    _autostrada.GetCar(milisecondsTimout, i);
                }
            }
        }

        static void WyswietlajAutostrade(int milisecondsTimout)
        {
            
            Random rnd = new Random();
            string gw = "*";

            while (_autostrada.CarCount > 0)
            {
                Console.WriteLine(gw);
                gw += "*";                
                if (_autostrada.CarCount  > 0)
                {
                    Console.Clear();
                    Console.WriteLine(gw);
                    Console.WriteLine(_autostrada.ToString());
                }
                Thread.Sleep(milisecondsTimout);
            }
            Console.Clear();
            Console.WriteLine("Brak samochodów na autostradzie");
            Console.WriteLine(_autostrada.ToString());
            Console.WriteLine("Naciśnij klawisz by zakończyć");
            Console.ReadKey();
        }
    }
}
