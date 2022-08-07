using System;
using System.Text.RegularExpressions;

namespace Homework.Utils
{
    public class OutputHelpers
    {
        /// <summary>
        /// Вывод информации о студенте и образовательном портале.
        /// </summary>
        /// <param name="homeWorkNumber"> Номер домашней работы</param>
        /// <param name="task">Номер задачи текущей домашней работы</param>
        public static void PrintInfo(int homeWorkNumber, int task)
        {
            ////Вывод в консоль информацию об образовательном портале.
            Console.ForegroundColor = ConsoleColor.Magenta;
            string textGB = ($"-------------------------------\nGeekBrains - образовательный портал\n-------------------------------");
            string[] linesGB = Regex.Split(textGB, "\n");
            
            int left = 0;            
            int top = (Console.WindowHeight / 2) - (linesGB.Length / 2) - 10;            
            int center = Console.WindowWidth / 2;
            
            top = Console.CursorTop;

            #region for Для поциционирования textGB
            for (int i = 0; i < linesGB.Length; i++)
            {
                left = center - (linesGB[i].Length / 2);
                Console.SetCursorPosition(left, top);

                Console.WriteLine(linesGB[i]);
                top = Console.CursorTop;
            }
            #endregion

            //Вывод в консоль информацию с номером урока и номером задачи + ФИ.
            Console.ForegroundColor = ConsoleColor.Cyan;
            string text = ($"Домашняя работа. Урок {homeWorkNumber}, Задача {task}\nСтудент: Самойлов Оскар\nПреподаватель: Станислав Байраковский\n-------------------------------\n\n");
            string[] lines = Regex.Split(text,"\n");

            #region for Для поциционирования text
            for (int i = 0; i < lines.Length; i++)
            {
                left = center - (lines[i].Length / 2);
                Console.SetCursorPosition(left, top);

                Console.WriteLine(lines[i]);
                top = Console.CursorTop;
            }
            #endregion

            Console.ResetColor();
        }
    }
}
