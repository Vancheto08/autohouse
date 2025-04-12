namespace autohouse
{
    partial class ManufacturerForm
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
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dataGridViewManufacturer = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.Location = new System.Drawing.Point(311, 36);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(241, 35);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Производители";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(124, 143);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 27);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(82, 184);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(118, 27);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "Държава:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(213, 141);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 32);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(213, 179);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(179, 32);
            this.textBoxCountry.TabIndex = 4;
            // 
            // dataGridViewManufacturer
            // 
            this.dataGridViewManufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturer.Location = new System.Drawing.Point(435, 107);
            this.dataGridViewManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewManufacturer.Name = "dataGridViewManufacturer";
            this.dataGridViewManufacturer.RowHeadersWidth = 51;
            this.dataGridViewManufacturer.RowTemplate.Height = 24;
            this.dataGridViewManufacturer.Size = new System.Drawing.Size(410, 147);
            this.dataGridViewManufacturer.TabIndex = 5;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(22, 256);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(128, 37);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Добави";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(155, 256);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 37);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Промени";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(288, 256);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 37);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(701, 309);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 37);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(156, 256);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 37);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 374);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewManufacturer);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelManufacturer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManufacturerForm";
            this.Text = "ManufacturerForm";
            this.Load += new System.EventHandler(this.ManufacturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DataGridView dataGridViewManufacturer;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
    }
}