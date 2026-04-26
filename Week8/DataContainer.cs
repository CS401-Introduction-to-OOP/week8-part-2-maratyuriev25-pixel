namespace Week8;
using System.Collections.Generic;


public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long result = 0;
        foreach (var item in _items)
        {
            result += item.GetTotalSize();
        }
    }
}
