using System;
namespace Week8;

public class PointRef
{
	public int X { get; set;  }
	public int Y { get; set; }

	public void Start() { 
		Console.WriteLine($"Point: ({X}, {Y})");
    }
}
