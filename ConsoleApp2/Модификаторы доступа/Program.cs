using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Reflection;
namespace Модификаторы_доступа
{
    // модификаторы доступа public private, для членов класса
    class Point
    {
        int z = 10;
        public int x = 10;
        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.PrintY();
            p.PrintPoint();

            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t" +
                    $"IsPublic: {item.IsPublic}");
            }
        }
    }
}