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
    public partial class TrueFalseGame : Form
    {
        public TrueFalseGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Образовательный портал: GeekBrains\nПреподаватель: Станистав Байраковский\nСтудент: Самойлов Оскар\nВерсия программы: 0.1", "True False",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void возвратВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnMenu();
        }
        /// <summary>
        /// Возврат в меню
        /// </summary>
        private void returnMenu()
        {
            this.Hide(); //скрыть текущее окно
            Menu returnMenu = new Menu();
            returnMenu.Show(); //показать меню
        }
        /// <summary>
        /// Кнопка Editor контекстоного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редакторTrueFalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrueFalseEditor trueFalseEditor = new TrueFalseEditor();
            trueFalseEditor.Show();

        }

        private void TrueFalseGame_Load(object sender, EventArgs e)
        {

        }
    }
}
