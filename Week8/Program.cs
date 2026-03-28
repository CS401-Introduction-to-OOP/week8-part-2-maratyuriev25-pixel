using System;
namespace Week8;


class Program
{
    static void Main(string[] args)
    {
        var fileResource = new FileResourse("file1", false);
        var NetworkResource = new NetworkResource("network1", false);
        var manager = new ResourceManager<Resourse>();

        manager.Add(fileResource);
        manager.Add(NetworkResource);
        
        manager.OpenAll();
        NetworkResource.Dispose();
        manager.CloseAll();
    }
}