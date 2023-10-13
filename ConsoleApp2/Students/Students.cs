using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Students
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"firstName: {firstName}");
            Console.WriteLine($"lastName: {lastName}");
            Console.WriteLine($"middleName: {middleName}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"group: {group}");
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName} {middleName}";
        }

    }

}
