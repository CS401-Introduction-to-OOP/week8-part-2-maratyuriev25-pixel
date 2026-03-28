using System;
namespace Week8;

public abstract class Resourse
{
	string Name { get; set; }
	bool IsOpen { get; set; }

	protected Resourse(string name)
	{
		Name = name;
		IsOpen = false;
    }

    abstract void Open();
	
    abstract void Close();

}
