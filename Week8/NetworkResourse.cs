using System;
namespace Week8;

public class NetworkResource : Resourse, IDisposable
{
    public NetworkResource(string name, bool isOpen) : base(name, isOpen){}
    public override void Open() 
    { 
        Console.WriteLine("File opened");
    }
    public override void Close()
    {
        Console.WriteLine("File closed");
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine("File closed");
    }
}