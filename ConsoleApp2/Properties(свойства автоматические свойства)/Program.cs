// See https://aka.ms/new-console-template for more information
class Point
{
    private int x;

    public void SetX(int x)
    {
        if (x < 1)
        {
            this.x = 1;
            return;
        }
        if (x > 5)
        {
            this.x = 5;
            return;
        }
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