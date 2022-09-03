using Homework_7;

namespace Homework_8
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграTrueFalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторTrueFalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            this.roundButton1 = new Homework_7.RoundButton();
            this.buttonDonate = new Homework_7.RoundButton();
            this.buttonTFGame = new Homework_7.RoundButton();
            this.buttonTFEditor = new Homework_7.RoundButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(31, 22);
            this.toolStripDropDownButton2.Text = "☰";
            this.toolStripDropDownButton2.ToolTipText = "☰";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграTrueFalseToolStripMenuItem,
            this.редакторTrueFalseToolStripMenuItem});
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.menuItemOpen.Text = "Начать";
            // 
            // новаяИграTrueFalseToolStripMenuItem
            // 
            this.новаяИграTrueFalseToolStripMenuItem.Name = "новаяИграTrueFalseToolStripMenuItem";
            this.новаяИграTrueFalseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.новаяИграTrueFalseToolStripMenuItem.Text = "Новая игра TrueFalse";
            this.новаяИграTrueFalseToolStripMenuItem.Click += new System.EventHandler(this.новаяИграTrueFalseToolStripMenuItem_Click);
            // 
            // редакторTrueFalseToolStripMenuItem
            // 
            this.редакторTrueFalseToolStripMenuItem.Name = "редакторTrueFalseToolStripMenuItem";
            this.редакторTrueFalseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.редакторTrueFalseToolStripMenuItem.Text = "Редактор TrueFalse";
            this.редакторTrueFalseToolStripMenuItem.Click += new System.EventHandler(this.редакторTrueFalseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripDropDownButton1.Text = "О программе";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.Location = new System.Drawing.Point(120, 373);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(124, 54);
            this.roundButton1.TabIndex = 3;
            this.roundButton1.Text = "Exit";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // buttonDonate
            // 
            this.buttonDonate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDonate.Location = new System.Drawing.Point(120, 289);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(124, 54);
            this.buttonDonate.TabIndex = 2;
            this.buttonDonate.Text = "Donate";
            this.buttonDonate.UseVisualStyleBackColor = true;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // buttonTFGame
            // 
            this.buttonTFGame.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTFGame.Location = new System.Drawing.Point(120, 110);
            this.buttonTFGame.Name = "buttonTFGame";
            this.buttonTFGame.Size = new System.Drawing.Size(124, 54);
            this.buttonTFGame.TabIndex = 1;
            this.buttonTFGame.Text = "TrueFalse Game";
            this.buttonTFGame.UseVisualStyleBackColor = true;
            this.buttonTFGame.Click += new System.EventHandler(this.buttonTFGame_Click);
            // 
            // buttonTFEditor
            // 
            this.buttonTFEditor.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTFEditor.Location = new System.Drawing.Point(120, 200);
            this.buttonTFEditor.Name = "buttonTFEditor";
            this.buttonTFEditor.Size = new System.Drawing.Size(124, 54);
            this.buttonTFEditor.TabIndex = 0;
            this.buttonTFEditor.Text = "TrueFalse Editor";
            this.buttonTFEditor.UseVisualStyleBackColor = true;
            this.buttonTFEditor.Click += new System.EventHandler(this.buttonTFEditor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.buttonDonate);
            this.Controls.Add(this.buttonTFGame);
            this.Controls.Add(this.buttonTFEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "True False";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private RoundButton buttonTFEditor;
        private RoundButton buttonTFGame;
        private RoundButton buttonDonate;
        private RoundButton roundButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem новаяИграTrueFalseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторTrueFalseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
    }
}