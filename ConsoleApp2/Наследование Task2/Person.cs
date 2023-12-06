using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace наследование.task2
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName(Person person)
        {
            Console.WriteLine($"LastName: {person.LastName}\t FirstName: {person.FirstName}");
        }
    }

}

