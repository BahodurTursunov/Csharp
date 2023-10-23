using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_class_constructors_перегрузка_конструкторов_класса__задача
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private DateTime _birthday;

        public Student(string lastName, DateTime birhday)
        {
            _lastName = lastName;
            _birthday = birhday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birhday)
        {
            _firstName = firstName;
            _lastName = lastName;
            _middleName = middleName;
            _birthday = birhday;
        }
        public Student(Student student)
        {
            _firstName = student._firstName;
            _lastName = student._lastName;
            _middleName = student._middleName;
            _birthday = student._birthday;
        }

        public void Print()
        {
            Console.WriteLine($"{_firstName}\n{_lastName}\n{_middleName}\n{_birthday}");
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Турсунов", "Баходурхон", "Азимджонович", new DateTime(2001, 07, 02));

            //Student student1 = student;    // здесь при вызове метода setLastName меняется фамилия и у первого и у второго студента,
            // потому что мы работаем с классами которые ссылаются на одну и ту же область памяти

            // и поэтому нам надо сконструировать новый объект
            Student student1 = new Student(student); // важно

            student1.SetLastName("Измаилов");

            student.Print();

            Console.WriteLine();

            student1.Print();

        }
    }
}
