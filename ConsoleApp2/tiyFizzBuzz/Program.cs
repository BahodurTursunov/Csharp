namespace tiyFizzBuzz
{
    public class Program
    {
        public static int CountLowercaseLetters(string inputString)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (Char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            string inputString = "abcsadfsadfasdfasdfasfasdfasdf";
            int result = CountLowercaseLetters(inputString);
            Console.WriteLine(result);
        }
    }
}