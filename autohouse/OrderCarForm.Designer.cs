namespace autohouse
{
    partial class OrderCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCarForm));
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewOrderCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.labelCarId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrderId = new System.Windows.Forms.ComboBox();
            this.comboBoxCarId = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderCars = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelCars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(73, 480);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(167, 44);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Добави";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(251, 480);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(157, 44);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Промени";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(251, 480);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 44);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(420, 480);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(167, 44);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewOrderCars
            // 
            this.dataGridViewOrderCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderCars.Location = new System.Drawing.Point(684, 133);
            this.dataGridViewOrderCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOrderCars.Name = "dataGridViewOrderCars";
            this.dataGridViewOrderCars.RowHeadersWidth = 51;
            this.dataGridViewOrderCars.RowTemplate.Height = 24;
            this.dataGridViewOrderCars.Size = new System.Drawing.Size(580, 150);
            this.dataGridViewOrderCars.TabIndex = 4;
            this.dataGridViewOrderCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderCars_CellClick);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(684, 511);
            this.dataGridViewCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.RowTemplate.Height = 24;
            this.dataGridViewCars.Size = new System.Drawing.Size(580, 153);
            this.dataGridViewCars.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1135, 686);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 42);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(684, 319);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(580, 154);
            this.dataGridViewOrders.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(244, 254);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(182, 31);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Количество:";
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderId.Location = new System.Drawing.Point(24, 314);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(402, 31);
            this.labelOrderId.TabIndex = 9;
            this.labelOrderId.Text = "Идентификатор на поръчка:";
            // 
            // labelCarId
            // 
            this.labelCarId.AutoSize = true;
            this.labelCarId.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarId.Location = new System.Drawing.Point(71, 390);
            this.labelCarId.Name = "labelCarId";
            this.labelCarId.Size = new System.Drawing.Size(355, 31);
            this.labelCarId.TabIndex = 10;
            this.labelCarId.Text = "Идентификатор на кола:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(432, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поръчки на коли";
            // 
            // comboBoxOrderId
            // 
            this.comboBoxOrderId.FormattingEnabled = true;
            this.comboBoxOrderId.Location = new System.Drawing.Point(440, 319);
            this.comboBoxOrderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrderId.Name = "comboBoxOrderId";
            this.comboBoxOrderId.Size = new System.Drawing.Size(179, 24);
            this.comboBoxOrderId.TabIndex = 12;
            // 
            // comboBoxCarId
            // 
            this.comboBoxCarId.FormattingEnabled = true;
            this.comboBoxCarId.Location = new System.Drawing.Point(440, 398);
            this.comboBoxCarId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCarId.Name = "comboBoxCarId";
            this.comboBoxCarId.Size = new System.Drawing.Size(179, 24);
            this.comboBoxCarId.TabIndex = 13;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(440, 254);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(179, 22);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // labelOrderCars
            // 
            this.labelOrderCars.AutoSize = true;
            this.labelOrderCars.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderCars.Location = new System.Drawing.Point(864, 100);
            this.labelOrderCars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderCars.Name = "labelOrderCars";
            this.labelOrderCars.Size = new System.Drawing.Size(244, 31);
            this.labelOrderCars.TabIndex = 15;
            this.labelOrderCars.Text = "Поръчки на коли:";
            this.labelOrderCars.Click += new System.EventHandler(this.labelOrderCars_Click);
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(909, 286);
            this.labelOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(138, 31);
            this.labelOrders.TabIndex = 16;
            this.labelOrders.Text = "Поръчки:";
            this.labelOrders.Click += new System.EventHandler(this.labelOrders_Click);
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCars.Location = new System.Drawing.Point(937, 478);
            this.labelCars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(89, 31);
            this.labelCars.TabIndex = 17;
            this.labelCars.Text = "Коли:";
            this.labelCars.Click += new System.EventHandler(this.labelCars_Click);
            // 
            // OrderCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 741);
            this.Controls.Add(this.labelCars);
            this.Controls.Add(this.labelOrderCars);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.comboBoxCarId);
            this.Controls.Add(this.comboBoxOrderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCarId);
            this.Controls.Add(this.labelOrderId);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.dataGridViewOrderCars);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OrderCarForm";
            this.Text = "OrderCarForm";
            this.Load += new System.EventHandler(this.OrderCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewOrderCars;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.Label labelCarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOrderId;
        private System.Windows.Forms.ComboBox comboBoxCarId;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelOrderCars;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelCars;
    }
}