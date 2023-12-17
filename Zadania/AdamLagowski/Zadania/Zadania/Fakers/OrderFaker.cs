using Bogus;
using Zadania.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Fakers
{
    public class OrderFaker :Faker<Order>
    {

        public OrderFaker(int hourStart, int hourEnd)
        {
            DateTime start = DateTime.Now.Date.AddHours(hourStart);
            DateTime end = DateTime.Now.Date.AddHours(hourEnd);
            UseSeed(0);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.OrderDate, f => f.Date.Between(start, end));
        }

        public OrderFaker()
        {
            DateTime start = DateTime.Now.Date.AddHours(0);
            DateTime end = DateTime.Now.Date.AddHours(23);
            UseSeed(0);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.OrderDate, f => f.Date.Between(start, end));
        }

    }
}
