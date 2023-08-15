using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 конвертация строки 
 класс convert
 */

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string str;

              int a, b;

              Console.WriteLine("Введите первое число");

              str = Console.ReadLine();

              a = Convert.ToInt32(str);

              Console.WriteLine("Введите второе число");

              str = Console.ReadLine();

              b = Convert.ToInt32(str);

              int result = a + b;

              Console.WriteLine("Сумма чисел = " + result);*/

            string str = "1.6";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine(a);
        }
    }
}
