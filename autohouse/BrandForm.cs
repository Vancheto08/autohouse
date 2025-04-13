using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autohouse
{
    public partial class BrandForm : Form
    {
        private BrandBusiness brandBusiness;
        private ManufacturerBusiness manufacturerBusiness;
        private List<Manufacturer> manufacturers;
        private List<Brand> brands;

        public BrandForm()
        {
            InitializeComponent();
            brandBusiness = new BrandBusiness();
            manufacturerBusiness = new ManufacturerBusiness();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var manufacturerId = int.Parse(comboBoxManufacturer.SelectedValue.ToString());

            Brand brand = new Brand();
            brand.Name = name;
            brand.ManufacturerId = manufacturerId;

            brandBusiness.Add(brand);
            UpdateGrid();
            ClearTextBoxes();

        }
        private void UpdateGrid()
        {
            dataGridViewBrands.DataSource = brandBusiness.GetAll();
            dataGridViewBrands.ReadOnly = true;
            dataGridViewBrands.Columns["BrandId"].Visible = false;
            dataGridViewBrands.Columns["Cars"].Visible = false;
            dataGridViewBrands.Columns["Manufacturer"].Visible = false;
            dataGridViewBrands.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BrandForm_Load(object sender, EventArgs e)
        {
            brands = brandBusiness.GetAll();
            manufacturers = manufacturerBusiness.GetAll();


            dataGridViewBrands.DataSource = brands;
            dataGridViewBrands.Columns["BrandId"].Visible = false;
            dataGridViewBrands.Columns["Cars"].Visible = false;
            dataGridViewBrands.Columns["Manufacturer"].Visible = false;

            dataGridViewManufacturers.DataSource = manufacturers;
            //dataGridView2.Columns["ManufacturerId"].Visible = false;
            dataGridViewManufacturers.Columns["Brands"].Visible = false;

            //Binding bindingManufacturer = new Binding("Text", brands, "ManufacturerId");
            //comboBoxManufacturer.DataBindings.Add(bindingManufacturer);
            comboBoxManufacturer.DataSource = manufacturers;
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "ManufacturerId";


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BrandForm.ActiveForm.Close();
        }
        private void ClearTextBoxes()
        {
            textBoxName.Text = "";
            comboBoxManufacturer.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewBrands.CurrentRow.Selected = true;
           
            int manufacturerId =int.Parse( dataGridViewBrands.SelectedRows[0].Cells["ManufacturerId"].Value.ToString());
            comboBoxManufacturer.SelectedValue= manufacturerId;
            textBoxName.Text = dataGridViewBrands.SelectedRows[0].Cells["Name"].Value.ToString();
        }
    }
}
