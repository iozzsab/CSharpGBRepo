/* 
 * Самойлов Оскар
 * 1. С помощью рефлексии выведите все свойства структуры DateTime.
 * 
 * (для запуска рекомендуется сменить Тип входных даннннных в свойствах проекта)
 */

using Homework.Utils;
using System;
//using System.Reflection;

namespace Homework_8
{
    internal class Task_1
    {
        /*static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }*/
        static void Main(string[] args)
        {
            Console.Title = "DateTime";
            OutputHelpers.PrintInfo(8, 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Прграмма для вывода всех свойств DataTime: ");
            Console.ResetColor();

            DateTime dateTimeNow = DateTime.Now; //присваиваем текущее время
            int num = 1; //нумеруем свойства по порядку
            Type type = typeof(DateTime); //используем typeof оператор  
            
            foreach (var propetryInfo in type.GetProperties()) //массив со свойствами ДатаТайм 
            {
                Console.WriteLine($"{num}. " + propetryInfo.Name + ": " + propetryInfo.GetValue(dateTimeNow));
                num++;
            }
            Console.ReadLine();
        }
    }
}
