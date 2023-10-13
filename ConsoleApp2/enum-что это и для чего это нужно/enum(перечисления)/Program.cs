
namespace enum_что_это_и_для_чего_это_нужно
{
    internal class Program 
    {
        // enum (перечисления) 
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");
                if(key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали Enter!");
                }
            }

        }
    }
}