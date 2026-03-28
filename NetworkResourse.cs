using System;
namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        throw new NotImplementedException("File, opened");
    }
    public override void Close()
    {
        throw new NotImplementedException("File closed");
    }
    public void Dispose()
    {
        Close();
        throw new NotImplementedException("File closed");
    }
}