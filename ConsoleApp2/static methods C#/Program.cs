/* Ключевое слово static
 * Статические методы класса
 * Статические свойства класса
 */

class MyClass
{
	private static int counter;

    public MyClass()
    {
        counter++;
    }
    public static int Counter
	{
		get { return counter; }
		set { counter = value; }
	}

}
class Programm
{
    static void Main(string[] args)
    {
        MyClass c = new MyClass();
        MyClass c1 = new MyClass();
        MyClass c2 = new MyClass();
        // MyClass.Counter = -100; если мы сделаем так, то нарушится инкапсуляция, мы не должный иметь возможность обновлять счетчик
        // какимто образом вне класса, потому что мы можем поломать логику этого счетчика, именно в этом заключается задача свойств
        Console.WriteLine(MyClass.Counter);
    }
}