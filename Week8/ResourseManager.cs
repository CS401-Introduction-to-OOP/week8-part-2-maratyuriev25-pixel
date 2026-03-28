namespace Week8;

public class ResourceManager<T> where T : Resourse
{
    private readonly List<T> _resources = new();

    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    public void OpenAll()
    {
        foreach (var resource in _resources)
        {
            resource.Open();
        }
    }
    public void CloseAll()
    {
        foreach (var resource in _resources)
        {
            resource.Close();
        }
    }
}