namespace extension_methods_метод_расширения__расширяющие_методы_
{
    class Programm
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Thursday));
        }

    }
}