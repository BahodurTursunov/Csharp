using System.Xml.Serialization;

namespace Модификаторы_доступа
{
    // модификаторы доступа public private, для членов класса
    internal class Program
    {
        static void Main(string[] args)
        {
            //void sum(int intial, params int[] numbers)
            //{
            //    int result = intial;
            //    foreach (var item in numbers)
            //    {
            //        result += item;
            //    }
            //    Console.WriteLine(result);
            //}
            //int[] nums = {1,2,3,4,5,6,7};
            //sum(10,nums);
            //sum(1, 2, 3, 4);
            //sum(1, 2, 3);
            //sum(20);

            //static void display(int[] numbers)
            //{
            //    int res = 0;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        res+= numbers[i];
            //    }
            //    Console.WriteLine(res);
            //}
            //display(new int[] {1,2,3,4});


            
            Display(1, 3, 4, 2);
            Console.ReadKey();
            

            static void Display(params int[] numbers, int r)
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
                result *= r;
                Console.WriteLine(result);
            }
        }
    }
}