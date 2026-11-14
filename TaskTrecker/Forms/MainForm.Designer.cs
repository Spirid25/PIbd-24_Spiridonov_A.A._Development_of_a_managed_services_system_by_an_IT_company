namespace TaskTrecker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem1 = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            услугиToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            договорыToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчётыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem1, сотрудникиToolStripMenuItem, услугиToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            справочникиToolStripMenuItem.Click += справочникиToolStripMenuItem_Click;
            // 
            // клиентыToolStripMenuItem1
            // 
            клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            клиентыToolStripMenuItem1.Size = new Size(180, 22);
            клиентыToolStripMenuItem1.Text = "Клиенты";
            клиентыToolStripMenuItem1.Click += клиентыToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(180, 22);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // услугиToolStripMenuItem
            // 
            услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            услугиToolStripMenuItem.Size = new Size(180, 22);
            услугиToolStripMenuItem.Text = "Услуги";
            услугиToolStripMenuItem.Click += услугиToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { договорыToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            операцииToolStripMenuItem.Click += операцииToolStripMenuItem_Click;
            // 
            // договорыToolStripMenuItem
            // 
            договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            договорыToolStripMenuItem.Size = new Size(180, 22);
            договорыToolStripMenuItem.Text = "Договоры";
            договорыToolStripMenuItem.Click += договорыToolStripMenuItem_Click;
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(60, 20);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem1;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private ToolStripMenuItem договорыToolStripMenuItem;
    }
}
