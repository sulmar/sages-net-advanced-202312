using System.Collections;

namespace EnumeratorExample;

internal class CircularEnumerator<T> : IEnumerator<T>, IEnumerable
{
    private readonly IEnumerator _wrappedEnumerator;

    public CircularEnumerator(IEnumerator wrappedEnumerator)
    {
        _wrappedEnumerator = wrappedEnumerator;
    }

    public T Current => (T)_wrappedEnumerator.Current;
    object IEnumerator.Current => _wrappedEnumerator.Current;

    public void Dispose()
    {
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (!_wrappedEnumerator.MoveNext())
        {
            _wrappedEnumerator.Reset();

            return _wrappedEnumerator.MoveNext();
        }

        return true;
    }

    public void Reset()
    {
        _wrappedEnumerator.Reset();
    }

  
}
