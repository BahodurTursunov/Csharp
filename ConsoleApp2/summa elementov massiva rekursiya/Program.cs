namespace summa_elementov_massiva_rekursiya
{
    // найти сумму элементов массива с помощью рекурсии.

    internal class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length) return 0;

            return myArray[i] + Sum(myArray, i+1);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5, 4, 7 };
            int result = Sum(myArray);
        }
    }
}