using System;

namespace Типы_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основные типы int | float | char | string | bool |
            // Целочисленные типы
            byte b; // 0 255
            sbyte sb; // - 128 127
            short s; // -23768 32767
            ushort us; // 0 65535
            int i; // -2147483648 2147483647
            uint ui; // 0 4294672295
            long l;
            ulong ul;
            // Числа с плавающей точкой
            float f = 5.7f; // точность значения до 7 знаков после запятой
            double d = 5.7; // 15 знаков после запятой 
            // символьный тип
            char c = 'a';
            // строковый тип 
            string str = "string";
            // Логический тип
            bool bl;

            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Ваше имя {name}");
        }
    }
}
