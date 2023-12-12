using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LazyCollectionExample;

internal class DateHelper
{
    //public static IEnumerable<string> GetWeekDays()
    //{
    //    IEnumerable<string> weekDays = new List<string>
    //    {
    //        "Pn",
    //        "Wt",
    //        "Sr",
    //        "Cz",
    //        "Pt",
    //        "Sb",
    //        "Nd",
    //    };

    //    return weekDays;
    //}

    public static IEnumerable<string> GetWeekDays()
    {
        yield return "Pn";
        yield return "Wt";
        yield return "Sr";
        yield return "Cz";
        yield return "Pt";
        yield return "Sb";
        yield return "Nd";
    }

    public static IEnumerable<object> AsEnumerable(System.Data.DataTable dataTable)
    {
        foreach (var row in dataTable.Rows)
        {
            yield return row;
        }
    }

    public static IEnumerable<int> Generate(int min, int max)
    {
        int current = min;

        while(current <= max)
        {
            yield return current++;
        }
    }

    public static IEnumerable<double> GetTemperatures()
    {        
        Random random = new Random();

        while (true)
        {
            yield return random.NextDouble() * 100;
        }
    }
}
