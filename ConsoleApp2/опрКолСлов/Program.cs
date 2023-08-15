namespace опрКолСлов
{
    // В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом.
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            string inputString = Console.ReadLine();

            foreach (char str in inputString)
            {
                if (str == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count++);

        }
    }
}