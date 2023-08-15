namespace ОПЕРАТОР_ПРИСВАИВАНИЯ_ОБЪЕДИНЕНИЯ_СО_ЗНАЧЕНИЕМ_NULL
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = new int[11];
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            myArray ??= new int[1];

            Console.WriteLine("количество элементов в массиве " + myArray.Length);
        }
    }
}