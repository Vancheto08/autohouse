using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Business;
using Data.Models;

namespace autohouse
{
    public partial class QueryForm : Form
    {
        private QueryBusiness queryBusiness = new QueryBusiness();
        public QueryForm()
        {
            InitializeComponent();

            ManufacturerBusiness manufacturer = new ManufacturerBusiness();
            comboBoxManufacturers.DataSource = manufacturer.GetAll().Select(m => m.Name).ToList();
        }


        private void QueryForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetCardOrdersByCustomers_Click(object sender, EventArgs e)
        {
            dataGridViewResults.DataSource = queryBusiness.GetCardOrdersByCustomers()
                .Select(o => new
                {
                    o.OrderId,
                    o.Customer.FirstName,
                    o.Customer.LastName,
                    o.OrderDate
                }).ToList();
        }

        private void buttonGetMostOrderedCar_Click(object sender, EventArgs e)
        {
            dataGridViewResults.DataSource = new List<Car>() { queryBusiness.GetMostOrderedCar() }.Select
                (c => new
                {
                    c.CarId,
                    c.Brand.Name,
                    c.Price,
                    c.PublicationYear,
                    c.Quantity
                });
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            QueryForm.ActiveForm.Close();
        }

        private void buttonGetCarsCountByManufacturer_Click(object sender, EventArgs e)
        {
            List<ManufacturerCountCars> cars = queryBusiness.GetCarCountByManufacturer();
            dataGridViewResults.DataSource = cars;
        }

        private void buttonGetCarsByManufacturer_Click(object sender, EventArgs e)
        {
            dataGridViewResults.DataSource = queryBusiness.GetCarsByManufacturer(comboBoxManufacturers.Text).
                Select(m=> new
                {
                    m.CarId,
                    m.Brand.Name,
                    m.Price,
                    m.PublicationYear, 
                    m.Quantity
                }).
                ToList();
        }
    }
}
