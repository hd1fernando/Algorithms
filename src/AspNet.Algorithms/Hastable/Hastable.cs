namespace AspNet.Algorithms;

public class Hastable<TKey, TValue> where TKey : IComparable<TKey>
{
    readonly KeyValuePair<TKey, TValue>[] _data;

    public Hastable(int capacity)
    {
        _data = new KeyValuePair<TKey, TValue>[capacity];
    }

    public void Add(TKey key, TValue value)
    {
        var hash = key.GetHashCode();
        var position = hash % _data.Length;
        _data[position] = new KeyValuePair<TKey, TValue>(key, value);
    }


    public TValue Get(TKey key)
    {
        var hash = key.GetHashCode();
        var position = hash % _data.Length;

        if (_data[position] is null)
            throw new KeyNotFoundException();

        return _data[position].Value;
    }
}

public record KeyValuePair<TKey, TValue>(TKey key, TValue Value);

