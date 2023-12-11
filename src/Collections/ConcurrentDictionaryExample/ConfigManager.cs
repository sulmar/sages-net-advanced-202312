using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentDictionaryExample
{
    public class ConfigManager
    {
        private readonly Dictionary<string, object> settings = new Dictionary<string, object>();

        public void Set(string key, object value)
        {
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
