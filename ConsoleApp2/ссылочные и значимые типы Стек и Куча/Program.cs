
namespace ссылочные_и_значимые_типы_Стек_и_Куча
{
    internal class Program
    {
        /* Ссылочные (references types) и значимые (value tupes) типы
          Стек (stack) и куча (heap)
         */

        static void Foo(int value)
        {
            value = 5;
        }

        static void Bar(int[] arr)
        {
            arr[0] = 5;
        }
        static void Main(string[] args)
        {
            int[] a = new int[1];
            a[0] = 1;
            Bar(a);
            Console.WriteLine(a[0]);
        }
    }
}