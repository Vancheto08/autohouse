using System;
using System.Windows.Forms;
using Business;
using Data.Models;

namespace autohouse
{
    public partial class ManufacturerForm : Form
    {
        private ManufacturerBusiness manufacturerBusiness;
        private int editId;
        public ManufacturerForm()
        {
            InitializeComponent();
            manufacturerBusiness = new ManufacturerBusiness();
            editId = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            ManufacturerForm.ActiveForm.Close();
        }

        private void ManufacturerForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            textBoxName.Text = string.Empty;
            textBoxCountry.Text = string.Empty;
        }

        private void UpdateGrid()
        {
            dataGridViewManufacturer.DataSource = manufacturerBusiness.GetAll();
            dataGridViewManufacturer.ReadOnly = true;
            dataGridViewManufacturer.Columns["Brands"].Visible = false;
            dataGridViewManufacturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var country = textBoxCountry.Text;
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Name = name;
            manufacturer.Country = country;
            manufacturerBusiness.Add(manufacturer);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Manufacturer update = manufacturerBusiness.Get(id);
            textBoxName.Text = update.Name;
            textBoxCountry.Text = update.Country;
        }
        private void ToggleSaveUpdate()
        {
            if (buttonUpdate.Visible)
            {
                buttonSave.Visible = true;
                buttonUpdate.Visible = false;
            }
            else
            {
                buttonSave.Visible = false;
                buttonUpdate.Visible = true;
            }
        }
        private void DisableSelect()
        {
            dataGridViewManufacturer.Enabled = false;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridViewManufacturer.SelectedRows.Count > 0)
            {
                var item = dataGridViewManufacturer.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private Manufacturer GetEditedManufacturer()
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ManufacturerId = editId;
            var name = textBoxName.Text;
            var country = textBoxCountry.Text;
            manufacturer.Name = name;
            manufacturer.Country = country;
            return manufacturer;
        }
        private void ResetSelect()
        {
            dataGridViewManufacturer.ClearSelection();
            dataGridViewManufacturer.Enabled = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            Manufacturer manufacturer = GetEditedManufacturer();

            manufacturerBusiness.Update(manufacturer);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewManufacturer.SelectedRows.Count > 0)
            {
                var item = dataGridViewManufacturer.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                manufacturerBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
    }
}
