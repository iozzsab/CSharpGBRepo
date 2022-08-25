/*
 * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).
 * */

using Homework.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Homework_6
{
    /// <summary>
    /// Делегат функции с сигнатурой double
    /// </summary>
    /// <param name="x">Параметр "х"</param>
    /// <returns></returns>
    public delegate double MyFun(double x);
    class Task_2
    {
        public static void Main(string[] args)
        {
            Console.Title = "FindMinimum";
            OutputHelpers.PrintInfo(6, 2);

            Console.WriteLine("Программа для работы с функциями");

            List<MyFun> functions = new List<MyFun> {new MyFun(Squaring), new MyFun(ThirdDegree), new MyFun(SquareRoot), new MyFun(Sin), new MyFun(Cos), new MyFun(Cosh)};

            ListFunc(); //Принт списка доступных функций
            Console.Write("Введите номер: ");
            int selectNumber = GetInt(functions.Count);

            Console.WriteLine("Поиск минимума на отрезке");
            Console.Write("Укажите начало и конец отрезка в формате 'a/b': ");
            double a = 0;
            double b = 0;
            Interval(out a, out b);
            Console.Write("Задайте величину шага: ");
            double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SaveFunc("data.bin", a, b, h, functions[selectNumber -1]);
            double min = double.MaxValue;

            Console.WriteLine("Результат работы функции: ");
            PrintTable(a, b, h, Load("data.bin", out min));
            Console.WriteLine("Минимальное значение функции: {0:0.00}", min );
            
            Console.ReadKey();
        }
        #region Методы
        /// <summary>
        /// Метод для расчёта и записи значений переданной функции.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="a">Начальное значение аргумента</param>
        /// <param name="b">Конечное значение аргумента</param>
        /// <param name="h">Шаг</param>
        /// <param name="F">Делегат функции</param>
        public static void SaveFunc(string fileName, double a, double b, double h, MyFun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            
            while (a <= b)
            {
                bw.Write(F(a));
                a += h;
            }
            bw.Close();
            fs.Close();
        }
        /// <summary>
        /// Метод для вывода таблици со значениями функции и аргументов
        /// </summary>
        /// <param name="a">Начальное значение</param>
        /// <param name="b">Конечное значение</param>
        /// <param name="h">Шаг</param>
        /// <param name="values">Массив значений</param>
        static void PrintTable(double a, double b, double h, double[] values)
        {
            Console.WriteLine("------- A -------- B -------- I --------");
            int index = 0;
            while (a <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", a, b, values[index]);
                a += h;
                index++;
            }
            Console.WriteLine("------------------------------------");
        }
        /// <summary>
        /// Метод получения значения интервала от a до b
        /// </summary>
        /// <param name="a">Начало отрезка</param>
        /// <param name="b">Конец отрезка</param>
        static void Interval (out double a, out double b)
        {
            string[] interval = Console.ReadLine().Split('/');
            a = double.Parse(interval[0], CultureInfo.InvariantCulture);
            b = double.Parse(interval[1], CultureInfo.InvariantCulture);
        } 
        /// <summary>
        /// Метод проверки значения ввода
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static int GetInt (int maxValue)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > maxValue)
                    Console.Write($"Ошибка ввода (введите значение от 0 до {maxValue}).\nВвод: ");
                else
                    return x;
        }
        public static void ListFunc()
        {
            Console.WriteLine("Выберите функцию для дальнейшей работы.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) f(x)=y^2");
            Console.WriteLine("2) f(x)=y^3");
            Console.WriteLine("3) f(x)=y^1/2");
            Console.WriteLine("4) f(x)=Sin(y)");
            Console.WriteLine("5) f(x)=Cos(y)");
            Console.WriteLine("6) f(x)=Cosh(y)");
            Console.ResetColor();
        }
        #endregion
        #region Функции
        /// <summary>
        /// Функция возвращает массив значений и находит минимальное
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="min">Минимум с 'out'</param>
        /// <returns></returns>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }           
        /// <summary>
        /// Функция возведения в квадрат f(x)=y^2
        /// </summary>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        static double Squaring(double x)
        {
        return x * x;
        }
        /// <summary>
        /// Функция возведения в третью степень f(x)=y^3
        /// </summary>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        static double ThirdDegree(double x)
        {
            return x * x * x;
         
        }
        /// <summary>
        /// Функция извлечения квадратного корня f(x)=y^1/2
        /// </summary>
        /// <param name="x">Параметр "х"</param>
        /// <returns></returns>
        static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
        /// <summary>
        /// Функция возврата синуса f(x)=Sin(y)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Sin(double x)
        {
            return Math.Sin(x);
        }
        /// <summary>
        /// Функиця возврата косинуса f(x)=Cos(y)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Cos(double x)
        {
            return Math.Cos(x);
        }
        /// <summary>
        /// Функция возврата гипербалического косинуса f(x)=Cosh(y)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Cosh(double x)
        {
            return Math.Cosh(x);
        }
        #endregion
    }
}

