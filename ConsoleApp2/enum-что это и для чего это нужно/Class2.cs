using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_что_это_и_для_чего_это_нужно
{
    internal class Class2
    {
        enum Color
        {
            white, black, red, green, blue, alpha
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();   
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase : true);
            Console.WriteLine(color);
            switch (color)
            {
                case Color.white:
                    break;
                case Color.black:
                    break;
                case Color.red:
                    break;
                case Color.green:
                    break;
                case Color.blue:
                    break;
                case Color.alpha:
                    break;
                default:
                    break;
            }
        }
    }
}
