namespace Null___совместимые_знанчимые_типы_Nullable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? i = 2;
            //Console.WriteLine(i); 
            //Console.WriteLine(i==null);
            //Console.WriteLine(i.HasValue);
            //Console.WriteLine(i.GetValueOrDefault());
            //Console.WriteLine(i.GetValueOrDefault(3));
            //Console.WriteLine(i ?? 55);
            //Console.WriteLine(i.Value);
            int? a = 5;
            int? b = 22;
            int? result = a + b;
            Console.WriteLine(result);
            Console.WriteLine(a==b);
            Console.WriteLine(a>b);
            Console.WriteLine(a<b);
        }
    }
}