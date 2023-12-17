using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DumpExtensions
    {
        public static void Dump<T>(this IEnumerable<T> elements, string message = "")
        {
            Console.WriteLine(message);

            foreach (var element in elements)
            {
                
                Console.WriteLine(element);
            }
        }

    }
}
