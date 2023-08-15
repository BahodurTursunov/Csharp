using System;


/* Тернарный оператор
 * [первый операнд - условие] ? [второй операнд if_true]:[третий операнд if_false]
 */
namespace ternarniyOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            string entePassword = Console.ReadLine();

            //if(entePassword == storedPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}
            accessAllowed = entePassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);
        }
    }
}
