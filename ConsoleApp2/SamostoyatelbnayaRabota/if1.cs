using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Дано целое число. Если оно является положительным, то прибавить к нему 1;
 *  в противном случае не изменять его. Вывести полученное число.
 */

namespace SamostoyatelbnayaRabota
{
    internal class if1
    {
        static void main(string[] args)
        { 
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) a++;
            Console.WriteLine(a);
        }
    }
}
