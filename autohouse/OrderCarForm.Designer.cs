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
            this.buttonInsert.Location = new System.Drawing.Point(55, 390);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(125, 36);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Добави";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(188, 390);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 36);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Промени";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(188, 390);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(315, 390);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 36);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewOrderCars
            // 
            this.dataGridViewOrderCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderCars.Location = new System.Drawing.Point(513, 108);
            this.dataGridViewOrderCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderCars.Name = "dataGridViewOrderCars";
            this.dataGridViewOrderCars.RowHeadersWidth = 51;
            this.dataGridViewOrderCars.RowTemplate.Height = 24;
            this.dataGridViewOrderCars.Size = new System.Drawing.Size(435, 122);
            this.dataGridViewOrderCars.TabIndex = 4;
            this.dataGridViewOrderCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderCars_CellClick);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(513, 415);
            this.dataGridViewCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.RowTemplate.Height = 24;
            this.dataGridViewCars.Size = new System.Drawing.Size(435, 124);
            this.dataGridViewCars.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(851, 557);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 34);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(513, 259);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(435, 125);
            this.dataGridViewOrders.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(183, 206);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(142, 25);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Количество:";
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderId.Location = new System.Drawing.Point(18, 255);
            this.labelOrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(307, 25);
            this.labelOrderId.TabIndex = 9;
            this.labelOrderId.Text = "Идентификатор на поръчка:";
            // 
            // labelCarId
            // 
            this.labelCarId.AutoSize = true;
            this.labelCarId.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarId.Location = new System.Drawing.Point(53, 317);
            this.labelCarId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarId.Name = "labelCarId";
            this.labelCarId.Size = new System.Drawing.Size(272, 25);
            this.labelCarId.TabIndex = 10;
            this.labelCarId.Text = "Идентификатор на кола:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(324, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поръчки на коли";
            // 
            // comboBoxOrderId
            // 
            this.comboBoxOrderId.FormattingEnabled = true;
            this.comboBoxOrderId.Location = new System.Drawing.Point(330, 259);
            this.comboBoxOrderId.Name = "comboBoxOrderId";
            this.comboBoxOrderId.Size = new System.Drawing.Size(135, 21);
            this.comboBoxOrderId.TabIndex = 12;
            // 
            // comboBoxCarId
            // 
            this.comboBoxCarId.FormattingEnabled = true;
            this.comboBoxCarId.Location = new System.Drawing.Point(330, 323);
            this.comboBoxCarId.Name = "comboBoxCarId";
            this.comboBoxCarId.Size = new System.Drawing.Size(135, 21);
            this.comboBoxCarId.TabIndex = 13;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(330, 206);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(135, 20);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // labelOrderCars
            // 
            this.labelOrderCars.AutoSize = true;
            this.labelOrderCars.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderCars.Location = new System.Drawing.Point(648, 81);
            this.labelOrderCars.Name = "labelOrderCars";
            this.labelOrderCars.Size = new System.Drawing.Size(186, 25);
            this.labelOrderCars.TabIndex = 15;
            this.labelOrderCars.Text = "Поръчки на коли:";
            this.labelOrderCars.Click += new System.EventHandler(this.labelOrderCars_Click);
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(682, 232);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(106, 25);
            this.labelOrders.TabIndex = 16;
            this.labelOrders.Text = "Поръчки:";
            this.labelOrders.Click += new System.EventHandler(this.labelOrders_Click);
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCars.Location = new System.Drawing.Point(703, 388);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(70, 25);
            this.labelCars.TabIndex = 17;
            this.labelCars.Text = "Коли:";
            this.labelCars.Click += new System.EventHandler(this.labelCars_Click);
            // 
            // OrderCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 602);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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