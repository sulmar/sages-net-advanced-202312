using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample;

internal class Depot
{
    private readonly IDictionary<string, Stack<string>> places = new Dictionary<string, Stack<string>>();

    public Depot()
    {
        places.Add("Place1", new Stack<string>());
        places.Add("Place2", new Stack<string>());
    }



    public void AddItem(string item, string place)
    {
        places[place].Push(item);
    }

    public string SendItem(string place)
    {
        string item = places[place].Pop();

        return item;
    }

    public void DisplayDepotContents()
    {
        
        foreach (var place in places.Keys)
        {
            Console.WriteLine(place);

            foreach (var item in places[place])
            {
                Console.WriteLine(item);
            }
        }
    }
}
