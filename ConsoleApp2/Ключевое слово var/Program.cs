namespace Ключевое_слово_var
{
    // Ключевое слово var
    // неявно типизированные локальные переменные
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "Hello world!";
            var b = 5;
            var c = new float[10];
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            var t = new { Name = "Bakha", Age = 22 };
            Console.WriteLine(t.GetType);
            Console.WriteLine(t);

            int[] numbers = { 1, 2, 5, 4, 3, 2, 11, 15, 26, 43 };
            var result = from i in numbers where i > 15 select i;
            foreach (var item in result) 
            {
                Console.WriteLine($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Тип данных result {result.GetType()}");
        }
    }
}