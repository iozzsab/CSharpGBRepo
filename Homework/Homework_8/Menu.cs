using Homework_7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Кнопка выход котекстого меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Кпонка О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Образовательный портал: GeekBrains\nПреподаватель: Станистав Байраковский\nСтудент: Самойлов Оскар\nВерсия программы: 0.1", "True False",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Кнопка донат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDonate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Спасибо за Вашу щедрость! \nПросто улыбнитесь - нам этого будет достаточно!", "True False",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Кнопка Editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTFEditor_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрыть текущее окно
            TrueFalseEditor trueFalseEditor = new TrueFalseEditor(); //новый экземпляр
            trueFalseEditor.Show(); //показать новое окно (запуск игры)
        }
        /// <summary>
        ///  Кнопка Editor контекстного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редакторTrueFalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрыть текущее окно
            TrueFalseEditor trueFalseEditor = new TrueFalseEditor(); //новый экземпляр
            trueFalseEditor.Show(); //показать новое окно (запуск игры)
        }
        /// <summary>
        /// Кнопка Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTFGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrueFalseGame trueFalseGame = new TrueFalseGame();
            trueFalseGame.Show();
        }
        /// <summary>
        /// Кнопка новая игра контекстого меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void новаяИграTrueFalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrueFalseGame trueFalseGame = new TrueFalseGame();
            trueFalseGame.Show();
        }
    }
}
