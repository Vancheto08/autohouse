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

        private void openCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm carsForm = new CarForm();
            carsForm.ShowDialog();
        }

        private void маркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManufacturerForm manufacturerForm = new ManufacturerForm(); 
            manufacturerForm.ShowDialog();
        }

        private void клиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void поръчкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void поръчкиКолиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderCarForm orderCarForm = new OrderCarForm();
            orderCarForm.ShowDialog();
        }

        private void сравкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
        }
    }
}
