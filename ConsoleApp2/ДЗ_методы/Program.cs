namespace ДЗ_методы
{
    // написать метод который выводит на экран строку.
    // символы из которых состоит строка и их количество вводится пользователей.

    // написать метод для поиска индекса элемента массива (тип элемента в массиве - Int),
    // метод должен вернуть индекс первого найденного элемента (если он будет найден)
    internal class Program
    {
        static void inputStr(string symbol, uint symbolsCount)//(char symbol, uint symbolsCount)
        {
            for (int i = 1; i <= symbolsCount; i++)
            {
                Console.Write(i + ":" + symbol);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string str = Console.ReadLine();
           // char str = Console.ReadKey().KeyChar;

            Console.WriteLine("Введите количество символов: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            inputStr(str, symbolsCount);
        }
    }
}