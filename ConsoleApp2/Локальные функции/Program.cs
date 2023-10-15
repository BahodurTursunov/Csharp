namespace Локальные_функции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Compare(int[] numbers1, int[] numbers2)
            {
                int numbres1Sum = 0;
                int numbres2Sum = 0;

                //foreach (var numbers in numbers1)
                //{
                //    numbres1Sum += numbers;
                //}

                //foreach (var numbers in numbers2)
                //{
                //    numbres2Sum += numbers;
                //}

                int Sum(int[] numbers)
                {
                    int res = 0;
                    foreach (var item in numbers)
                    {
                        res += item;
                    }
                    return res;
                }

                if (numbres1Sum > numbres2Sum)
                {
                    Console.WriteLine("Сумма чисел nuum1 >");
                }
                else if (numbres1Sum < numbres2Sum)
                {
                    Console.WriteLine("Сумма чисел nuum1 <");
                }
                else
                {
                    Console.WriteLine("сумма чисел =");
                }
            }
            int[] num = { 1, 2, 3 };
            int[] num2 = { 1, 2, 3 };
            Compare(num, num2);
        }
    }
}