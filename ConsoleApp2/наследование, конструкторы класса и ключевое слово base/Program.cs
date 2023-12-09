class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass");
    }
}

class Point2D : MyClass
{
    public Point2D()
    {
        Console.WriteLine("Point2D");
    }
    public int X { get; set; }
    public int Y { get; set; }
}

class Point3D : Point2D
{
    public Point3D()
    {
        Console.WriteLine("Point3D");
    }
    public int Z { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Point3D point3D = new Point3D();

    }
}