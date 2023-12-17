using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Model
{
    public  class Order : BaseEntity 
    {

        public DateTime OrderDate { get; set; }
       
        public Order(int id ,DateTime orderDate)
        {
            base.Id = Id;
            OrderDate = orderDate;            
            
        }

        public Order()
        {            

        }
    }

    public class OrderRaportPosition
    {
        public OrderRaportPosition(int orderHour, int orderCount)
        {
            OrderHour = orderHour;
            OrderCount = orderCount;
        }

        int OrderHour { get; set; }
        int OrderCount { get; set; }

        public override string ToString()
        {
            return $"Godzina: {OrderHour}, liczba zamówień: {OrderCount}";
        }
    }
}
