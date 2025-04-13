namespace autohouse
{
    partial class BrandForm
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
            this.labelBrand = new System.Windows.Forms.Label();
            this.dataGridViewBrands = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewManufacturers = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(322, 53);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(109, 34);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Марки";
            // 
            // dataGridViewBrands
            // 
            this.dataGridViewBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrands.Location = new System.Drawing.Point(402, 115);
            this.dataGridViewBrands.Name = "dataGridViewBrands";
            this.dataGridViewBrands.RowHeadersWidth = 51;
            this.dataGridViewBrands.Size = new System.Drawing.Size(425, 126);
            this.dataGridViewBrands.TabIndex = 1;
            this.dataGridViewBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrands_CellClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(104, 137);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Име:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 143);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(169, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(173, 210);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(169, 21);
            this.comboBoxManufacturer.TabIndex = 4;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(0, 204);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(167, 25);
            this.labelManufacturer.TabIndex = 5;
            this.labelManufacturer.Text = "Производител:";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(31, 306);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(106, 36);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Добави";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewManufacturers
            // 
            this.dataGridViewManufacturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturers.Location = new System.Drawing.Point(402, 258);
            this.dataGridViewManufacturers.Name = "dataGridViewManufacturers";
            this.dataGridViewManufacturers.RowHeadersWidth = 51;
            this.dataGridViewManufacturers.Size = new System.Drawing.Size(425, 129);
            this.dataGridViewManufacturers.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(143, 306);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 36);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Промени";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(263, 306);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 36);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(143, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 39);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(700, 402);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 36);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewManufacturers);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewBrands);
            this.Controls.Add(this.labelBrand);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.DataGridView dataGridViewBrands;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewManufacturers;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
    }
}