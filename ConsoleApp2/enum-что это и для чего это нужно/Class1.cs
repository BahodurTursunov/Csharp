using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_что_это_и_для_чего_это_нужно
{
    internal class Class1
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek;
            int value = 5;
            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek = (DayOfWeek)value; // приводим dayOfWeek к int
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value.");
            }
            Console.WriteLine(dayOfWeek);
        }
    }
    
}
