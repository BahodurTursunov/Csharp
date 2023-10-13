namespace Students
{
 internal class Program
    {
        static Students GetStudents()
        {
            Students students = new Students();
            students.id = Guid.NewGuid();
            students.firstName = "Bahodurkhon";
            students.lastName = "Tursunov";
            students.middleName = "Azimjonovich";
            students.age = 22;
            students.group = "НФИБД-03-19";
            return students;
        }    

        static void Print(Students students)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"ID: {students.id}");
            Console.WriteLine($"firstName: {students.firstName}");
            Console.WriteLine($"lastName: {students.lastName}");
            Console.WriteLine($"middleName: {students.middleName}");
            Console.WriteLine($"age: {students.age}");
            Console.WriteLine($"group: {students.group}");

        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudents();
            Print(firstStudent);
        }
    }
}