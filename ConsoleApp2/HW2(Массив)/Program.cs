using System;

namespace HW2_Массив_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nВывод массива:");

            for (int i = myArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArr[i]);
            }
        }
    }
}
