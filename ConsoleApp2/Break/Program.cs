using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// break
// continue

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 100; i++)
            //{
            //    string msg = Console.ReadLine();

            //    if (msg == "exit")
            //    {
            //        break;
            //    }
            //Console.WriteLine(i);
            //}

            for (int i = 0; i < 10; i++)
            {
                if (i==2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
