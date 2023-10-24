// See https://aka.ms/new-console-template for more information

/* ключевое слово static 
 * статические поля класса
 */


class MyClass
{
    public int a;
    public static int b;
}

class Program
{
    static void Main(string[] args)
    {
        MyClass.b = 5; // здесь статическая переменная общая для всех экземпляров класса, и область памяти где хранится это поле, общая для
                       // всех экземпляров этого класса

        MyClass class1 = new MyClass();
        class1.a = 1;

        MyClass class2 = new MyClass();
        class2.a = 2;
    }
}