namespace перегрузка_методов_и_для_чего_она_нужна
{/// <summary>
/// Salam aleykum
/// </summary>
    internal class Program
    {
        /// <summary>
        /// Возвращает сумму двух чисел 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму трех целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Возвращает сумму трех чисел с плавающей точкой
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            double result = Sum(2.1, 3.1, 4.9);
            Console.WriteLine(result);
        }

    }
}