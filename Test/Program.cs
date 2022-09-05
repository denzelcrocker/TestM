using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Test
{
    class Number1
    {
        /*Написать программу, которая запрашивает ввод с клавиатуры двух
положительных вещественных чисел и вычисляет логарифм первого числа по
основанию второго*/
        public static void Premier()
        { 
            bool a = true;
            double one = 0;
            double two = 0;
            double answer = 0;
            while (a == true)
            {
                try
                {
                    WriteLine("Введите первое вещественное положительное число");
                    one = Convert.ToDouble(ReadLine());
                    WriteLine("Введите второе вещественное положительное число");
                    two = Convert.ToDouble(ReadLine());
                    a = false;
                    if (one < 0 || two < 0)
                    {
                        a = true;
                    }
                }
                catch (Exception)
                {
                    WriteLine("Введен неверный тип числа \n");
                }
            }
            answer = Math.Log(one, two);
            WriteLine($"Логарифм числа {one} по основанию {two} равен " + answer);
            ReadKey();
        }
    }
    class Number2
    {
        /*Написать программу, которая вычисляет периметр и площадь
прямоугольника по введенным пользователем координатам его диагонали.*/
        public static void Premier()
        { 
        
        }
    }
    class Number3
    {
        /*Напишите программу, которая проверяет, дает ли введенное с клавиатуры
число одинаковый остаток при делении на 3 и на 4.*/
        public static void Premier()
        {
            double one = 0;
            bool a = true;
            while (a == true)
            {
                try
                {
                    WriteLine("Введите число: ");
                    one = Convert.ToDouble(ReadLine());
                    a = false;
                    if (one % 3 == one % 4)
                    {
                        WriteLine($"Осток от деления на 3 и на 4 от введенного числа равен ({one % 3}) \n");
                    }
                    else
                    {
                        WriteLine("Остатки не совпадают");
                    }
                }
                catch (Exception)
                {
                    WriteLine("Введен неверный тип числа \n");
                }
            }
        }
    }
    class Number4
    {
        /*Напишите программу, которая печатает в столбик все цифры введенного nзначного (n от 1 до 10) числа в порядке убывания разрядов.*/
        public static void Premier()
        {
            uint one = 0;
            string stringed;
            bool a = true;
            while (a == true)
            {
                try
                {
                    WriteLine("Введите число: ");
                    one = Convert.ToUInt32(ReadLine());
                    a = false;
                    stringed = Convert.ToString(one);
                    for (int i = stringed.Length - 1; i >= 0; i--)
                    {
                        WriteLine(stringed[i]);
                    }
                }
                catch (Exception)
                {
                    WriteLine("Введен неверный тип числа \n");
                }
            }
        }
    }
    class Number5
    {
        /* Посчитайте значение следующего выражения при условии, что
пользователь вводит с клавиатуры значения х*/
        public static void Premier()
        {
            double x = 0;
            bool a = true;
            while (a == true)
            {
                try
                {
                    WriteLine("Введите число: ");
                    x = Convert.ToDouble(ReadLine());
                    a = false;
                    WriteLine($"Значение выражения равно: {Log(Cos(x)) / Log(1 + x * x)} \n");
                }
                catch (Exception)
                {
                    WriteLine("Введен неверный тип числа \n");
                }
            }
        }
    }
    class Number6
    {
        /*. Выведите на экран последовательность n первых чисел Фибоначчи (с
указанием их индекса), имеющих нечетные индексы. Количество чисел n
пользователь вводит с клавиатуры.*/
        public static void Premier()
        {

        }
    }
    class Number7
    {
        /*. Выведите на экран последовательность n первых чисел Фибоначчи (с
указанием их индекса), имеющих нечетные индексы. Количество чисел n
пользователь вводит с клавиатуры.*/
        public static void Premier()
        {

        }
    }
    class Number8

    {
        /*. Выведите на экран последовательность n первых чисел Фибоначчи (с
указанием их индекса), имеющих нечетные индексы. Количество чисел n
пользователь вводит с клавиатуры.*/
        public static void Premier()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Выберите номер задания(от 1 до 8)");
            int h = Convert.ToInt32(ReadLine());

            switch (h)
            {
                case 1:
                    Number1.Premier();
                    break;
                case 2:
                    Number2.Premier();
                    break;
                case 3:
                    Number3.Premier();
                    break;
                case 4:
                    Number4.Premier();
                    break;
                case 5:
                    Number5.Premier();
                    break;
                case 6:
                    Number6.Premier();
                    break;
                case 7:
                    Number7.Premier();
                    break;
                case 8:
                    Number8.Premier();
                    break;
            }
            ReadKey();
        }
    }
}
