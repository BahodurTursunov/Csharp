using System;

namespace oddEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона");

            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }
            Console.WriteLine("Количество нечётных чисел: " + oddNumbersCount);
            Console.WriteLine("Количество чётных чисел: " + evenNumbersCount);
            Console.WriteLine("Сумма нечётных чисел: " + oddNumbersSum);
            Console.WriteLine("Сумма чётных чисел: " + evenNumbersSum);
        }
    }
}
