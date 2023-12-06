namespace наследованиеTASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Martin", LastName = "Dugin" };
            Student student = new Student { FirstName = "Bakha", LastName = "Tursunov" };
            Person[] people = { teacher, student };

            PrintPersons(people);
        }

        public static void PrintPersons(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}
