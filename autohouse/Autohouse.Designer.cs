namespace autohouse
{
    partial class Autohouse
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
            this.menuStripHomePage = new System.Windows.Forms.MenuStrip();
            this.openCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поръчкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поръчкиКолиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHomePage
            // 
            this.menuStripHomePage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripHomePage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHomePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCarsToolStripMenuItem,
            this.маркиToolStripMenuItem,
            this.производителиToolStripMenuItem,
            this.клиентиToolStripMenuItem,
            this.поръчкиToolStripMenuItem,
            this.поръчкиКолиToolStripMenuItem,
            this.сравкиToolStripMenuItem});
            this.menuStripHomePage.Location = new System.Drawing.Point(0, 0);
            this.menuStripHomePage.Name = "menuStripHomePage";
            this.menuStripHomePage.Size = new System.Drawing.Size(1067, 36);
            this.menuStripHomePage.TabIndex = 0;
            this.menuStripHomePage.Text = "menuStrip1";
            // 
            // openCarsToolStripMenuItem
            // 
            this.openCarsToolStripMenuItem.Name = "openCarsToolStripMenuItem";
            this.openCarsToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.openCarsToolStripMenuItem.Text = "Коли";
            this.openCarsToolStripMenuItem.Click += new System.EventHandler(this.openCarsToolStripMenuItem_Click);
            // 
            // маркиToolStripMenuItem
            // 
            this.маркиToolStripMenuItem.Name = "маркиToolStripMenuItem";
            this.маркиToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.маркиToolStripMenuItem.Text = "Марки";
            this.маркиToolStripMenuItem.Click += new System.EventHandler(this.маркиToolStripMenuItem_Click);
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.производителиToolStripMenuItem.Text = "Производители";
            this.производителиToolStripMenuItem.Click += new System.EventHandler(this.производителиToolStripMenuItem_Click);
            // 
            // клиентиToolStripMenuItem
            // 
            this.клиентиToolStripMenuItem.Name = "клиентиToolStripMenuItem";
            this.клиентиToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.клиентиToolStripMenuItem.Text = "Клиенти";
            this.клиентиToolStripMenuItem.Click += new System.EventHandler(this.клиентиToolStripMenuItem_Click);
            // 
            // поръчкиToolStripMenuItem
            // 
            this.поръчкиToolStripMenuItem.Name = "поръчкиToolStripMenuItem";
            this.поръчкиToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.поръчкиToolStripMenuItem.Text = "Поръчки";
            this.поръчкиToolStripMenuItem.Click += new System.EventHandler(this.поръчкиToolStripMenuItem_Click);
            // 
            // поръчкиКолиToolStripMenuItem
            // 
            this.поръчкиКолиToolStripMenuItem.Name = "поръчкиКолиToolStripMenuItem";
            this.поръчкиКолиToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.поръчкиКолиToolStripMenuItem.Text = "Поръчки - Коли";
            this.поръчкиКолиToolStripMenuItem.Click += new System.EventHandler(this.поръчкиКолиToolStripMenuItem_Click);
            // 
            // сравкиToolStripMenuItem
            // 
            this.сравкиToolStripMenuItem.Name = "сравкиToolStripMenuItem";
            this.сравкиToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.сравкиToolStripMenuItem.Text = "Справки";
            this.сравкиToolStripMenuItem.Click += new System.EventHandler(this.сравкиToolStripMenuItem_Click);
            // 
            // Autohouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 49);
            this.Controls.Add(this.menuStripHomePage);
            this.MainMenuStrip = this.menuStripHomePage;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Autohouse";
            this.Text = "Автокъща";
            this.menuStripHomePage.ResumeLayout(false);
            this.menuStripHomePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHomePage;
        private System.Windows.Forms.ToolStripMenuItem openCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поръчкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поръчкиКолиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравкиToolStripMenuItem;
    }
}

