using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExample;

// Trick - aby można było użyć własnego enumeratora w foreach
// należy zaimplementować interfejs IEnumerable poprzez:
// public IEnumerator GetEnumerator() => this;

internal class MyEnumerator : IEnumerator, IEnumerable
{
    private int[] data;
    private int position = -1;

    public MyEnumerator(int[] data)
    {
        this.data = data;
    }

    public object Current
    {
        get
        {
            if (position == -1 || position >= data.Length)
                throw new InvalidOperationException();

            return data[position];
        }
    }

    public IEnumerator GetEnumerator() 
    {
        return this;
    }

    public bool MoveNext()
    {
        position++;

        if (position < data.Length)
        {
            position++;
        }
        

        return position < data.Length;
    }

    public void Reset()
    {
        position = -1;
    }
}
