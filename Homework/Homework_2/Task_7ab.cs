/*
 * Самойлов Оскар
 * 7.
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 * */

using Homework.Utils;
using System;

namespace Homework_2
{
    internal class Task_7ab
    {
        public static void Main(string[] args)
        {
            Console.Title = "Recursive method";
            OutputHelpers.PrintInfo(2, 7);
            int a = 1; //начало
            int b = 10; //конец

            Console.WriteLine("Числа входящие в промежуток с \"a\" до \"b\"");
            PrintNumberAB(a, b);
            
            Console.WriteLine($"\nСумма всех чисел в диапазоне с {a} до {b} = " + SumNumber(a, b, 0));//изначально переменная value равна 0  
            Console.ReadKey();
        }
        /// <summary>
        /// Рекурсивный метод, для вывода на экран чисел в заданном диапазоне
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void PrintNumberAB(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine("\t{0}", a);
                a++;
                PrintNumberAB(a, b);
            }
            else
            {
                return;  
            }
        }
        /// <summary>
        ///  Рекурсивный метод для подсчёта суммы диапазона заданных чисел.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static decimal SumNumber(int a, int b, decimal value)
        {
            if (a == b) 
                return value;
            else
            {
                value += a;
                a++;
                return SumNumber(a, b, value); //переменная value возвращает сумму чисел.
            }
        }
    }
}
