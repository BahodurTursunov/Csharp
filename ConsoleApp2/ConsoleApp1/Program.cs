﻿/*
 * Как определить дублированный элемент в массиве, в котором содержатся элементы типа int от 1 до 100, 
 * при условии, что в массиве дублируется только один элемент?
 */
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Используя приоритеты операций, разложите выражение int result = n2 * 3 + 20 / 2 * n1-- по шагам.
            //int n1 = 2;
            //int n2 = 5;

            //int a = n2 * 3;
            //int b = 20 / 2;
            //int c = n1--;
            //int d = b * c;
            //int e = a + d;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //int x = 8;
            //int y = 9;
            //int z = x++ + y++;
            //Console.WriteLine(z);
            /*// Переменная z будет равна 18. Вначале будут выполняться
             выражения инкрементов переменных x и y. Выражение x++ увеличит переменную
            x на единицу, но возвратит ее предыдущее значение - число 8
            Выражение ++y увеличит значение переменной y и возвратит е новое значение
            то есть число 10. В итоге мы получим 8+10 =18*/

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////Сколько раз выполнится следующий цикл и почему:
            //int i = 5;
            //while (i>0)
            //{
            //    i *= 3;
            //    i *= -1;
            //    Console.WriteLine(i);
            //}
            ///*Цикл выполнится один раз. При первой же итерации значение переменной i умножается на 3 и -1, то есть оно будет равно -15.
            // * Посколько цикл продолжается, пока значение переменной i больше 0, то после первой итерации произойдет выход из цикла.*/

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //int j = 2;
            //for (int i = 1; i < 100; i = i+2)
            //{
            //    j = j - 1;
            //    while (j < 15)
            //    {
            //        j = j + 5;
            //    }
            //}
            //Console.WriteLine(j);
            // В этом цикле строка j = j- 1; будет выполняться 50 раз. Потому что i < 100 и i = i+2. Соответственно /2
        }
    }
}
