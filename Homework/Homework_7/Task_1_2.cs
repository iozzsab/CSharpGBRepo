/* 
 * Самойлов Оскар
 * 1.
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем.
 * 
 * 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
 * a) Для ввода данных от человека используется элемент TextBox;
 * б)**Реализовать отдельную форму c TextBox для ввода числа.
 * */

using System;
using System.Windows.Forms;

namespace Homework_7
{
    internal static class Task_1_2
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
