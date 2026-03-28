using System;

public class DataContainer<T> where T : class
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long result = 0;
        foreach (var item in _items) {
            result += item.GetTotalSize();
    }
}
