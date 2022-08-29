using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрыть текущее окно
            DoublerGame doublerNewgame = new DoublerGame(); //новый экземпляр
            doublerNewgame.Show(); //показать новое окно (запуск игры)
        }

       
        private void guessNumberStart_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрыть текущее окно
            GuessNumber guessGame = new GuessNumber(); //новый экземпляр
            guessGame.Show(); //показать новое окно (запуск игры)
        } 

        private void roundButton4_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //закрыть приложение
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
          this.Close(); //выйти из приложения
        }

        
    }
}
