using System;
namespace Week8;

public class BoxingTester
{
	public static void Test()
	{
        int a = 10;
        object b = a;

        int c = (int)b;

        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a);
    }
}
