using System.ComponentModel;

namespace ДЗметодыПоиска
// написать метод для поиска индекса элемента массива (тип элемента в массиве - Int),
// метод должен вернуть индекс первого найденного элемента (если он будет найден)
{
    internal class Program
    {
        static int IndexOf(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] myArr = GetRandomArray(10, -20, 10);
            int result = IndexOf(myArr, 2);

            Console.WriteLine(result);
        }
    }
}