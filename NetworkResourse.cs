using System;
namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open() 
    { 
        Console.Writeline("File opened");
    }
    public override void Close()
    {
        Console.Writeline("File closed");
    }
    public void Dispose()
    {
        Close();
        Console.Writeline("File closed");
    }
}