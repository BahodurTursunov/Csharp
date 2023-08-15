namespace Arrays
{
    internal class Program
    {
        /* Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Введите символ для подсчета его вхождения: ");
            char targetChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int totalCharacters = inputString.Length; // присвоили длину нашего списка в постоянную переменную
            int occurrences = 0;

            foreach (char item in inputString)
            {
                if (item == targetChar)
                {
                    occurrences++;
                }
            }
            double percentage = (double)occurrences / totalCharacters * 100;
            Console.WriteLine($"Символ '{targetChar}' встречается в строке {percentage:F2}% раз.");
            Console.ReadKey();
        }
    }
    // 1 мы начинаем с запроса у пользователя ввода строки с помощью 'Console.ReadLine()'

    // 2 Затем запрашиваем у пользователя символ для подсчета его вхождения с помощью 'Console.ReadKey().KeyChar'

    // 3 Далее мы создаем переменные 'totalCharacters' и 'occurrences'. 'totalCharacters' хранит общее количество символов во введенной строке, а 
    // 'occurrences' - количество вхождений заданного символа в строку

    // 4 Мы используем цикл 'foreach' чтобы перебрать каждый символ в строке и проверить, равен ли он заданному символу ('targetChar').
    // Если символы совпадают, увеличиваем 'occurrences' на еденицу.

    // 5 Вычисляем процент вхождения заданного символа в строку, разделив количество вхождений (occurrences) на общее количество символов (totalCharacters) и умножив на 100.
    // Это значение сохраняем в percentage.

    // 6 В конце выводим результат, форматируя процентное значение с помощью строки формата "{0:F2}", чтобы получить два знака после запятой.
}