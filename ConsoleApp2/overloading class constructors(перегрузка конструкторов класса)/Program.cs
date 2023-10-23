namespace overloading_class_constructors_перегрузка_конструкторов_класса_
{
    class Point
    {
        public Point()
        {
            _x = _y = 1;
        }

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"{_x} - {_y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
        }
    }
}