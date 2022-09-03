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
    public partial class TrueFalseEditor : Form
    {
        TrueFalseEngine engine;
        public TrueFalseEditor()
        {
            InitializeComponent();
        }

        private void возвратВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnMenu();
        }
        /// <summary>
        /// Возврат в главное меню
        /// </summary>
        private void returnMenu()
        {
            this.Hide(); //скрыть текущее окно
            Menu returnMenu = new Menu();
            returnMenu.Show(); //показать меню
        }
        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Образовательный портал: GeekBrains\nПреподаватель: Станистав Байраковский\nСтудент: Самойлов Оскар\nВерсия программы: 0.1", "True False",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Кнопка новая игра контекстного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void новаяИграTrueFalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrueFalseGame trueFalseGame = new TrueFalseGame();
            trueFalseGame.Show();
        }

        /// <summary>
        /// Копка New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(sfd.FileName);
                engine.Add("Земля круглая?", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        /// <summary>
        /// Кнопка Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(ofd.FileName);
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
            }
        }
        /// <summary>
        /// Кнопка save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            if (engine != null) engine.Save();
            else MessageBox.Show("База данных не создана");
        }
        /// <summary>
        /// Кнопка Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (engine == null)
            {
                MessageBox.Show("Создайте или откройте новую базу данных", "TrueFalse");
                return;
            }
            engine.Add((engine.Count + 1).ToString(), true);
            nudNumber.Maximum = engine.Count;
            nudNumber.Value = engine.Count;
        }
        /// <summary>
        /// Кнопка Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (engine == null)
            {
                MessageBox.Show("Пока нечего удалять, откройте или сойздайте новую базу данных", "TrueFalse");
                return;
            }
            if (nudNumber.Maximum == 1 || engine == null) return;
            engine.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (engine == null)
            {
                MessageBox.Show("Пока нечего сохранять, откройте или сойздайте новую базу данных", "TrueFalse");
                return;
            }
            try
            {
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Откройте или создайте файл с вопросами");
            }
        }
        /// <summary>
        /// Переключатель значения (список вопросов)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (engine == null)
            {
                MessageBox.Show("А что листать? Откройте или сойздайте новую базу данных", "TrueFalse");
                return;
            }
            try
            {
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Вопрос отсутствует");
            }
        }
        /// <summary>
        /// Кнопка сохраить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (engine == null)
            {
                engine = new TrueFalseEngine(saveFileDialog1.FileName);
                engine.Add("Земля круглая?", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                engine.FileName = saveFileDialog1.FileName;
                engine.Save();
                MessageBox.Show("Файл сохранен");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
