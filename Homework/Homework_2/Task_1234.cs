/* 
 * Самойлов Оскар
 * 1. Написать метод, возвращающий минимальное из трёх чисел.
 * 2. Написать метод подсчета количества цифр числа.
 * 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 * */    

using Homework.Utils;
using System;

namespace Homework_2
{
    internal class Task_1234
    {
        public static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                Console.Title = "Homework task menu";
                OutputHelpers.PrintInfo(2, 1234);
                PrintMenu();
                int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    default:
                        Defoult();
                        Return();
                        break;

                    case 0:
                        menu = false;
                        break;

                    case 1:
                        Task_1();
                        Return();
                        break;

                    case 2:
                        Task_2();
                        Return();
                        break;

                    case 3:
                        Task_3();
                        Return();
                        break;

                    case 4:
                        Task_4();
                        Return();
                        break;
                }

            }
            Console.WriteLine("Завершение работы приложения.");
            Console.ReadLine();
        }
        
        #region Нумерация задач 1 2 3 4
        static void Task_1()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выполнение задачи 1 ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nМетод возвращающий минимальное из трех чисел.");
            MinOfNum();
        }

        static void Task_2()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выполнение задачи 2 ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nМетод подсчета количества цифр числа");
            Counter();
        }

        static void Task_3()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выполнение задачи 3 ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nПодсчёт суммы всех введенных нечетных положительных чисел. Чтобы произвести подсчёт введите \"0\"");
            SumPositiveNumber();
        }

        static void Task_4()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выполнение задачи 4 ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nАвторизация.");
            LoginPassword();
        }
        #endregion

        #region Вспомогательные методы для управлния меню
        static void PrintMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Меню домашней работы.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 --> Задача 1");
            Console.WriteLine("2 --> Задача 2");
            Console.WriteLine("3 --> Задача 3");
            Console.WriteLine("4 --> Задача 4");
            Console.WriteLine("0 --> Завершение работы приложения");
            Console.WriteLine("-----------------------------------");

            Console.Write("Введите номер задачи: ");
        }
        static void Defoult()
        {
            Console.Clear();
            Console.WriteLine("Неккоректный номер задачи. \nПовторите попытку.");
        }
        static void Return()
        {
            Console.WriteLine("\nНажмите любую клавишу чтобы вернуться в меню.");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region Методы указанные в заданиях 1-4
        /// <summary>
        /// 1. Написать метод, возвращающий минимальное из трёх чисел.
        /// </summary>
        public static void MinOfNum()
        {
            double minNumber = 0;

            Console.Write("Введите первое число: ");
            double firstNumber = double.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                minNumber = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                minNumber = secondNumber;
            }
            else
            {
                minNumber = thirdNumber;
            }
            Console.WriteLine($"Вы ввели следующие числа: {firstNumber}; {secondNumber}; {thirdNumber};. Число с наименьшим значением = {minNumber}");
        }
        /// <summary>
        /// 2. Написать метод подсчета количества цифр числа.
        /// </summary>
        public static void Counter()
        {
            Console.Write("Введите своё число: ");
            decimal number = decimal.Parse(Console.ReadLine());
            int count = 0;
            decimal printNumber = number;

            while (number > 0)
            {
                count++;
                number /= 10;
            }
            Console.WriteLine($"Введенное число: {printNumber}. Количество цифр в кашем числе = {count}.");
        }
        /// <summary>
        /// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        public static void SumPositiveNumber()
        {
            int number;
            int sumNumber = 0;
            do
            {
                Console.Write("Введите любое число: ");
                number = int.Parse(Console.ReadLine());
                
                if (number % 2 != 0 && number > 0)
                {
                    sumNumber += number;
                }
            }
            while (number != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sumNumber}");
        }
        /// <summary>
        /// 4. Реализовать метод проверки логина и пароля. Логин: root, Password: GeekBrains. Всего 3 попытки.
        /// </summary>
        public static void LoginPassword()
        {
            string login, password;
            int countAttemps = 3;

            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Веддите пароль: ");
                password = Console.ReadLine();

                if (CheckLogPass(login, password) == false)
                {
                    countAttemps--;
                    Console.WriteLine($"\nОставшееся количество попыток: {countAttemps}");
                    if (countAttemps == 0)
                    {
                        Console.WriteLine("\nОшибка авторизации. Повторите попытку позднее. Или введите: логин \"root\", пароль  \"GeekBrains\". Чтоб уж наверняка!");
                    }
                }
                else
                {
                   Console.WriteLine("Вы прошли авторизацию.");
                   break;
                }
            }
            while (countAttemps > 0);
        }
        /// <summary>
        /// 4. Булевый метод проверки логина и пароля.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool CheckLogPass(string login, string password)
        {
            return (login == "root" && password == "GeekBrains")? true : false;
        }
        #endregion
    }
}
