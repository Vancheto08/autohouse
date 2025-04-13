using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autohouse
{
    public partial class OrderForm : Form
    {
        private OrderBusiness orderBusiness;
        private CustomerBusiness customerBusiness;
        private List<Order> orders;
        private List<Customer> customers;
        private int editId = 0;
        public OrderForm()
        {
            InitializeComponent();
            orderBusiness = new OrderBusiness();
            customerBusiness = new CustomerBusiness();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            orders = orderBusiness.GetAll();
            customers = customerBusiness.GetAll();

            dataGridViewOrders.DataSource = orders;
            dataGridViewOrders.Columns["CustomerId"].Visible = true;
            dataGridViewOrders.Columns["OrderId"].Visible = false;
            dataGridViewOrders.Columns["Customer"].Visible = false;

            dataGridViewCustomers.DataSource = customers;
            dataGridViewCustomers.Columns["CustomerId"].Visible = true;
            dataGridViewCustomers.Columns["Orders"].Visible = false;

            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "CustomerId";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OrderForm.ActiveForm.Close();
        }
        private void UpdateGrid()
        {
            dataGridViewOrders.DataSource = orderBusiness.GetAll();
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.Columns["OrderId"].Visible = false;
            dataGridViewOrders.Columns["Customer"].Visible = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ClearTextBoxes()
        {
            comboBoxPaymentMethod.Text = "";
            textBoxShippingAddress.Text = "";
            dateTimePickerDate.Text = "";
            comboBoxCustomer.Text = "";
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var shippingAddress = textBoxShippingAddress.Text;
            var paymentMethod = comboBoxPaymentMethod.Text;
            var customerId = int.Parse(comboBoxCustomer.SelectedValue.ToString());
            var date = dateTimePickerDate.Value;

            Order order = new Order();
            order.PaymentMethod = paymentMethod;
            order.ShippingAddress = shippingAddress;
            order.OrderDate = date;
            order.CustomerId = customerId;

            orderBusiness.Add(order);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Order update = orderBusiness.Get(id);
            textBoxShippingAddress.Text = update.ShippingAddress.ToString();
            comboBoxPaymentMethod.Text = update.PaymentMethod.ToString();
            dateTimePickerDate.Value = update.OrderDate;
        }
        private void DisableSelect()
        {
            dataGridViewOrders.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var item = dataGridViewOrders.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrders.CurrentRow.Selected = true;

            int customerId = int.Parse(dataGridViewOrders.SelectedRows[0].Cells["CustomerId"].Value.ToString());
            comboBoxCustomer.SelectedValue = customerId;
            textBoxShippingAddress.Text = dataGridViewOrders.SelectedRows[0].Cells["ShippingAddress"].Value.ToString();
            comboBoxPaymentMethod.Text = dataGridViewOrders.SelectedRows[0].Cells["PaymentMethod"].Value.ToString();
            dateTimePickerDate.Text = dataGridViewOrders.SelectedRows[0].Cells["OrderDate"].Value.ToString();
        }
        private Order GetEditedOrders()
        {
            Order order = new Order();
            order.OrderId = editId;
            order.PaymentMethod = comboBoxPaymentMethod.Text;
            order.ShippingAddress = textBoxShippingAddress.Text;
            order.OrderDate = dateTimePickerDate.Value;
            order.CustomerId = int.Parse(comboBoxCustomer.SelectedValue.ToString());
            return order;
        }
        private void ResetSelect()
        {
            dataGridViewOrders.ClearSelection();
            dataGridViewOrders.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Order editedOrder = GetEditedOrders();
            orderBusiness.Update(editedOrder);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var item = dataGridViewOrders.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                orderBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
                ClearTextBoxes();
            }
        }
    }
}
