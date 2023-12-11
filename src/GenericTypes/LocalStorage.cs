using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes;

internal class LocalStorage
{
    private readonly IDictionary<string, string> _storage = new Dictionary<string, string>();

    // Metoda generyczna 
    // Szablon metody do której przekazujemy typ T
    public void Set<T>(string key, T value)        
    {
        _storage.TryAdd(key, value.ToString());
    }
   
    public T Get<T>(string key)
    {
        _storage.TryGetValue(key, out var value);

        return (T)Convert.ChangeType(value, typeof(T));
    }   
}

class Factory
{
    public static object Create(Type type)
    {
        throw new NotImplementedException();
    }

    public static T Create<T>() { 
        throw new NotImplementedException();
    }
}
