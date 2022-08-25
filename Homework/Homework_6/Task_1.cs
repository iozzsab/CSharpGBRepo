/* 
 * Самойлов Оскар
 * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x). 
 * */

using Homework.Utils;
using System;

namespace Homework_6
{
    /// <summary>
    /// Делегат double
    /// </summary>
    /// <param name="a">Параметр "а"</param>
    /// <param name="x">параметр "х"</param>
    /// <returns></returns>
    public delegate double Fun(double a, double x);
    class Task_1
    {
        static public void Main(string[] args)
        {
            Console.Title = "Function's";
            OutputHelpers.PrintInfo(6, 1);
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a*x^2:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table((MyFunc), 3, -2, 2);

            
            Console.WriteLine("Таблица функции a*sin(x):"); 
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 5, -2, 2);

            //Console.WriteLine("Таблица функции a*sin(x):");
            //Table(new Fun(SinHW), 5, -2, 2);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод принимающий делигат
        /// </summary>
        /// <param name="F">Метод с сигнатурой double, double, double</param>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <param name="b">Количество строк</param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("------- A -------- X -------- F --------");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", a, x,  F(a, x));
                x += 1;
            }
            Console.WriteLine("------------------------------------");
        }

        /// <summary>
        /// Метод возвращает значение функции a*x^2
        /// </summary>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        public static double MyFunc(double a, double x)
        {
            return a * (x * x);
        }

        /*/// <summary>
        /// Таблица функции a*sin(x)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double SinHW(double a, double x)
        {
            return a * Math.Sin(x);
        }
        */
    }
}
