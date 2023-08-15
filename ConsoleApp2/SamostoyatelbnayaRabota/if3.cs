using System;

/*  Дано целое число. Если оно является положительным, то прибавить к нему 1;
 *  если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10.
 *  Вывести полученное число.
 */

namespace SamostoyatelbnayaRabota
{
    internal class if3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) a++;
            if (a < 0) a = a - 2;
            if (a == 0) a = 10;
            Console.WriteLine(a);
        }
    }
}
