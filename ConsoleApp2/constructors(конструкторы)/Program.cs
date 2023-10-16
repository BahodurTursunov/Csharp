using System.Reflection.Metadata;

namespace constructors_конструкторы_
{
    class Person
    {
        public string name;
        public int age;
        public Person() {
            Console.WriteLine("Создание объекта Person");
            name = "Tom";
            age = 21;
        }
        public void Print ()
        {
            Console.WriteLine($"Имя: {name} Возраст: {age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.Print();
        }

    }
}