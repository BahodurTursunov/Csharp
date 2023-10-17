using keywordThis_ключевое_слово_this_;
using System.Threading.Channels;

namespace keywordThis_ключевое_слово_this_
{
    /* Ключевое слово this представляет ссылку на текущий экземпляр/объект класса. В каких ситуациях оно нам может пригодиться?*/
    class Person
    {
        public string name;
        public int age;
        public Person() { name = "Unknown"; age = 18; }
        public Person(string name) { this.name = name; age = 18; }
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Name: {name} age {age}");
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person sam = new Person("Sam", 25);
            sam.Print();
        }
    }
