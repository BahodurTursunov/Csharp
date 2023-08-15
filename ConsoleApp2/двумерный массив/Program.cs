namespace двумерный_массив
{

    /*
     * многомерные массивы 
     * двумерный прямоугольный массив
     * инициализация 
     * обращение к элементам двумерного массива
     * заполнение двумерного массива случайными числами
     * заполнение двумерного массива с клавиатуры
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //            // тип данных [,] имя массива; Для создания двумерного массива одна запятая
            //            int[,] arr =
            //                        {
            //                        { 15, 21, 32, 54, 5 },
            //                        { 13, 22, 123, 32, 34 },
            //                        { 11, 212, 233, 2111, 123 },
            //                        { 15, 21, 32, 54, 5 }
            //                        };

            //            //int height = arr.GetLength(0);
            //           // int width = arr.GetLength(1);
            //            for (int y = 0; y < arr.GetLength(0); ++y)
            //            {
            //                for (int x = 0; x < arr.GetLength(1); x++)
            //                {
            //                    Console.Write(arr[y,x] + "\t");
            //                }
            //                Console.WriteLine();
            //            }

            ///////////////////////////////////////////////////////////////////////////////////
            //            Console.WriteLine("\n");
            //            foreach (var item in arr)
            //            {
            //                Console.Write(item + " ");
            //            }


            ////////////////////////////////////////////////////////////////////////////////////
            // * заполнение двумерного массива случайными числами
            // *заполнение двумерного массива с клавиатуры

            //int[,] arr = new int[10, 6];

            //Random random = new Random();

            //for (int y = 0; y < arr.GetLength(0); ++y)
            //{
            //    for (int x = 0; x < arr.GetLength(1); x++)
            //    {
            //        arr[y, x] = random.Next();
            //    }
            //}

            //for (int y = 0; y < arr.GetLength(0); ++y)
            //{
            //    for (int x = 0; x < arr.GetLength(1); x++)
            //    {
            //        Console.Write(arr[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            /////////////////////////////////////////////////////////////////
            //int[,] arr = new int[2, 3];


            //for (int y = 0; y < arr.GetLength(0); ++y)
            //{
            //    for (int x = 0; x < arr.GetLength(1); x++)
            //    {
            //        Console.WriteLine(" Y: " + y + " X: " + x);
            //        arr[y, x] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}

            //for (int y = 0; y < arr.GetLength(0); ++y)
            //{
            //    for (int x = 0; x < arr.GetLength(1); x++)
            //    {
            //        Console.Write(arr[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            string[,] arr = new string[2, 3];


            for (int y = 0; y < arr.GetLength(0); ++y)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.WriteLine(" Y: " + y + " X: " + x);
                    arr[y, x] = Console.ReadLine();
                }
            }

            Console.WriteLine();

            for (int y = 0; y < arr.GetLength(0); ++y)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.Write(arr[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}