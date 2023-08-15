using System;
using System.Linq;

/*
Одномерные массивы
Способы инициализации массива
 */

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = Enumerable.Repeat(5, 10).ToArray();
            int[] myArray = Enumerable.Range(5, 2).ToArray();
            Console.WriteLine("wer"+myArray);
        }   
    }
}