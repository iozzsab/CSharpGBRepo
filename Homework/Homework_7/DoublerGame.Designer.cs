namespace Homework_7
{
    partial class DoublerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placeComputerNumber = new Homework_7.RoundButton();
            this.placeUserNumber = new Homework_7.RoundButton();
            this.placeCounter = new Homework_7.RoundButton();
            this.buttonMultiply = new Homework_7.RoundButton();
            this.buttonPlus = new Homework_7.RoundButton();
            this.buttonUndo = new Homework_7.RoundButton();
            this.buttonReset = new Homework_7.RoundButton();
            this.roundButton4 = new Homework_7.RoundButton();
            this.buttonMenu = new Homework_7.RoundButton();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(153, 67);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(80, 34);
            this.score.TabIndex = 12;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Received number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your current number";
            // 
            // placeComputerNumber
            // 
            this.placeComputerNumber.BackColor = System.Drawing.Color.Transparent;
            this.placeComputerNumber.Enabled = false;
            this.placeComputerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeComputerNumber.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeComputerNumber.Location = new System.Drawing.Point(86, 199);
            this.placeComputerNumber.Name = "placeComputerNumber";
            this.placeComputerNumber.Size = new System.Drawing.Size(214, 54);
            this.placeComputerNumber.TabIndex = 11;
            this.placeComputerNumber.UseVisualStyleBackColor = false;
            // 
            // placeUserNumber
            // 
            this.placeUserNumber.BackColor = System.Drawing.Color.Transparent;
            this.placeUserNumber.Enabled = false;
            this.placeUserNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeUserNumber.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeUserNumber.Location = new System.Drawing.Point(86, 293);
            this.placeUserNumber.Name = "placeUserNumber";
            this.placeUserNumber.Size = new System.Drawing.Size(214, 54);
            this.placeUserNumber.TabIndex = 11;
            this.placeUserNumber.UseVisualStyleBackColor = false;
            // 
            // placeCounter
            // 
            this.placeCounter.BackColor = System.Drawing.Color.Transparent;
            this.placeCounter.Enabled = false;
            this.placeCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeCounter.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeCounter.Location = new System.Drawing.Point(150, 104);
            this.placeCounter.Name = "placeCounter";
            this.placeCounter.Size = new System.Drawing.Size(92, 54);
            this.placeCounter.TabIndex = 11;
            this.placeCounter.UseVisualStyleBackColor = false;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(86, 353);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(104, 94);
            this.buttonMultiply.TabIndex = 10;
            this.buttonMultiply.Text = "x2";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(196, 353);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(104, 94);
            this.buttonPlus.TabIndex = 8;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUndo.Location = new System.Drawing.Point(306, 393);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(66, 54);
            this.buttonUndo.TabIndex = 7;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(12, 393);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(66, 54);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
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
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMenu.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(45, 49);
            this.buttonMenu.TabIndex = 13;
            this.buttonMenu.Text = "≡";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // DoublerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework_7.Properties.Resources.background_game;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.placeComputerNumber);
            this.Controls.Add(this.placeUserNumber);
            this.Controls.Add(this.placeCounter);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.roundButton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoublerGame";
            this.Text = "Doubler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundButton4;
        private RoundButton buttonReset;
        private RoundButton buttonUndo;
        private RoundButton buttonPlus;
        private RoundButton buttonMultiply;
        private RoundButton placeCounter;
        private RoundButton placeUserNumber;
        private RoundButton placeComputerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
        private RoundButton buttonMenu;
    }
}