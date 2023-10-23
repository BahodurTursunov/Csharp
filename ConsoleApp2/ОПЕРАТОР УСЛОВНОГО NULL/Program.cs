namespace ОПЕРАТОР_УСЛОВНОГО_NULL
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элемента массива " + myArray?.Sum());
        }
    } 
}