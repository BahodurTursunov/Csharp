namespace дваОтсортМассива
{
    /*
     * Задан одномерный массив целых чисел. Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа. 
     * Подсказка: четное число делится на 2 без остатка
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через пробел: ");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine();

            int[] evenArray = new int[inputArray.Length];
            int[] oddArray = new int[inputArray.Length];
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in inputArray)
            {
                if (num % 2 == 0)
                {
                    evenArray[evenCount] = num;
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = num;
                    oddCount++;
                }
            }

            Array.Resize(ref evenArray, evenCount);
            Array.Resize(ref oddArray, oddCount);

            Array.Sort(evenArray);
            Array.Sort(oddArray);

            Console.WriteLine("Массив четных чисел: ");
            PrintArray(evenArray);

            Console.WriteLine("Массив нечетных чисел: ");
            PrintArray(oddArray);

        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
        }
        
    }
}