/* 
 * Самойлов Оскар
 * 1.
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем.
 * */

using System;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class DoublerGame : Form
    {
        private Random random = new Random(); //рандомное число
        /// <summary>
        /// Число полученое от компьютера
        /// </summary>
        private int computerNumber;
        /// <summary>
        /// Число игрока
        /// </summary>
        private int userNumber;
        /// <summary>
        /// Счётчик
        /// </summary>
        private int count;
        /// <summary>
        /// Точка старта
        /// </summary>
        public DoublerGame()
        {
            InitializeComponent();
            computerNumber = random.Next(30);
            count = 0;
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(30), count);
            placeComputerNumber.Text = $"{computerNumber}";
            MessageBox.Show($"У вас должно получится число: {computerNumber}, за минимальное количество возможных попыток", "Удвоитель",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Метод для обновления зачения счётчика количетсва попыток
        /// </summary>
        /// <param name="count"></param>
        private void UpdateCount(int count)
        {
            placeCounter.Text = $"{count}";
        }
        /// <summary>
        /// Метод обновления значения числа игрока
        /// </summary>
        /// <param name="userNumber"></param>
        private void UpdateGameState(int userNumber)
        {
            placeUserNumber.Text = $"{userNumber}";
        }
        /// <summary>
        /// Значение которое необходимо подобрать
        /// </summary>
        /// <param name="userNumber"></param>
        /// <param name="computerNumber"></param>
        /// <param name="count"></param>
        private void UpdateGameState(int userNumber, int computerNumber, int count)
        {
            UpdateGameState(userNumber);
            UpdateCount(count);
            this.computerNumber = computerNumber;
            placeComputerNumber.Text = $"{computerNumber}";
        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ReturnMenu();
        }
        /// <summary>
        /// Кнопка "Перезапуск игры"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            count = 0;
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(30), count);

            placeComputerNumber.Text = $"{computerNumber}";
            MessageBox.Show($"У вас должно получится число: {computerNumber}, за минимальное количество возможных попыток", "Удвоитель",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Кнопка "Отмена последнего действия"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            UpdateCount(--count);
            if (userNumber % 2 == 0)
            {
                UpdateGameState(userNumber /= 2);
            }
            else if (userNumber % 2 != 0)
            {
                UpdateGameState(userNumber -= 1);
            }
            if (count < 0)
            {
                MessageBox.Show("Нельзя отменить то, что вы ещё не сделали!", "Doubler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Doubler",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    count = 0;
                    UpdateGameState(userNumber, random.Next(30), count);
                }
                else
                {
                    ReturnMenu();
                }
            }
        }
        /// <summary>
        /// Кнопка +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UpdateGameState(++userNumber);
            UpdateCount(++count);
            CheckWin();
        }
        /// <summary>
        /// Кнопка умножить х2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 2);
            UpdateCount(++count);
            CheckWin();
        }
        /// <summary>
        /// Метод проверки выигрыша
        /// </summary>
        private void CheckWin()
        {
            int sum = computerNumber;
            int counter = 0;
            if (computerNumber == userNumber)
            {
                while (sum != 0)
                {
                    if (sum % 2 == 0)
                    {
                        sum = sum / 2;
                        counter++;
                    }
                    else { sum = sum - 1; counter++; }
                }
                if (counter == count)
                {
                    MessageBox.Show("Вы успешно завершили игру", "Doubler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Желаете сыграть еще раз?", "Doubler",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Restart();
                    }
                    else
                    {
                        ReturnMenu();
                    }

                }
                else
                {
                    MessageBox.Show($"Слишком много попыток!", "Doubler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (MessageBox.Show("Желаете сыграть еще раз?", "Doubler",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Restart();
                    }
                    else
                    {
                        ReturnMenu();
                    }
                }
            }
            else if (computerNumber < userNumber)
            {
                MessageBox.Show("Провал! Получилось больше чем нужно!", "Doubler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("Желаете попробовать еще раз?", "Doubler",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Restart();
                }
                else
                {
                    ReturnMenu();
                }
            }
        }
        private void Restart()
        {
            placeComputerNumber.Text = "";
            count = 0;
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(30), count);
        }
        /// <summary>
        /// Возврат в меню
        /// </summary>
        private void ReturnMenu()
        {
            this.Hide(); //скрыть текущее окно
            Start undoMenu = new Start();
            undoMenu.Show(); //показать меню
        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        
    }
}



