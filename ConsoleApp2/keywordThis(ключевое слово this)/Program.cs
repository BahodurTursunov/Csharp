using keywordThis_ключевое_слово_this_;
using System.Threading.Channels;

namespace keywordThis_ключевое_слово_this_
{
    /* Ключевое слово this представляет ссылку на текущий экземпляр/объект класса. В каких ситуациях оно нам может пригодиться?*/
    /* В примере ниже во втором и третьем конструкторе параметры называются также, как и поля класса. И чтобы разграничить параметры и поля класса,
     * к полям класса обращение идет через ключевое слово this. Так, в выражении this.name=name;
     * первая часть - this.name означает, что name - это поле текущего класса, а не название параметра name. 
     * Если бы у нас параметры и поля назывались по разному, то использовать слово this было бы необязательно. Также через ключевое this можно 
     * обращаться к любому полю или методу
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
    