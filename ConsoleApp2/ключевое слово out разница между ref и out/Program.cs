namespace ключевое_слово_out_разница_между_ref_и_out
{
    internal class Program
    {
        static void Foo(ref int value)
        {
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Bar(out int a);
        }
    }
}