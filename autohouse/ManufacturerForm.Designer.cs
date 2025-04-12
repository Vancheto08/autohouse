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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.Location = new System.Drawing.Point(352, 34);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(301, 43);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Производители";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(166, 176);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 32);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(110, 226);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(147, 32);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "Държава:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(284, 173);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 38);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(284, 220);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(237, 38);
            this.textBoxCountry.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(580, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(379, 181);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(30, 315);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(171, 45);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Добави";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(207, 315);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(171, 45);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Промени";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(384, 315);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 45);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(819, 392);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 45);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 460);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelManufacturer);
            this.Name = "ManufacturerForm";
            this.Text = "ManufacturerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
    }
}