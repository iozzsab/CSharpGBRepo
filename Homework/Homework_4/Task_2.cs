/*
 * Самойлов Оскар
 * 2. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
 * Создайте структуру Account, содержащую Login и Password.
 * */

using Homework.Utils;
using System;
using System.IO;

namespace Homework_4
{
    internal class Task_2
    {
        public static void Main(string[] args)
        {
            Console.Title = "LoginPassword";
            OutputHelpers.PrintInfo(4, 2);

            Console.WriteLine("Авторизация в программе из файла");

            int attemptsnumber = 3;

            string[] fileNameTXT =
            {
                "LogPassFalse_0.txt",
                "LogPassFalse_1.txt",
                "LogPassTrue.txt"
            };

            Account account;
            account.Login = "";
            account.Password = "";

            int i = 0;

            do
            {
                Console.WriteLine("\nLoad file: " + fileNameTXT[i]);
                account.loadFromFile(fileNameTXT[i]);

                Console.WriteLine("\nПопытка авторизации..... ");

                if (CheckLoginAndPassword(account))
                {
                    break;  
                }
                else
                {
                    attemptsnumber--;
                    Console.WriteLine("Неверный ввод логина или пароля.");
                    Console.WriteLine($"Количесвто оставшихся попыток: {attemptsnumber}");
                }
                i++;
            }
            while (attemptsnumber > 0);
            Console.WriteLine("Вы авторизованы!");
            Console.ReadKey();
        }
        /// <summary>
        /// Структура содержащая Login и Password.
        /// </summary>
        struct Account
        {
            public string Login;
            public string Password;

            public void loadFromFile(string  fileNameTXT)
            {
                fileNameTXT = "..\\..\\" + fileNameTXT;
                StreamReader strmrd = new StreamReader(fileNameTXT);

                Login = strmrd.ReadLine();

                Password = strmrd.ReadLine();

                strmrd.Close();
            }
        }
        /// <summary>
        /// Проверка корректности log and pass
        /// </summary>
        /// <param name="check">структура проверки</param>
        /// <returns></returns>
        static bool CheckLoginAndPassword(Account check)
        {
            if (check.Login == "root" && check.Password == "GeekBrains")
                return true;
            else
                return false;
        }

    }
}
