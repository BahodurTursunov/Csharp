namespace день_недели
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели от 1 до 7 цифрами: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());


            switch (dayOfWeek)
            {
                case 1:
                    if (dayOfWeek == 1)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Понедельник");
                    }
                    break;
                case 2:
                    if (dayOfWeek == 2)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Вторник");

                    }
                    break;
                case 3:
                    if (dayOfWeek == 3)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Среда");

                    }
                    break;
                case 4:
                    if (dayOfWeek == 4)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Четверг");

                    }
                    break;
                case 5:
                    if (dayOfWeek == 5)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Пятница");

                    }
                    break;
                case 6:
                    if (dayOfWeek == 6)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Суббота");

                    }
                    break;
                case 7:
                    if (dayOfWeek == 7)
                    {
                        Console.WriteLine($"Выбранное вами число {dayOfWeek} - и это Воскресенье");

                    }
                    break;


                default:
                    Console.WriteLine("Такого дня недели не существует придурок");
                    break;
            }
        }
    }
}