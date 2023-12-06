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
        Person person = new Student { FirstName = "Bakha", LastName = "Tursunov"};
        PrintFullName( person );
       
    }
    static void PrintFullName(Person person)
    {
        Console.WriteLine($"LastName: {person.LastName}\t FirstName: {person.FirstName}");
    }
}