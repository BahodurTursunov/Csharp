namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> square = x => x * x;
            int result = square(5);
            Console.WriteLine(result);
        }
    }
}