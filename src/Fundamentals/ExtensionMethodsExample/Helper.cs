using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample.Course;

public class DateTimeHelper
{
    public static bool IsHoliday(DateTime dateTime)
    {
        return dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
    }
}


public static class DateTimeExtensions
{
    // Metoda rozszerzająca
    // Klasa i metoda muszą być statyczne oraz pierwszy argument funkcji posiadać this
    public static bool IsHoliday(this DateTime dateTime)
    {
        return dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
    }

    public static DateTime AddWorkDays(this DateTime dateTime, int days)
    {
        return DateTime.Now.AddDays(days);
    }
}
