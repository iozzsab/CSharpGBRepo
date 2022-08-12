/*
 * Самойлов Оскар
 * 2.
 * а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
 * */

using Homework.Utils;
using System;
using System.Collections.Generic;

namespace Homework_3
{
    internal class Task_2
    {
        public static void Main(string[] args)
        {
            Console.Title = "SumNumbers";
            OutputHelpers.PrintInfo(3, 2);
            SumPositiveNumber();
        }
        /// <summary>
        ///  Подсчёт суммы всех введенных нечетных положительных чисел
        /// </summary>
        public static void SumPositiveNumber()
        {
            Console.WriteLine("\nПодсчёт суммы всех введенных нечетных положительных чисел. Чтобы произвести подсчёт введите \"0\"");

            var listNumbers = new List<int>();
            int number;
            int sumNumber = 0;
            
            while(true)
            {
                Console.Write("Введите целое число: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if(number % 2 != 0 && number > 0)
                    {
                        sumNumber += number;
                        listNumbers.Add(number);
                    }
                    else if (number == 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неккоректное число, продолжайте ввод целых чисел.");
                }
            }
            Console.Write("\nВсе введеные нечетные положительные числа: ");
            foreach (int list in listNumbers)
            {
                Console.Write(list + "; ");
            }
            Console.WriteLine("\n=====================================");
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sumNumber}");
            Console.ReadLine();
        }
    }
}
