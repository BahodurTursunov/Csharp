using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace представление_отрицательных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //Console.WriteLine("Введите значение для а");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите значение для b");
            //b = int.Parse(Console.ReadLine());

            //string result;
            ////if (a > b)
            ////{
            ////    result = "a Больше, чем b";
            ////}
            ////else if (a < b)
            ////{
            ////    result = "b Больше, чем a";
            ////}
            ////else
            ////{
            ////    result = "a равно b";
            ////}
            ////Console.WriteLine(result);

            //result = a > b ? "a Больше, чем b" : a < b ? "b Больше, чем a" : "a равно b";
            //Console.WriteLine(result);

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("Введите сумму вкалада");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев");
            int countOfMounth = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= countOfMounth; i++)
            {
                depositAmount += depositAmount * 0.07M;
            }
            Console.WriteLine($"После {countOfMounth} месяцев сумма вклада составит {depositAmount}");
            Console.ReadKey();
        }

        
    }
}