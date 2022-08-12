/* 
 * Самойлов Оскар
 * 1.
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * */

using Homework.Utils;
using System;

namespace Homework_3
{
    internal class Task_1a
    {
        static void Main(string[] args)
        {
            Console.Title = "Complex Struct";
            OutputHelpers.PrintInfo(3, 1);
            Console.WriteLine("Математические операции с комплексными числами (Struct)");

            Complex complex1 = new Complex();
            Console.Write("Введите действительную часть первого комплексного числа: ");
            complex1.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            complex1.im = double.Parse(Console.ReadLine());

            Complex complex2 = new Complex();
            Console.Write("Введите действительную часть второго комплексного числа: ");
            complex2.re = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть второго комплексного числа: ");
            complex2.im = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nРабота с комплексными числами {complex1} и {complex2}");
            
            Complex complexResultPlus = complex1.Plus(complex2);
            Console.WriteLine($"\nРезультат сложения комплексных чисел: {complexResultPlus}");

            Complex complexResultMinus = complex1.Minus(complex2);
            Console.WriteLine($"Результат вычитания комплексных чисел: {complexResultMinus}");
            
            Console.ReadLine();
        }
        /// <summary>
        /// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        /// </summary>
        public struct Complex
        {
            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            public double im;
            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Plus(Complex x)
            {
                Complex y = new Complex();
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }
            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Minus(Complex x)
            {
                Complex y = new Complex();
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }
            
            public override string ToString()
            {
                return $"{re} {(im >= 0 ? "+" : "-")} {Math.Abs(im)}i";
            }     
        }
    }
}


        

