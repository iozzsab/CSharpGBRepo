/*
 * Самойлов Оскар
 * 1. Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, 
 * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.
 * */

using Homework.Utils;
using System;
using System.Collections.Generic;

namespace Homework_5
{
    internal class Task_1
    {
        public static void Main(string[] args)
        {
            Console.Title = "Authorization";
            OutputHelpers.PrintInfo(5, 1);
            
            Console.WriteLine("Авторизация");
            Console.WriteLine("Введите логин соответствующий требованиям: \nСтрока от 2 до 10 символов; латинские буквы, цифра не может быть первой");
            LoginCorrectCheck();
            Console.ReadLine();
            
        }
        /// <summary>
        /// Метод проверки логина на корректность
        /// </summary>
        public static void LoginCorrectCheck()
        {   
            Console.Write("\nВведите логин: ");
            string login = Console.ReadLine();

            int length = login.Length;
            char log = login[0]; 
            bool loginRight = true;

            for (int i = 1; i < length; i++)
            {
                log = login[i];
                
                if (login.Length >= 2 && login.Length <= 10 && char.IsNumber(login[0]) == false && LoginLatinCheck(log))
                {
                    loginRight = true;
                }
                else
                {
                    loginRight = false;
                }
            }
            if (loginRight)
            {
                Console.WriteLine("Данный логин - {0}, соответствует требованиям.", login);
                LoginCorrectCheck();
            }
            else
            {
                Console.WriteLine("Логин не соответствует требованиям.");
                LoginCorrectCheck();
            }
        }
        /// <summary>
        /// Метод для проверки ввода латиницей 
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private static bool LoginLatinCheck(char log)
        {
            int num = log;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
    }
}
