
namespace ОПЕРАТОР_ОБЪЕДИНЕНИЯ_С_NULL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string result = str ?? "";
            Console.WriteLine(result.Length);
        }
    }
}