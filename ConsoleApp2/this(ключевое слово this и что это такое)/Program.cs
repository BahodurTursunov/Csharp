namespace this_ключевое_слово_this_и_что_это_такое_
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday)
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }
        public void Print()
        {
            Console.WriteLine($"{firstName}\n{lastName}\n{middleName}\n{birthday}");
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Азимов", new DateTime(2001, 07, 02));
            student.Print();
        }
    }
}