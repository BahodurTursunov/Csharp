namespace ООП._Класс._Объект_класса
{
    internal class Program
    {
        enum Color
        {
            Red,
            Black,
            Blue,
            Pink,
            Green,
            White
        }
        class Point
        {
            public int x;
            public int y;
            public Color color;
        }
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 4;
            p.y = 2;
            p.color = Color.Red;
            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");

            Point p2 = new Point();
            p2.x = 3;
            p2.y = 4;
            p2.color = Color.Black;
            Console.WriteLine($"X: {p2.x} | Y: {p2.y} | Color: {p2.color}");
        }
    }
}