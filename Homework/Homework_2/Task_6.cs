/*
 * Самойлов Оскар
 * 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 * */   

using Homework.Utils;
using System;

namespace Homework_2
{

    internal class Task_6
    { 
        public static void Main(string[] argns)
        {
            Console.Title = "Positive numbers";
            OutputHelpers.PrintInfo(2, 6);

            Console.WriteLine("Подсчёт количества и суммы \"хороших\" чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine("\nПодсчёт может занять некоторое время...");

            DateTime start = DateTime.Now; //запись текущеного времени

            PositiveNumber();

            DateTime finish = DateTime.Now; //запись текущего времени в конце выполнения работы

            Console.WriteLine($"Подсчет занял у нас {finish - start}");
            Console.ReadKey();
        }
        /// <summary>
        ///  Числа Нивена в диапазоне от 1 до 1 000 000 000
        /// </summary>
        public static void PositiveNumber()
        {
            int minNum = 1;
            int maxNum = 1_000_000_000;
            int posNum = 0;
            int sumNum = 0;
            bool flag = false;

            for (int number = minNum; number <= maxNum; number++)
            {
                flag = CheckPositoveNumber(number);
                if (flag)
                {
                    posNum++;
                    sumNum += posNum;
                }
            }
            Console.WriteLine($"\nКоличество \"хороших\" чисел в диапазоне от {minNum} до {maxNum} равно {posNum}, сумма: {sumNum}");
        }
        /// <summary>
        /// Проверка на "хорошие" числа.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool CheckPositoveNumber (int number)
        {
            int value = number;
            int sumNumber = 0;
            while (value > 0)
            {
                sumNumber += value % 10;
                value /= 10;
            }
            return number % sumNumber == 0;
        }
    }

}
