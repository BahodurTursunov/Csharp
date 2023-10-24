// See https://aka.ms/new-console-template for more information

/* ключевое слово static 
 * статические поля класса
 */


class MyClass 
{
    private static int b; // static поля общие для всех объектов класса

    public void SetB(int b)
    {
        MyClass.b = b;
        //this.b = b; Так делать нельзя в этом случае, потому что переменная b это статическая переменная
    }

    public void PrintB()
    {
        Console.WriteLine(b);
    }
} 
class Program
{
    static void Main(string[] args)
    {
        MyClass class1 = new MyClass();
        class1.SetB(10);

        MyClass class2 = new MyClass();
        class2.PrintB();

        //благодаря модификатору static у поля b, мы скажем так расшарили данные между экземплярами класса,
        //то есть разные экземпляры могут использовать одни и те же данные
    }
}