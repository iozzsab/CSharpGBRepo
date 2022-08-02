using Homework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework.Utils
{
    public class OutputHelpers
    {
        public static void PrintName(int homeWorkNumber, int task)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) / 2, Console.WindowHeight / 5 - 1);

            Console.WriteLine($"Домашняя работа. Урок {homeWorkNumber}, Задача {task}");
            Console.WriteLine($"Студент: Самойлов Оскар");
            Console.WriteLine("------------------------");

        }

    }
}
