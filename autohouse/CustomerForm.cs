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
    public partial class CustomerForm : Form
    {
        private CustomerBusiness customerBusiness;
        private int editId;
        public CustomerForm()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
            editId = 0;
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
            dataGridViewCustomers.Columns["Orders"].Visible = false;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var phoneNumber = textBoxPhoneNumber.Text;
            var address = textBoxAddress.Text;

            Customer customer = new Customer();
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.PhoneNumber = phoneNumber;
            customer.Address = address;

            customerBusiness.Add(customer);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Customer update = customerBusiness.Get(id);
            textBoxFirstName.Text = update.FirstName;
            textBoxLastName.Text = update.LastName;
            textBoxPhoneNumber.Text = update.PhoneNumber;
            textBoxAddress.Text = update.Address;
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
            dataGridViewCustomers.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var item = dataGridViewCustomers.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }
        private Customer GetEditedCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerId = editId;

            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var phoneNumber = textBoxPhoneNumber.Text;
            var address = textBoxAddress.Text;

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.PhoneNumber = phoneNumber;
            customer.Address = address;

            return customer;
        }
        private void ResetSelect()
        {
            dataGridViewCustomers.ClearSelection();
            dataGridViewCustomers.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer editedCustomer = GetEditedCustomer();
            customerBusiness.Update(editedCustomer);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var item = dataGridViewCustomers.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                customerBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }
    }
}
