/* Полиморфизм 
 * 
 * виртуальные методы
 * 
 * virtual
 * 
 * override
 * 
 */

class Car
{
    public void Drive()
    {
        Console.WriteLine("Я машина, я еду!");
    }
}

class SportCar : Car
{

}
class Person
{
    public void Drive(Car car)
    {
        car.Drive();
    }

}


class Program
{
    static void Main(string[] args)
    {
        //Car car = new Car();

        //Person person = new Person();

        //person.Drive(car);

        Person person = new Person();

        person.Drive(new SportCar());
    }
}