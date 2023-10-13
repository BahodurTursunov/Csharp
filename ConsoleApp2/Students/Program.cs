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

     
        static void Main(string[] args)
        {
            var firstStudent = GetStudents();
            string fullname = firstStudent.GetFullName();
            Console.WriteLine(fullname);
        }
    }
}