namespace minmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 4, 3, 2, 21, 2, 42, 5, 5, 34, 12 };
            int max = Max(numbers);
            int min = Min(numbers);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        static int Max(List<int> list)
        {
            int max = list[0];

            foreach (var num in list)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;

        }
        static int Min(List<int> list)
        {
            int min = list[0];
            foreach (var num in list)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }


}
