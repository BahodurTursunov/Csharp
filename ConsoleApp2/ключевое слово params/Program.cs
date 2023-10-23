namespace ключевое_слово_params
{
    //internal class Program
    //{
    //    static int Sum(string str, params int[] parametrs) // и ключевое слово params ныдо вызывать в последнюю очередь в вызове
    //    {
    //        int result = 0;

    //        for (int i = 0; i < parametrs.Length; i++)
    //        {
    //            result += parametrs[i];
    //        }
    //        return result;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int result = Sum("helloworker", 2, 3);
    //        Console.WriteLine(result);
    //    }
    //}
    internal class Programm2
    {
        static void Foo(params object[] parametrs)
        {
            string message = "Тип данных {0}, значение {1}";

            foreach (var item in parametrs)
            {
                Console.WriteLine(message, item.GetType(), item );
            }
        }

        static void Main(string[] args)
        {
            Foo("test", 5, 'q', 5.1f, true);
        }
    }
}