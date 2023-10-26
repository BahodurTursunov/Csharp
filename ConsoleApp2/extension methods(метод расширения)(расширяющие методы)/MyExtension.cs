namespace extension_methods_метод_расширения__расширяющие_методы_
{
    static class MyExtension
    {
        public static void Print(this DateTime datetime)
        {
            Console.WriteLine(datetime);
        }

        public static bool IsDayOfWeek(this DateTime datetime, DayOfWeek dayOfWeek) 
        {
            return datetime.DayOfWeek == dayOfWeek;
        }
    }
}
