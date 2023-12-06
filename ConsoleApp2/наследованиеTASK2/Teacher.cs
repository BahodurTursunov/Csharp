using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace наследованиеTASK2
{
    internal class Teacher : Employee
    {
        public void Teach()
        {
            Console.WriteLine("I`m teaching");
        }
    }
}
