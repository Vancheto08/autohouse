using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Business;

namespace autohouse
{
    public partial class QueryForm : Form
    {
        private QueryBusiness queryBusiness = new QueryBusiness();
        public QueryForm()
        {
            InitializeComponent();
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
                    Customer = o.Customer.FirstName + " " + o.Customer.LastName,
                    o.OrderDate
                }).ToList();
        }

        private void buttonGetMostOrderedCar_Click(object sender, EventArgs e)
        {
            var car = queryBusiness.GetMostOrderedCar();

            //
        }

        private void buttonGetCarsByManufacturer_Click(object sender, EventArgs e)
        {
            List<ManufacturerCountCars> cars = queryBusiness.GetCarCountByManufacturer();
            dataGridViewResults.DataSource = cars;
        }

        private void buttonGetCarCountByManufacturer_Click(object sender, EventArgs e)
        {
            //  dataGridViewResults.DataSource = queryBusiness.GetCarsByManufacturer().ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QueryForm.ActiveForm.Close();
        }
    }
}
