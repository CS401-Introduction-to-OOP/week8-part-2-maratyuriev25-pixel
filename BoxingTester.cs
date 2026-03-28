namespace Week8;

public class BoxingTester
{
	public static void Test()
	{
        int a = 10;
        object b = a;

        int c = (int)b;

        Console.WriteLine(c); // here we have a boxed value of a, and we unbox it back to an int so it will be 10
        Console.WriteLine(b); // here we have a boxed value of a, so it will be 10
        Console.WriteLine(a); // here we have the original value of a, so it will be 10
    }
}
