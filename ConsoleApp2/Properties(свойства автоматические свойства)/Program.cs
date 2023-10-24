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

    //propfull - снипсет
    private int y;

    public int Y
    {
        get
        {
            return y;
        }
        set // это акцессор set
        {
            if (value < 1)
            {
                y = 1;
                return;
            }
            if (value > 5)
            {
                y = 5;
                return;
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Point px = new Point();
        Point py = new Point();
        px.SetX(10);
        py.Y = 10;
        int x = px.GetX();
        int y = py.Y;
        Console.WriteLine(x);
    }
}