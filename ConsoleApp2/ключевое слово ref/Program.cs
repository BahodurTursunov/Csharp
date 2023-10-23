namespace ключевое_слово_ref
{
    // ключевое слово ref
    // передача аргументов по ссылке
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 1, 2, 3 };
            ref int b = ref arr[0];
            //int b = arr[0];
            b = -5;

        }
        static void Foo(ref int a)
        {
            
        }
    }
}