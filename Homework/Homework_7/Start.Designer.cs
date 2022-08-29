namespace Homework_7
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roundButton4 = new Homework_7.RoundButton();
            this.roundButton3 = new Homework_7.RoundButton();
            this.roundButton1 = new Homework_7.RoundButton();
            this.guessNumberStart = new Homework_7.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton4
            // 
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.roundButton4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton4.Location = new System.Drawing.Point(327, 12);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(45, 49);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "X";
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click_1);
            // 
            // roundButton3
            // 
            this.roundButton3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton3.Location = new System.Drawing.Point(119, 399);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(150, 50);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "Выйти";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.Location = new System.Drawing.Point(96, 186);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(200, 50);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Новая игра";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // guessNumberStart
            // 
            this.guessNumberStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessNumberStart.Location = new System.Drawing.Point(96, 315);
            this.guessNumberStart.Name = "guessNumberStart";
            this.guessNumberStart.Size = new System.Drawing.Size(200, 50);
            this.guessNumberStart.TabIndex = 5;
            this.guessNumberStart.Text = "Новая игра";
            this.guessNumberStart.UseVisualStyleBackColor = true;
            this.guessNumberStart.Click += new System.EventHandler(this.guessNumberStart_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework_7.Properties.Resources.background_start;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.guessNumberStart);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Doubler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton roundButton1;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton guessNumberStart;
    }
}

