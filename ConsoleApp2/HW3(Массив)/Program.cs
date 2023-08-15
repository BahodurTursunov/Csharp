using System;

namespace HW3_Массив_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 55, 44, 33, 22, 11, 7, 6, 4, 2, 12, 123, 12, 323, 4, 345, 3445, };
            int minValue = myArr[0];

            for (int i = 1; i < myArr.Length; i++)
            {
                if (myArr[i] < minValue)
                {
                    minValue = myArr[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
