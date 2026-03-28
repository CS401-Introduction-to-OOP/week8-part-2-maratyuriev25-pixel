using System;
namespace Week8;

public abstract class Resourse
{
	string Name { get; set; }
	bool IsOpen { get; set; }

	protected Resourse(string name, bool isOpen)
	{
		Name = name;
		IsOpen = isOpen;
    }

    public abstract void Open();
	
     public abstract void Close();

}
