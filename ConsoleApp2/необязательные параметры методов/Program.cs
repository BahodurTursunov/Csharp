namespace необязательные_параметры_методов
{
    internal class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(result);
            }
            return result; 
        }
        static void Main(string[] args)
        {
            int result = Sum(5, 2);
            Console.WriteLine(result);
        }
    }
}