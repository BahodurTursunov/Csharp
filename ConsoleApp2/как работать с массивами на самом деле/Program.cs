using System;
namespace как_работать_с_массивами_на_самом_деле
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 11, 10, 4, 5, 3, 23, 12, 1, 23, 4, 5, 453, 234, 23 };
            //Array.Sort(myArray);
            Array.Reverse(myArray);
            int result = Array.Find(myArray, i => i < 70); // метод find пробежится от начала массива до конца, будет проверять каждый элемент и найдет первое число, которое удовлетворит условию, поместит в нашу переменную result 
            int result1 = Array.FindLast(myArray, i => i < 70); // метод findLast пробежится от конца массива до начала, будет проверять каждый элемент и найдет первое число, которое удовлетворит условию, поместит в нашу переменную result 
            int[] result2 = Array.FindAll(myArray, i => i < 70); // метод find пробежится от начала массива до конца, будет проверять каждый элемент и найдет все числа, которые удовлетворят условию, поместит в нашу переменную result 
            int result3 = Array.FindIndex(myArray, i => i == 23); 
            int result4 = Array.FindLastIndex(myArray, i => i == 23);
            
            //int[] result = myArray.Distinct().ToArray();
            //int[] result1 = myArray.OrderBy(i >= i).ToArray(); // порядок возрастания
            //int[] result1 = myArray.OrderByDescending(i >= i).ToArray(); // порядок 
            // Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());


        }


    }
}
