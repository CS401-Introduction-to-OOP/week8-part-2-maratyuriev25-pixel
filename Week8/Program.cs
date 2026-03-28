namespace Week8;

class Program
{
    public static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        Point p2 = p1;

        p1.Print();
        p2.Print();


        PointRef r1 = new PointRef { X = 10, Y = 20 };
        PointRef r2 = r1;

        r1.Start();
        r2.Start();

        BoxingTester.Test();

    }

}