// See https://aka.ms/new-console-template for more information
class Point
{
    private int x;

    public void SetX(int x)
    {
        this.x = x;
    }

    public int GetX()
    {
        return x;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point();
        p.SetX(10);
        
        int x = p.GetX();
        Console.WriteLine(x);
    }
}