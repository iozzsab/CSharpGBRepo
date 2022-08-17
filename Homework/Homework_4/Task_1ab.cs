/*
 * Самойлов Оскар
 * 1. а) Дописать класс для работы с одномерным массивом. 
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива, 
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
 * метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 */

using ArrayClassLib;
using Homework.Utils;
using System;

namespace Homework_4
{   
    internal class Task_1ab
    {
        public static void Main(string[] args)
        {
            Console.Title = "One-Dimensional Arrays";
            OutputHelpers.PrintInfo(4, 1);

            Console.WriteLine("Демонстрация работы библиотеки классов с массивом");

            Console.Write("Введите размер масива: ");
            int arraySize = InputCorrect();

            Console.Write("Введите начало масива: ");
            int initialValue = InputCorrect();

            Console.Write("Введите желаемый шаг для массива: ");
            int stepValue = InputCorrect();
           
            ArrayClass useArray = new ArrayClass(arraySize, initialValue, stepValue);

            Console.WriteLine("\nСоздан массив: ");
            Console.WriteLine(string.Join(" ", useArray.ToString()));
            
            Console.WriteLine("\nСумма элементов массива: ");
            Console.WriteLine(useArray.Sum);

            useArray.Inverse = -1;
            Console.WriteLine("\nНовый массив с измененым знаком: ");
            Console.WriteLine(string.Join(" ", useArray.ToString()));
            useArray.Inverse = +1;

            Console.WriteLine("\nМетод умножающий каждый элемент массива на определённое число");
            Console.Write("Введите число: ");
            useArray.Multi = InputCorrect();
            Console.WriteLine("Результат умножения: ");
            Console.WriteLine(string.Join(" ", useArray.ToString()));


            Console.WriteLine("\nМаксимальный элемент массива: ");
            Console.WriteLine(useArray.MaxElement);

            Console.WriteLine("\nКоличество максимальных элементов массива: ");
            Console.WriteLine(useArray.MaxCount);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Проверка на корректность ввода чисел.
        /// </summary>
        /// <returns></returns>
        static int InputCorrect()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Ошибка ввода. \nПожалуйста, повторите попытку: ");
                else return x;
        }
        
    }                                   
}
