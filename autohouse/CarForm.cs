using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using Data.Models;

namespace autohouse
{
    public partial class CarForm : Form
    {
        private CarBusiness carBusiness;
        private BrandBusiness brandBusiness;
        private List<Brand> brands;
        private List<Car> cars;
        private int editId = 0;
        public CarForm()
        {
            InitializeComponent();
            carBusiness = new CarBusiness();
            brandBusiness = new BrandBusiness();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            cars = carBusiness.GetAll();
            brands = brandBusiness.GetAll();

            dataGridViewCars.DataSource = cars;
            dataGridViewCars.Columns["CarId"].Visible = false;
            dataGridViewCars.Columns["Brand"].Visible = false;
            //dataGridViewCars.Columns["BrandId"].Visible = false;
            dataGridViewCars.Columns["Cars"].Visible = false;

            dataGridViewBrand.DataSource = brands;
            //dataGridViewBrand.Columns["BrandId"].Visible = false;
            dataGridViewBrand.Columns["Cars"].Visible = false;
            dataGridViewBrand.Columns["Manufacturer"].Visible = false;

            comboBoxBrand.DataSource = brands;
            comboBoxBrand.DisplayMember = "Name";
            comboBoxBrand.ValueMember = "BrandId";
        }
        private void UpdateGrid()
        {
            dataGridViewCars.DataSource = carBusiness.GetAll();
            dataGridViewCars.ReadOnly = true;
            dataGridViewCars.Columns["CarId"].Visible = false;
            dataGridViewCars.Columns["Brand"].Visible = false;
            dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
            textBoxPrice.Text = "";
            textBoxPublicationYear.Text = "";
            textBoxQuantity.Text = "";
            comboBoxBrand.Text = "";
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
        private void buttonBack_Click(object sender, EventArgs e)
        {
            CarForm.ActiveForm.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var price = decimal.Parse(textBoxPrice.Text);
            var publicationYear = int.Parse(textBoxPublicationYear.Text);
            var quantity = int.Parse(textBoxQuantity.Text);
            var brandId = int.Parse(comboBoxBrand.SelectedValue.ToString());

            Car car = new Car();
            car.Price = price;
            car.PublicationYear = publicationYear;
            car.Quantity = quantity;
            car.BrandId = brandId;

            carBusiness.Add(car);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Car update = carBusiness.Get(id);
            textBoxPrice.Text = update.Price.ToString();
            textBoxPublicationYear.Text = update.PublicationYear.ToString();
            textBoxQuantity.Text = update.Quantity.ToString();

        }
        private void DisableSelect()
        {
            dataGridViewCars.Enabled = false;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count > 0)
            {
                var item = dataGridViewCars.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCars.CurrentRow.Selected = true;

            int brandId = int.Parse(dataGridViewCars.SelectedRows[0].Cells["BrandId"].Value.ToString());
            comboBoxBrand.SelectedValue = brandId;
            textBoxPrice.Text = dataGridViewCars.SelectedRows[0].Cells["Price"].Value.ToString();
            textBoxPublicationYear.Text = dataGridViewCars.SelectedRows[1].Cells["PublicationYear"].Value.ToString();
            textBoxQuantity.Text = dataGridViewCars.SelectedRows[2].Cells["Quantity"].Value.ToString();
        }
        private Car GetEditedCars()
        {
            Car car = new Car();
            car.CarId = editId;
            car.Price = decimal.Parse(textBoxPrice.Text);
            car.PublicationYear = int.Parse(textBoxPublicationYear.Text);
            car.Quantity = int.Parse(textBoxQuantity.Text);
            car.BrandId = int.Parse(comboBoxBrand.SelectedValue.ToString());
            return car;
        }
        private void ResetSelect()
        {
            dataGridViewCars.ClearSelection();
            dataGridViewCars.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Car editedCar = GetEditedCars();
            carBusiness.Update(editedCar);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count>0)
            {
                var item = dataGridViewCars.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                carBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
    }
}
