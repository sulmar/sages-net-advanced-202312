using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorExample;

internal class ConfigManager
{
    private readonly Dictionary<string, object> settings = new Dictionary<string, object>();

    protected ConfigManager()
    {

    }

    private static ConfigManager instance;

    public static ConfigManager Instance
    {
        get
        {
            if (instance == null)
            {
                Thread.Sleep(2000);

                instance = new();
            }


            return instance;
        }
    }

    public void Set(string key, object value)
    {       
        if (settings.ContainsKey(key))
        {
            settings[key] = value;
        }
        else
        {
            settings.Add(key, value);
        }
    }

    public object Get(string key)
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} getting {key}");

        if (settings.ContainsKey(key))
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} getting {settings[key]}");

            return settings[key];
        }
        else
            return null;

    }
}
