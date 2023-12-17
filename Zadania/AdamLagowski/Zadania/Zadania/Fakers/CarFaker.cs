using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Zadania.Model;

namespace Zadania.Fakers
{
    public class CarFaker : Faker<Car>
    {
        public CarFaker( int iloscBramek)
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.PlateNumber, f => new string(f.Random.Chars('A', 'Z', 10)));
            RuleFor(p => p.NrBramki, f => f.Random.Int(0,iloscBramek-1));
        }
    }
}
