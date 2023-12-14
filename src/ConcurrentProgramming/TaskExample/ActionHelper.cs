using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample;

class Printer
{
    public void Move()
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Move");
    }

    public void Rotate()
    {
        Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} Rotate");
    }
}

internal class ActionHelper
{
    public static Action FromMethodName<T>(string methodName)
    {
        var t = typeof(T);
        var m = t.GetMethod(methodName, Array.Empty<Type>());

        Action action = new Action(() => m.Invoke(null, null));

        return action;
    }
}
