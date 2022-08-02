/*  Самойлов Оскар
 * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 * */
using Homework.Utils;
using System;

namespace Homework_1
{
    internal class Task_2a
    {
        static void Main(string[] args)
        {                   
            Console.Title = "ИМТ";
            OutputHelpers.PrintName(1, 2);
            

            Console.WriteLine("\nВычисление индекса массы тела");
            Console.WriteLine("_______________________________");

            Console.Write("Укажите ваш вес в килограммах: ");
            string massString = Console.ReadLine();
            double mass = Convert.ToDouble(massString);

            Console.Write("Укажите ваш рост в метрах: ");
            string heightSrting = Console.ReadLine();
            double height = Convert.ToDouble(heightSrting);

            double bmi = mass / (height * height);
            Console.WriteLine($"\nВаш индекс массы тела равен: {bmi}");

            Console.ReadLine();


            



        }
    }
}
