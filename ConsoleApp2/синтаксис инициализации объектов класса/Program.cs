using синтаксис_инициализации_объектов_класса;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.FirstName = "ALex";
        p1.LastName = "Tur";
        Address address = new Address();
        address.Country = "Khujand";
        address.Region = "Sogd";
        address.City = "tajikistan";
        p1.Address = address;

        Person p2 = new Person()
        {
            FirstName = "Bakha",
            LastName = "Tursunov ",
            Address = new Address()
            {
                Country = "Tajikistan",
                Region = "Sogd",
                City = "Khujand",
            }
        };
    }
}
