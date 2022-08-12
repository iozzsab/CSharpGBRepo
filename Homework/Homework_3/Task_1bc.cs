/* 
 * Самойлов Оскар
 * 1.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 * */

using Homework.Utils;
using System;

namespace Homework_3
{
    internal class Task_1bc
    {
        static void Main(string[] args)
        {
            Console.Title = "Complex Class";
            OutputHelpers.PrintInfo(3, 1);
            Console.WriteLine("Математические операции с комплексными числами (Class)");
            
            Menu();
            Console.ReadLine();
        }
        /// <summary>
        /// Пауза консоли и возврат в меню
        /// </summary>
        static void Pause() 
        {
            Console.WriteLine("\n Нажмите любую клавишу, чтобы вернутся в меню");
            Console.ReadKey();
        }
        /// <summary>
        /// Получение значений комплекстных чисел через консоль.
        /// Вывод меню с вариантами математических операций.
        /// </summary>
        static void Menu()
        {
            ComplexClass complex1 = new ComplexClass();
            Console.Write("Введите действительную часть первого комплексного числа: ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            complex1.im = double.Parse(Console.ReadLine());

            ComplexClass complex2 = new ComplexClass();
            Console.Write("Введите действительную часть второго комплексного числа: ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго комплексного числа: ");
            complex2.im = double.Parse(Console.ReadLine());
            
            bool menu = true;
            while (menu)
            {
                Console.WriteLine($"\nРабота с комплексными числами {complex1} и {complex2}");
                Console.WriteLine("Выберите порядковый номер действия, которое необходимо выполнить.");
                Console.WriteLine("1-> Сложение комплексных чисел");
                Console.WriteLine("===============================");
                Console.WriteLine("2-> Вычетание комплексных чисел");
                Console.WriteLine("===============================");
                Console.WriteLine("3-> Умножение комплексных чисел");
                Console.WriteLine("===============================");
                Console.WriteLine("0-> Завершение работы приложения");
                Console.WriteLine("===============================");
                Console.Write("Введите номер: ");
                int menuNumber = int.Parse(Console.ReadLine());
                switch (menuNumber)
                {
                    default: //ошибка ввода номера задачи
                        Console.WriteLine("\n Некорректный номер задачи.\n Повторите попытку ввода.");
                        Pause();
                        break;

                    case 0: //завершение работы
                        Console.WriteLine("Завершение работы приложения ...");
                        menu = false;
                        break;

                    case 1: //Сложение комплексных чисел
                        ComplexClass complexResultPlus = complex1.Plus(complex2);
                        Console.WriteLine($"\nРезультат сложения комплексных чисел: {complexResultPlus}");
                        Pause();
                        break;

                    case 2: //Вычитание комплексных чисел.
                        ComplexClass complexResultMinus = complex1.Minus(complex2);
                        Console.WriteLine($"Результат вычитания комплексных чисел: {complexResultMinus}");
                        Pause();
                        break;

                    case 3: //Умножение комплексных чисел.
                        ComplexClass complexResultMultiply = complex1.Multiply(complex2);
                        Console.WriteLine($"Результат вычитания комплексных чисел: {complexResultMultiply}");
                        Pause();
                        break;
                }
            }
        }
        public class ComplexClass
        {
            /// <summary>
            /// Мнимая часть комплексногоч исла
            /// </summary>
            public double im;

            /// <summary>
            /// Действительная часть комплексногоч исла
            /// </summary>
            public double re;

            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Plus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }
            /// <summary>
            /// Вычитание комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Minus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }
            /// <summary>
            /// Умножение  комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Multiply(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.re = (re * x.re) - (im * x.im);
                y.im = (re * x.im) + (im * x.re);
                return y;
            }
            /// <summary>
            /// Вывод результата с учетом математических символов.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{re} {(im >= 0 ? "+" : "-")} {Math.Abs(im)}i";
            }
        }
    }
}
