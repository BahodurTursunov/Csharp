namespace imenovannieParametri_metodi_
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
            int firstValue = 5;
            int secondValue = 5;
            int result = Sum(firstValue, secondValue, enableLogging: true); // здесь реализуется этот метод
            Console.WriteLine(result);
        }
    }
}