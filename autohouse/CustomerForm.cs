using Business;
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
    public partial class CustomerForm : Form
    {
        private CustomerBusiness customerBusiness;
        public CustomerForm()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CustomerForm.ActiveForm.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateGrid()
        {
            dataGridViewCustomers.DataSource = customerBusiness.GetAll();
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {

        }
    }
}
