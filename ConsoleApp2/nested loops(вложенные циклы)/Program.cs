using System;

namespace nested_loops_вложенные_циклы_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация " + i);

                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация " + j);
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация " + k);
                    }
                }
            }
        }
    }
}
