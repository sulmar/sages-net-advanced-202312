using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zadania.Fakers;

namespace Zadania.Model
{
    public class Autostrada
    {

        public List<ConcurrentQueue<Car>> Bramki { get; }
        public  int CarCount { get; set; }
        CarFaker CarFaker { get; set; }

        public Autostrada(int bramkiCnt, int carCount)
        {
            Bramki = new List<ConcurrentQueue<Car>>();
            CarCount = carCount;
            for (int i = 0;i< bramkiCnt; i++)
            {
                Bramki.Add(new ConcurrentQueue<Car>());
            }
            CarFaker = new CarFaker(bramkiCnt);
            var cars = CarFaker.Generate(carCount);
            
             foreach(Car c in cars)
            {
                (Bramki[c.NrBramki] as ConcurrentQueue<Car>).Enqueue(c);
            }

        }

        public override string ToString()
        {            
            StringBuilder sb = new StringBuilder();
            Car c;
            for(int i=0; i<Bramki.Count;i++)
            {
                Bramki[i].TryPeek(out c);
                sb.AppendLine($"Bramka Nr: {i+1}, liczba samochodów: {Bramki[i].Count}, pierwszy samochód: {c?.PlateNumber}");
            }
            sb.AppendLine($"Wszystkich samochodów: {CarCount}");
            return sb.ToString();

        }

        public void AddCar(int milisecondsTimout)
        {
            Car c = new Car();
            CarFaker.Populate(c);
            Bramki[c.NrBramki].Enqueue(c);
            if (c != null) CarCount++;
            Thread.Sleep(milisecondsTimout);

        }

        public void GetCar(int milisecondsTimout, int NrBramki)
        {
            if (Bramki[NrBramki].Count>0)
            { 
                Car c;
                Bramki[NrBramki].TryDequeue(out c);
                if(c!= null) CarCount--;
                Thread.Sleep(milisecondsTimout);
                
            }

        }
    }

}
