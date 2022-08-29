/* 
 * Самойлов Оскар
 * 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
 * a) Для ввода данных от человека используется элемент TextBox;
 * б)**Реализовать отдельную форму c TextBox для ввода числа.
 * */

using System;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class GuessNumber : Form
    {
        Random random = new Random();
        /// <summary>
        /// Загаданное число
        /// </summary>
        private int ComputerNumber;
        /// <summary>
        /// Количество попыток
        /// </summary>
        public int СountStep;
        private int i;
        /// <summary>
        /// Точка входа
        /// </summary>
        public GuessNumber()
        {
            i = 10;
            InitializeComponent();
            GenerateNumb();
            CountAttempt();
        }
        /// <summary>
        /// Генерирует случайное число
        /// </summary>
        /// <returns></returns>
        private int GenerateNumb()
        {
            ComputerNumber = random.Next(100);
            return ComputerNumber;
        }
        /// <summary>
        /// 
        /// </summary>
        private void CountAttempt()
        {
            if (СountStep < 10)
            {
                lbCheck.Text = $"Попыток сделано: {СountStep}\n\nОсталось: {i--} \n\n(Максимальное количество попыток: 10)";
            }
            else
            {
                MessageBox.Show("Провал!\nПопытки закончились!", "GuessNumber",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (MessageBox.Show("Желаете сыграть еще раз?", "GuessNumber",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Restart();
                }
                else returnMenu();
            }
        }
        /// <summary>
        /// Возврат в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            returnMenu();
        }
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Проверка введенного числа с защитой от балбеса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheck_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox1.Text, out int user))
            {
                Check(user, ComputerNumber);
            }
            else
            {
                MessageBox.Show("Вы ввели некорректное число!", "GuessNumber",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  Метод проверки выигрыша
        /// </summary>
        /// <param name="UserNumber">Число игрока</param>
        /// <param name="ComputerNumber">Число загданое компьютером</param>
        private void Check(int UserNumber, int ComputerNumber)
        {
            if (UserNumber == ComputerNumber)
            {
                MessageBox.Show($"Вы угадали! C {СountStep} попытки", "GuessNumber",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Желаете сыграть еще раз?", "GuessNumber",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Restart();
                }
                else returnMenu();
            }
            else if (UserNumber < ComputerNumber)
            {
                СountStep++;
                MessageBox.Show("Ваше число МЕНЬШЕ загаданого", "GuessNumber",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CountAttempt();
            }
            else if (UserNumber > ComputerNumber)
            {
                СountStep++;
                MessageBox.Show("Ваше число БОЛЬШЕ загаданого", "GuessNumber",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CountAttempt();
            }
        }
        /// <summary>
        /// Обовление значений/перезапуск
        /// </summary>
        private void Restart()
        {
            i = 10;
            СountStep = 0;
            GenerateNumb();
            CountAttempt();
        }
        /// <summary>
        /// Возврат в меню
        /// </summary>
        private void returnMenu()
        {
            this.Hide(); //скрыть текущее окно
            Start undoMenu = new Start();
            undoMenu.Show(); //показать меню
        }
    }
}
