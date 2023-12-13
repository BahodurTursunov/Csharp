namespace модификатор_доступа_protected_при_наследовании
{
    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;

        public A()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField);
            //Console.WriteLine(a.privateField);
            //Console.WriteLine(a.protectedField);
        }
    }
}
