/*
 * Самойлов Оскар
 * 3.
 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 * */

using Homework.Utils;
using System;

namespace Homework_1
{
    internal class Task_3ab
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintInfo(1, 3);

            Console.Title = "X1 Y1 X2 Y2";
            Console.WriteLine("\nРасчёт растояния между точками x1, y1 и x2, y2");

            Raycast();
            Console.ReadLine();
        }
        static void Raycast() //оформление вычисления расстояния между точками в виде метода
        {
            Console.Write("Введите значение x1: ");
            string x1String = Console.ReadLine();
            double x1 = Convert.ToDouble(x1String);

            Console.Write("Введите значение x2: ");
            string x2String = Console.ReadLine();
            double x2 = Convert.ToDouble(x2String);

            Console.Write("Введите значение y1: ");
            string y1String = Console.ReadLine();
            double y1 = Convert.ToDouble(y1String);

            Console.Write("Введите значение y2: ");
            string y2String = Console.ReadLine();
            double y2 = Convert.ToDouble(y2String);

            double ray = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{ray:F2}");
        }         
    }
}
