namespace autohouse
{
    partial class QueryForm
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
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.labelQuery = new System.Windows.Forms.Label();
            this.buttonGetCardOrdersByCustomers = new System.Windows.Forms.Button();
            this.buttonGetMostOrderedCar = new System.Windows.Forms.Button();
            this.buttonGetCarsCountByManufacturer = new System.Windows.Forms.Button();
            this.buttonGetCarsByManufacturer = new System.Windows.Forms.Button();
            this.labelGetCardOrdersByCustomers = new System.Windows.Forms.Label();
            this.labelGetMostOrderedCar = new System.Windows.Forms.Label();
            this.labelGetCarCountByManufacturer = new System.Windows.Forms.Label();
            this.labelGetCarsByManufacturer = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxManufacturers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(33, 276);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(778, 222);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuery.Location = new System.Drawing.Point(368, 30);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(133, 34);
            this.labelQuery.TabIndex = 2;
            this.labelQuery.Text = "Справки";
            // 
            // buttonGetCardOrdersByCustomers
            // 
            this.buttonGetCardOrdersByCustomers.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCardOrdersByCustomers.Location = new System.Drawing.Point(740, 84);
            this.buttonGetCardOrdersByCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetCardOrdersByCustomers.Name = "buttonGetCardOrdersByCustomers";
            this.buttonGetCardOrdersByCustomers.Size = new System.Drawing.Size(71, 38);
            this.buttonGetCardOrdersByCustomers.TabIndex = 3;
            this.buttonGetCardOrdersByCustomers.Text = "1";
            this.buttonGetCardOrdersByCustomers.UseVisualStyleBackColor = true;
            this.buttonGetCardOrdersByCustomers.Click += new System.EventHandler(this.buttonGetCardOrdersByCustomers_Click);
            // 
            // buttonGetMostOrderedCar
            // 
            this.buttonGetMostOrderedCar.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetMostOrderedCar.Location = new System.Drawing.Point(740, 126);
            this.buttonGetMostOrderedCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetMostOrderedCar.Name = "buttonGetMostOrderedCar";
            this.buttonGetMostOrderedCar.Size = new System.Drawing.Size(71, 38);
            this.buttonGetMostOrderedCar.TabIndex = 4;
            this.buttonGetMostOrderedCar.Text = "2";
            this.buttonGetMostOrderedCar.UseVisualStyleBackColor = true;
            this.buttonGetMostOrderedCar.Click += new System.EventHandler(this.buttonGetMostOrderedCar_Click);
            // 
            // buttonGetCarsCountByManufacturer
            // 
            this.buttonGetCarsCountByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCarsCountByManufacturer.Location = new System.Drawing.Point(740, 167);
            this.buttonGetCarsCountByManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetCarsCountByManufacturer.Name = "buttonGetCarsCountByManufacturer";
            this.buttonGetCarsCountByManufacturer.Size = new System.Drawing.Size(71, 37);
            this.buttonGetCarsCountByManufacturer.TabIndex = 5;
            this.buttonGetCarsCountByManufacturer.Text = "3";
            this.buttonGetCarsCountByManufacturer.UseVisualStyleBackColor = true;
            this.buttonGetCarsCountByManufacturer.Click += new System.EventHandler(this.buttonGetCarsCountByManufacturer_Click);
            // 
            // buttonGetCarsByManufacturer
            // 
            this.buttonGetCarsByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCarsByManufacturer.Location = new System.Drawing.Point(740, 208);
            this.buttonGetCarsByManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetCarsByManufacturer.Name = "buttonGetCarsByManufacturer";
            this.buttonGetCarsByManufacturer.Size = new System.Drawing.Size(71, 39);
            this.buttonGetCarsByManufacturer.TabIndex = 6;
            this.buttonGetCarsByManufacturer.Text = "4";
            this.buttonGetCarsByManufacturer.UseVisualStyleBackColor = true;
            this.buttonGetCarsByManufacturer.Click += new System.EventHandler(this.buttonGetCarsByManufacturer_Click);
            // 
            // labelGetCardOrdersByCustomers
            // 
            this.labelGetCardOrdersByCustomers.AutoSize = true;
            this.labelGetCardOrdersByCustomers.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCardOrdersByCustomers.Location = new System.Drawing.Point(28, 90);
            this.labelGetCardOrdersByCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGetCardOrdersByCustomers.Name = "labelGetCardOrdersByCustomers";
            this.labelGetCardOrdersByCustomers.Size = new System.Drawing.Size(672, 27);
            this.labelGetCardOrdersByCustomers.TabIndex = 7;
            this.labelGetCardOrdersByCustomers.Text = "1. Извличане на всички поръчки, платени с карта по клиенти:";
            // 
            // labelGetMostOrderedCar
            // 
            this.labelGetMostOrderedCar.AutoSize = true;
            this.labelGetMostOrderedCar.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetMostOrderedCar.Location = new System.Drawing.Point(28, 132);
            this.labelGetMostOrderedCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGetMostOrderedCar.Name = "labelGetMostOrderedCar";
            this.labelGetMostOrderedCar.Size = new System.Drawing.Size(473, 27);
            this.labelGetMostOrderedCar.TabIndex = 8;
            this.labelGetMostOrderedCar.Text = "2. Най-купуваната кола (по брой поръчки):";
            // 
            // labelGetCarCountByManufacturer
            // 
            this.labelGetCarCountByManufacturer.AutoSize = true;
            this.labelGetCarCountByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCarCountByManufacturer.Location = new System.Drawing.Point(28, 215);
            this.labelGetCarCountByManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGetCarCountByManufacturer.Name = "labelGetCarCountByManufacturer";
            this.labelGetCarCountByManufacturer.Size = new System.Drawing.Size(572, 27);
            this.labelGetCarCountByManufacturer.TabIndex = 9;
            this.labelGetCarCountByManufacturer.Text = "4. Извличане на всички коли от даден производител:";
            // 
            // labelGetCarsByManufacturer
            // 
            this.labelGetCarsByManufacturer.AutoSize = true;
            this.labelGetCarsByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCarsByManufacturer.Location = new System.Drawing.Point(28, 172);
            this.labelGetCarsByManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGetCarsByManufacturer.Name = "labelGetCarsByManufacturer";
            this.labelGetCarsByManufacturer.Size = new System.Drawing.Size(556, 27);
            this.labelGetCarsByManufacturer.TabIndex = 10;
            this.labelGetCarsByManufacturer.Text = "3. Колко коли от всеки производител са продадени:";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(708, 512);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 40);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxManufacturers
            // 
            this.comboBoxManufacturers.FormattingEnabled = true;
            this.comboBoxManufacturers.Location = new System.Drawing.Point(605, 221);
            this.comboBoxManufacturers.Name = "comboBoxManufacturers";
            this.comboBoxManufacturers.Size = new System.Drawing.Size(129, 21);
            this.comboBoxManufacturers.TabIndex = 12;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 563);
            this.Controls.Add(this.comboBoxManufacturers);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelGetCarsByManufacturer);
            this.Controls.Add(this.labelGetCarCountByManufacturer);
            this.Controls.Add(this.labelGetMostOrderedCar);
            this.Controls.Add(this.labelGetCardOrdersByCustomers);
            this.Controls.Add(this.buttonGetCarsByManufacturer);
            this.Controls.Add(this.buttonGetCarsCountByManufacturer);
            this.Controls.Add(this.buttonGetMostOrderedCar);
            this.Controls.Add(this.buttonGetCardOrdersByCustomers);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.dataGridViewResults);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Button buttonGetCardOrdersByCustomers;
        private System.Windows.Forms.Button buttonGetMostOrderedCar;
        private System.Windows.Forms.Button buttonGetCarsCountByManufacturer;
        private System.Windows.Forms.Button buttonGetCarsByManufacturer;
        private System.Windows.Forms.Label labelGetCardOrdersByCustomers;
        private System.Windows.Forms.Label labelGetMostOrderedCar;
        private System.Windows.Forms.Label labelGetCarCountByManufacturer;
        private System.Windows.Forms.Label labelGetCarsByManufacturer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxManufacturers;
    }
}