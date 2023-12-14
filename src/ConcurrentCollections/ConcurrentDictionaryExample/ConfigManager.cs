using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentDictionaryExample
{
    public class ConfigManager
    {
        private readonly ConcurrentDictionary<string, object> settings = new();

        public void Set(string key, object value)
        {
            // Introduce a delay to allow another thread to interfere
            Thread.Sleep(100);

            if (!settings.TryAdd(key, value))
            {
                settings[key] = value;
            }
        }

        public object? Get(string key)
        {
            if (settings.TryGetValue(key, out object? value))
            {
                return value;
            }
            else
                return null;

        }
    }
}
