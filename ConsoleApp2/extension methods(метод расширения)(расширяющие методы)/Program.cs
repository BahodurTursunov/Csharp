namespace extension_methods_метод_расширения__расширяющие_методы_
{
    class Programm
    {
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Tursunov", LastName = "Bahodur" };
            string fullName = student.GetFullName();
            Console.WriteLine(fullName);
        }

    }
}