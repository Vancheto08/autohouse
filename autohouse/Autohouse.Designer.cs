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
            this.OpenCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHomePage
            // 
            this.menuStripHomePage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripHomePage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHomePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCarsToolStripMenuItem,
            this.BrandToolStripMenuItem,
            this.ManufacturerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.OrderCarToolStripMenuItem,
            this.QueryToolStripMenuItem});
            this.menuStripHomePage.Location = new System.Drawing.Point(0, 0);
            this.menuStripHomePage.Name = "menuStripHomePage";
            this.menuStripHomePage.Size = new System.Drawing.Size(1067, 36);
            this.menuStripHomePage.TabIndex = 0;
            this.menuStripHomePage.Text = "menuStrip1";
            // 
            // OpenCarsToolStripMenuItem
            // 
            this.OpenCarsToolStripMenuItem.Name = "OpenCarsToolStripMenuItem";
            this.OpenCarsToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.OpenCarsToolStripMenuItem.Text = "Коли";
            this.OpenCarsToolStripMenuItem.Click += new System.EventHandler(this.OpenCarsToolStripMenuItem_Click);
            // 
            // BrandToolStripMenuItem
            // 
            this.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem";
            this.BrandToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.BrandToolStripMenuItem.Text = "Марки";
            this.BrandToolStripMenuItem.Click += new System.EventHandler(this.BrandToolStripMenuItem_Click);
            // 
            // ManufacturerToolStripMenuItem
            // 
            this.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem";
            this.ManufacturerToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.ManufacturerToolStripMenuItem.Text = "Производители";
            this.ManufacturerToolStripMenuItem.Click += new System.EventHandler(this.ManufacturerToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.CustomerToolStripMenuItem.Text = "Клиенти";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.OrderToolStripMenuItem.Text = "Поръчки";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // OrderCarToolStripMenuItem
            // 
            this.OrderCarToolStripMenuItem.Name = "OrderCarToolStripMenuItem";
            this.OrderCarToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.OrderCarToolStripMenuItem.Text = "Поръчки - Коли";
            this.OrderCarToolStripMenuItem.Click += new System.EventHandler(this.OrderCarToolStripMenuItem_Click);
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.QueryToolStripMenuItem.Text = "Справки";
            this.QueryToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // Autohouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 283);
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
        private System.Windows.Forms.ToolStripMenuItem OpenCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
    }
}

