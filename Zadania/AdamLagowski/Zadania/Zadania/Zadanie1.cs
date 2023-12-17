using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania.Model;
using Zadania.Fakers;

namespace Zadania
{
    public static class Zadanie1
    {
        public static IEnumerable<OrderRaportPosition> GetOrderHours(int hourStart, int hourEnd, int ilosc)
        {
            var orderFaker = new OrderFaker(hourStart, hourEnd);
            var orders = orderFaker.Generate(ilosc);
            var groups = orders.GroupBy(order => order.OrderDate.Hour)
                .OrderByDescending(group => group.Count() )
                .Select(group => new OrderRaportPosition(group.Key, group.Count()));

            return  groups;
        }
    }
}
