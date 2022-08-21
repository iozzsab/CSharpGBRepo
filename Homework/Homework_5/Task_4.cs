/*
 * Самойлов Оскар
 * 4. *Задача ЕГЭ.
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
 * 
 * <Фамилия> <Имя> <оценки>,
 * где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
 * Иванов Петр 4 5 
 * Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 * */

using Homework.Utils;
using System;
using System.IO;
using System.Text;

namespace Homework_5
{
    internal class Task_4
    {
        public static void Main(string[] args)
        {
            Console.Title = "Best Worst";
            OutputHelpers.PrintInfo(5, 4);
            Console.WriteLine("Программа для анализа успеваемости учеников");
            FindWorstStudents(AppDomain.CurrentDomain.BaseDirectory + "data_4.txt");
            Console.ReadLine();
        }
        /// <summary>
        /// Метод для выявления лучших и худших учеников по среднему баллу
        /// </summary>
        /// <param name="data_4">Список учеников</param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="FormatException"></exception>
        static void FindWorstStudents (string data_4)
        {
            using (var dataReader = new StreamReader("..\\..\\data_4.txt", encoding: System.Text.Encoding.GetEncoding(65001)))
            {
                if (!int.TryParse(dataReader.ReadLine(), out int counter) || !(counter >= 10 && counter <= 100))
                    throw new Exception("Первая строка должна содержать цифровое значения о количестве учеников");

                StringBuilder[] chart = new StringBuilder[29]; 
                for (int i = 0; i < counter; i++)
                {
                    var parts = dataReader.ReadLine()?.Split(new[] { ' ' });
                    if (parts == null) continue;
                    var name = $"{parts[0]} {parts[1]}";
                    if (!int.TryParse(parts[2], out int a) || !int.TryParse(parts[3], out int b) || !int.TryParse(parts[4], out int c))
                        throw new FormatException("Arg_FormatException/Возникло исключение");
                    int index = a + b + c - 1;
                    if (chart[index] == null)
                        chart[index] = new StringBuilder($"\n\t{name}");
                    else
                        chart[index].Append($"\n\t{name}");
                }

                Console.WriteLine("\nФамилии и имена худших по среднему баллу учеников: ");
                int counterSt = 0;
                for (int i = 6; i < chart.Length; i++) //начинаем с 6, для уменьшения количества итераций
                {
                    if (counterSt > 2)
                        break;
                    if (chart[i] == null) continue;
                    Console.WriteLine($"\n{++counterSt} место - средний балл: {(float)(i + 1) / 3:F2}");
                    Console.WriteLine(chart[i]);
                }

                Console.WriteLine("\nФамилии и имена лучших по среднему баллу учеников: ");
                int counterStBetter = 0;
                for (int i = 15; i < chart.Length; i--)
                {
                    if (counterStBetter > 2)
                        break;
                    if (chart[i] == null) continue;
                    Console.WriteLine($"\n{++counterStBetter} место - средний балл: {(float)(i + 1) / 3:F2}");
                    Console.WriteLine(chart[i]);
                }
            }
        }
    }
}
