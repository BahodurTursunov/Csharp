class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Привет, какую математическую операцию хочешь выполнить?)" +
            "\nПожалуйста, выбери подходящую цифру" +
            "\n1 - Сложение" +
            "\n2 - Вычитание" +
            "\n3 - Умножение" +
            "\n4 - Деление");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Хорошо, теперь введите свои числа, над которыми вы хотите выполнить операцию");
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse((Console.ReadLine()));

        if (num == 1)
        {
            Console.WriteLine("Вы выбрали операцию Сложение, и вот что у нас получилось ");
            Console.WriteLine(Addition(first, second));
        }

        if (num == 2)
        {
            Console.WriteLine("Вы выбрали операцию Вычитание, и вот что получилось ");
            Console.WriteLine(Subtraction(first, second));
        }

        if (num == 3)
        {
            Console.WriteLine("Вы выбрали операцию Умножение, и вот что получилось ");
            Console.WriteLine(Multiplication(first, second));
            if ((first == 0) || (second == 0))
            {
                Console.WriteLine(0);
            }
        }

        if (num == 4)
        {
            Console.WriteLine("Вы выбрали операцию Деление, и вот что получилось ");
            Console.WriteLine(Division(first, second));
            if ( (first == 0) || ( second == 0))
            {
                Console.WriteLine("На ноль Делить нельзя ");
            }
        }
    }

    public static decimal Addition(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static decimal Subtraction(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }

    public static decimal Multiplication(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber * secondNumber;
    }

    public static decimal Division(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber / secondNumber;
    }
}