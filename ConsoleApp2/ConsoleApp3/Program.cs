using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 КОНВЕРТАЦИЯ СТРОКИ
 PPARSE И TRYPARSE
 parse работает исключително со строчными переменными
 */
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "5.6";
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};
            //double a = double.Parse(str, numberFormatInfo);
            //Console.WriteLine(a);
            //

            //string str = "1";
            //try
            //{
            //    int a = Convert.ToInt32(str);
            //    Console.WriteLine("Успешная конвертация");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Ошибка при конвертации");
            //}
            string str = "1";
            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать");
            }
        }
    }
}
