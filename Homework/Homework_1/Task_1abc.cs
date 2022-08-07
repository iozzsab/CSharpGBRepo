/* 
 * Самойлов Оскар
 * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
 * а) используя склеивание;
 * б) используя форматированный вывод;
 * в) используя вывод со знаком $.
 * */

using Homework.Utils;
using System;

namespace Homework_1
{
    internal class Task_1abc
    {
        static void Main(string[] args)
        {
            OutputHelpers.PrintInfo(1, 1);

            Console.Title = "Анкета";
            Console.WriteLine("Простое анкетирование, пожалуйста ответьте на ряд следующих вопросов.");
            Console.WriteLine("__________________________________");

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string secondname = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            string age = Console.ReadLine();

            Console.Write("Ваш рост: ");
            string height = Console.ReadLine();

            Console.Write("Ваш вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Спасибо за ваши ответы.");
            Console.Clear();

            //Вывод данных методом склеивания
            Console.WriteLine("\nВот ваши данные. Вывод используя метод склеивания.");
            Console.WriteLine("Имя: " + name + "\nФамилия: " + secondname + "\nВозраст: " + age + "\nРост: " + height + "\nВес: " + weight);
            Console.WriteLine("Нажмите Enter, чтобы повторить вывод данных");
            Console.ReadLine();

            //Форматированный вывод данных
            Console.WriteLine("\nВот ваши данные. Вывод используя форматировачный метод.");
            Console.WriteLine("Имя: {0}; \nФамилия: {1}; \nВозраст: {2}; \nРост: {3}; \nВес {4}:", name, secondname, age, height, weight);
            Console.WriteLine("Нажмите Enter, чтобы повторить вывод данных");
            Console.ReadLine();

            //Вывод с использование $
            Console.WriteLine("\nВот ваши данные. Вывод используя $ символ.");
            Console.WriteLine($"Имя: {name}; \nФамилия: {secondname}; \nВозраст: {age}; \nРост: {height}; \nВес {weight}:"); ;
            Console.WriteLine("Нажмите Enter, чтобы закрыть");
            Console.ReadLine();
        }
    }


}

