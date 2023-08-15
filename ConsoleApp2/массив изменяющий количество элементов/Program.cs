namespace массив_изменяющий_количество_элементов
{
    // написать метод Resize изменяющий количество элементов массива
    // (метод должен иметь возможность увеличить или уменьшить
    // количество элементов массива).
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 4, 3, 2 };

            Console.WriteLine($"Дан массив на {myArray.Length} элемента");

            Console.WriteLine("Вы хотите увеличить или уменьшить массив? ");

            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (c == '+')
            {
                Console.WriteLine("На сколько вы хотите увеличить массив?");
                int newSize = int.Parse(Console.ReadLine());
                Resize(ref myArray, newSize);
            }
            if (c == '-')
            {
                Console.WriteLine("На сколько вы хотите уменьшить массив?");
                int newSize = int.Parse(Console.ReadLine());
                Resize(ref myArray, newSize);
            }

            Console.WriteLine("Новое значение массива:");
            foreach (int value in myArray)
            {
                Console.Write(value + " ");
            }

        }
        static void Resize(ref int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
    }
}