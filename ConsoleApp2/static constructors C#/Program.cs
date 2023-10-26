/* Ключевое слово static
 * Статические конструктор*/

using System.Threading.Channels;

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constuctos");
    }

    static MyClass()
    {
        Console.WriteLine("Static Constructots");
    }

    public static void Foo()
    {
        Console.WriteLine("Foo");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        //MyClass c1 = new MyClass();
        MyClass.Foo();
        new MyClass();
        new MyClass();
        new MyClass();
    }
}