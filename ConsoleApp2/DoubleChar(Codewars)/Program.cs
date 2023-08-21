namespace DoubleChar_Codewars_
{
    class Program
    {
        static string RepeatCharacters(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                result += new string(c, 2);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RepeatCharacters("String"));      // Вывод: "SSttrriinngg"
            Console.WriteLine(RepeatCharacters("Hello World")); // Вывод: "HHeelllloo  WWoorrlldd"
            Console.WriteLine(RepeatCharacters("1234!_ "));     // Вывод: "11223344!!__  "
        }
    }

}