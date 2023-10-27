namespace partial_class__methods__частичные_типы
{
     class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public Person(string firsName, string lastName)
        {
            FirsName = firsName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirsName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
