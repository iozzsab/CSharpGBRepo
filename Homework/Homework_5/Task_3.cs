/*
 * Самойлов Оскар
 * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * Например: badc являются перестановкой abcd.
 * */

using Homework.Utils;
using System;

namespace Homework_5
{
    internal class Task_3
    {
        public static void Main(string[] args)
        {
            Console.Title = "ABC = CBA ?";
            OutputHelpers.PrintInfo(5, 3);

            Console.WriteLine("Является ли одна строка перестановкой другой строки ");

            Console.Write("Введите текст певрой строки: ");
            string a = Console.ReadLine();
            Console.Write("Введите второй строки: ");
            string b = Console.ReadLine();

            #region Результат с использованием сортировки  
            Console.WriteLine("\n\nРезультат работы с использованием первого метода");
            if (IsPermutationSort(a, b))
                Console.WriteLine("Первая строка является перестановкой второй строки");
            else
                Console.WriteLine("Первая строка не является перестановкой второй строки");
            #endregion

            #region Результат с использованием счётчика символов 
            Console.WriteLine("\n\nРезультат работы с использованием второго метода");
            if (IsPermutationCounterSymbol(a, b) )
                Console.WriteLine("Первая строка является перестановкой второй строки");
            else
                Console.WriteLine("Первая строка не является перестановкой второй строки");
            #endregion

            Console.ReadLine();
        }
        /// <summary>
        /// Метод определяющий является ли одна строка перестановкой другой строки.
        /// с использованием .Sort
        /// </summary>
        /// <param name="a">Первая строка</param>
        /// <param name="b">Вторая строка</param>
        /// <returns></returns>
        public static bool IsPermutationSort(string a, string b)
        {
            char[] arrayA = a.ToCharArray();
            Array.Sort(arrayA);
            char[] arrayB = b.ToCharArray();
            Array.Sort(arrayB);
            return new String(arrayA) == new String(arrayB);
        }
        /// <summary>
        /// Метод определяющий является ли одна строка перестановкой другой строки.
        /// с использованием счётчика символов
        /// </summary>
        /// <param name="a">Первая строка</param>
        /// <param name="b">Вторая строка</param>
        /// <returns></returns>
        public static bool IsPermutationCounterSymbol(string a, string b)
        {
            int[] letters = new int[128];

            foreach (var symbol in a)
                letters[(int)symbol]++;
            
            foreach (var symbol in b)
            {
                if (--letters[(int)symbol] < 0) 
                    return false; 
            }
            return true;
        }
    }
}
