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
    public partial class Autohouse : Form
    {
        public Autohouse()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm carsForm = new CarForm();
            carsForm.ShowDialog();
        }

        private void BrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }

        private void ManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManufacturerForm manufacturerForm = new ManufacturerForm(); 
            manufacturerForm.ShowDialog();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void OrderCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderCarForm orderCarForm = new OrderCarForm();
            orderCarForm.ShowDialog();
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
        }
    } 
}
