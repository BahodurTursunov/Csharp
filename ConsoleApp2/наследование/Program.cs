/*наследование в ООП*/

using System.Runtime.ExceptionServices;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"Меня зовут {FirstName}");
    }
}
/* если говорить о терминологии, то в данном случае класс Student является наследником класса
 * Person, а класс Person является родительским(базовым классом) для класса Student*/
class Student : Person
{
    public void Learn()
    {
        Console.WriteLine("I`m studying");
    }
}

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Student student = new Student { FirstName = "Bakha", LastName = "Tursunov"};
        student.Learn();
        PrintFullName( student );
=======
        Person person = new Student { FirstName = "Bakha", LastName = "Tursunov"};
        PrintFullName( person );
>>>>>>> b4db24bc5bd799e3be737ced615cb3c8fa001cb1
       
    }
    static void PrintFullName(Person person)
    {
        Console.WriteLine($"LastName: {person.LastName}\t FirstName: {person.FirstName}");
    }
}