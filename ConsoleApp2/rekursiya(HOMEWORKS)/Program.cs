namespace rekursiya_HOMEWORKS_
{
    // реализовать вывод массива с помощью рекурсии.

    // найти сумму элементов массива с помощью рекурсии.

    // Найти сумму цифр числа с помощью рекурсии. 561 = 12
    internal class Program
    {
        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i + 1);
            }
        }       
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 10 };
            PrintArray(myArray);
        }
    }
}