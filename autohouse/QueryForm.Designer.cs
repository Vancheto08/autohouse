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
            this.buttonGetCarsByManufacturer = new System.Windows.Forms.Button();
            this.buttonGetCarCountByManufacturer = new System.Windows.Forms.Button();
            this.labelGetCardOrdersByCustomers = new System.Windows.Forms.Label();
            this.labelGetMostOrderedCar = new System.Windows.Forms.Label();
            this.labelGetCarCountByManufacturer = new System.Windows.Forms.Label();
            this.labelGetCarsByManufacturer = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(43, 326);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersWidth = 51;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(1037, 249);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuery.Location = new System.Drawing.Point(365, 23);
            this.labelQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(167, 43);
            this.labelQuery.TabIndex = 2;
            this.labelQuery.Text = "Справки";
            // 
            // buttonGetCardOrdersByCustomers
            // 
            this.buttonGetCardOrdersByCustomers.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCardOrdersByCustomers.Location = new System.Drawing.Point(896, 103);
            this.buttonGetCardOrdersByCustomers.Name = "buttonGetCardOrdersByCustomers";
            this.buttonGetCardOrdersByCustomers.Size = new System.Drawing.Size(95, 40);
            this.buttonGetCardOrdersByCustomers.TabIndex = 3;
            this.buttonGetCardOrdersByCustomers.Text = "1";
            this.buttonGetCardOrdersByCustomers.UseVisualStyleBackColor = true;
            this.buttonGetCardOrdersByCustomers.Click += new System.EventHandler(this.buttonGetCardOrdersByCustomers_Click);
            // 
            // buttonGetMostOrderedCar
            // 
            this.buttonGetMostOrderedCar.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetMostOrderedCar.Location = new System.Drawing.Point(644, 158);
            this.buttonGetMostOrderedCar.Name = "buttonGetMostOrderedCar";
            this.buttonGetMostOrderedCar.Size = new System.Drawing.Size(95, 40);
            this.buttonGetMostOrderedCar.TabIndex = 4;
            this.buttonGetMostOrderedCar.Text = "2";
            this.buttonGetMostOrderedCar.UseVisualStyleBackColor = true;
            this.buttonGetMostOrderedCar.Click += new System.EventHandler(this.buttonGetMostOrderedCar_Click);
            // 
            // buttonGetCarsByManufacturer
            // 
            this.buttonGetCarsByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCarsByManufacturer.Location = new System.Drawing.Point(769, 205);
            this.buttonGetCarsByManufacturer.Name = "buttonGetCarsByManufacturer";
            this.buttonGetCarsByManufacturer.Size = new System.Drawing.Size(95, 40);
            this.buttonGetCarsByManufacturer.TabIndex = 5;
            this.buttonGetCarsByManufacturer.Text = "3";
            this.buttonGetCarsByManufacturer.UseVisualStyleBackColor = true;
            this.buttonGetCarsByManufacturer.Click += new System.EventHandler(this.buttonGetCarsByManufacturer_Click);
            // 
            // buttonGetCarCountByManufacturer
            // 
            this.buttonGetCarCountByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCarCountByManufacturer.Location = new System.Drawing.Point(769, 257);
            this.buttonGetCarCountByManufacturer.Name = "buttonGetCarCountByManufacturer";
            this.buttonGetCarCountByManufacturer.Size = new System.Drawing.Size(95, 40);
            this.buttonGetCarCountByManufacturer.TabIndex = 6;
            this.buttonGetCarCountByManufacturer.Text = "4";
            this.buttonGetCarCountByManufacturer.UseVisualStyleBackColor = true;
            this.buttonGetCarCountByManufacturer.Click += new System.EventHandler(this.buttonGetCarCountByManufacturer_Click);
            // 
            // labelGetCardOrdersByCustomers
            // 
            this.labelGetCardOrdersByCustomers.AutoSize = true;
            this.labelGetCardOrdersByCustomers.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCardOrdersByCustomers.Location = new System.Drawing.Point(37, 111);
            this.labelGetCardOrdersByCustomers.Name = "labelGetCardOrdersByCustomers";
            this.labelGetCardOrdersByCustomers.Size = new System.Drawing.Size(853, 32);
            this.labelGetCardOrdersByCustomers.TabIndex = 7;
            this.labelGetCardOrdersByCustomers.Text = "1.Извличане на всички поръчки, платени с карта по клиенти:";
            // 
            // labelGetMostOrderedCar
            // 
            this.labelGetMostOrderedCar.AutoSize = true;
            this.labelGetMostOrderedCar.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetMostOrderedCar.Location = new System.Drawing.Point(37, 163);
            this.labelGetMostOrderedCar.Name = "labelGetMostOrderedCar";
            this.labelGetMostOrderedCar.Size = new System.Drawing.Size(597, 32);
            this.labelGetMostOrderedCar.TabIndex = 8;
            this.labelGetMostOrderedCar.Text = "2.Най-купуваната кола (по брой поръчки):";
            // 
            // labelGetCarCountByManufacturer
            // 
            this.labelGetCarCountByManufacturer.AutoSize = true;
            this.labelGetCarCountByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCarCountByManufacturer.Location = new System.Drawing.Point(37, 265);
            this.labelGetCarCountByManufacturer.Name = "labelGetCarCountByManufacturer";
            this.labelGetCarCountByManufacturer.Size = new System.Drawing.Size(724, 32);
            this.labelGetCarCountByManufacturer.TabIndex = 9;
            this.labelGetCarCountByManufacturer.Text = "4.Извличане на всички коли от даден производител:";
            // 
            // labelGetCarsByManufacturer
            // 
            this.labelGetCarsByManufacturer.AutoSize = true;
            this.labelGetCarsByManufacturer.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetCarsByManufacturer.Location = new System.Drawing.Point(37, 212);
            this.labelGetCarsByManufacturer.Name = "labelGetCarsByManufacturer";
            this.labelGetCarsByManufacturer.Size = new System.Drawing.Size(702, 32);
            this.labelGetCarsByManufacturer.TabIndex = 10;
            this.labelGetCarsByManufacturer.Text = "3.Колко коли от всеки производител са продадени:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(943, 592);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 653);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelGetCarsByManufacturer);
            this.Controls.Add(this.labelGetCarCountByManufacturer);
            this.Controls.Add(this.labelGetMostOrderedCar);
            this.Controls.Add(this.labelGetCardOrdersByCustomers);
            this.Controls.Add(this.buttonGetCarCountByManufacturer);
            this.Controls.Add(this.buttonGetCarsByManufacturer);
            this.Controls.Add(this.buttonGetMostOrderedCar);
            this.Controls.Add(this.buttonGetCardOrdersByCustomers);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.dataGridViewResults);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Button buttonGetCardOrdersByCustomers;
        private System.Windows.Forms.Button buttonGetMostOrderedCar;
        private System.Windows.Forms.Button buttonGetCarsByManufacturer;
        private System.Windows.Forms.Button buttonGetCarCountByManufacturer;
        private System.Windows.Forms.Label labelGetCardOrdersByCustomers;
        private System.Windows.Forms.Label labelGetMostOrderedCar;
        private System.Windows.Forms.Label labelGetCarCountByManufacturer;
        private System.Windows.Forms.Label labelGetCarsByManufacturer;
        private System.Windows.Forms.Button button5;
    }
}