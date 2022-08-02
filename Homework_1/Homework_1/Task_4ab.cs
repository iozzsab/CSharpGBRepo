//Самойлов Оскар
//4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//а) с использованием третьей переменной;
//б) *без использования третьей переменной
using Homework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Task_4ab
    {
        static void Main(string[] args)
        {
            Console.Title = "Int to Int";
            OutputHelpers.PrintName(1, 4);

            Console.WriteLine("\nПрогрмамма обмена значениями двух переменных типа Int");

            Console.Write("\nВведите значение первой переменной 'a': ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("\nВведите значение второй переменной 'b': ");
            var b = int.Parse(Console.ReadLine());

            //с использованием 3й переменной "c"
            var c = a; a = b; b = c; 
            Console.WriteLine($"\nРезультат с использованием третьей переменной. \nЗначение переменной 'a' = {a} \nЗначение переменной 'b' = {b}");

            
            //без использования 3й переменной *
            a = a + b;  
            b = a - b;  
            a = a - b;
            Console.WriteLine($"\nРезультат без использованиея третьей переменной. \nЗначение переменной 'a' = {a} \nЗначение переменной 'b' = {b}");

            Console.ReadLine();






        }
    }
}
