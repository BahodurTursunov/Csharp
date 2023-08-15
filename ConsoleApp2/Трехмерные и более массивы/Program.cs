namespace Трехмерные_и_более_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,,] arr = new int[3, 2, 3, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        for (int q = 0; q < arr.GetLength(3); q++)
                        {
                            arr[i, j, k, q] = random.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Страница номер: " + (i + 1) + "==");

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        for (int q = 0; q < arr.GetLength(3); q++)
                        {
                            Console.Write(arr[i, j, k, q] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}