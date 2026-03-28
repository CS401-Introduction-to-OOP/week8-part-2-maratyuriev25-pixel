using System;
namespace Week8;

public class FileResourse : Resourse, IDisposable
{
    public FileResourse(string name) : base(name)
    {
    }

    public override void Open() 
    { 
        throw new NotImplementedException();
    }

    public override void Close()
    {
        throw new NotImplementedException();
    }

    public void Dispose() 
    {
        Close();
        throw new NotImplementedException();
    }
