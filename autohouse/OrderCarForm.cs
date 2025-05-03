using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;


namespace autohouse
{
    public partial class OrderCarForm : Form
    {
        private OrderCarBusiness orderCarBusiness;
        private CarBusiness carBusiness;
        private OrderBusiness orderBusiness;
        private List<Order_Car> orderCars;
        private List<CarBrand> cars;
        private List<Order> orders;
        private int editCarId = 0;
        private int editOrderId = 0;
        public OrderCarForm()
        {
            InitializeComponent();
            orderCarBusiness = new OrderCarBusiness();
            orderBusiness = new OrderBusiness();
            carBusiness = new CarBusiness();
        }

        private void OrderCarForm_Load(object sender, EventArgs e)
        {
            orderCars = orderCarBusiness.GetAll();
            cars = orderCarBusiness.GetAllCarBrand();
                
            orders = orderBusiness.GetAll();

            dataGridViewOrderCars.DataSource = orderCars;
            //dataGridViewOrderCars.Columns["OrderId"].Visible = true;
            //dataGridViewOrderCars.Columns["CarId"].Visible = true;
            //dataGridViewOrderCars.Columns["Quantity"].Visible = true;
            dataGridViewOrderCars.Columns["Car"].Visible = false;
            dataGridViewOrderCars.Columns["Order"].Visible = false;


            dataGridViewCars.DataSource = cars;
            //dataGridViewCars.Columns["Order_Cars"].Visible = false;

            dataGridViewOrders.DataSource = orders;
            dataGridViewOrders.Columns["Order_Cars"].Visible = false;
            dataGridViewOrders.Columns["Customer"].Visible = false;

            comboBoxCarId.DataSource = cars;
            comboBoxCarId.DisplayMember = "BrandName";
            comboBoxCarId.ValueMember = "Id";

            comboBoxOrderId.DataSource = orders;
            comboBoxOrderId.DisplayMember = "OrderId";
            comboBoxOrderId.ValueMember = "OrderId";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OrderCarForm.ActiveForm.Close();
        }
        private void UpdateGrid()
        {
            dataGridViewOrderCars.DataSource = orderCarBusiness.GetAll();
            dataGridViewOrderCars.ReadOnly = true;
          //  dataGridViewOrderCars.Columns["OrderCarId"].Visible = false;
            dataGridViewOrderCars.Columns["Car"].Visible = false;
            dataGridViewOrderCars.Columns["Order"].Visible = false;
            dataGridViewOrderCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void ClearTextBoxes()
        {
            textBoxQuantity.Text = "";
            comboBoxCarId.Text = "";
            comboBoxOrderId.Text = "";
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
            var quantity = int.Parse(textBoxQuantity.Text);
            var carId = int.Parse(comboBoxCarId.SelectedValue.ToString());
            var orderId = int.Parse(comboBoxOrderId.SelectedValue.ToString());

            Order_Car orderCar = new Order_Car();
            orderCar.Quantity = quantity;
            orderCar.CarId = carId;
            orderCar.OrderId = orderId;

            orderCarBusiness.Add(orderCar);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int orderId, int carId)
        {
            Order_Car update = orderCarBusiness.Get(orderId, carId);
            textBoxQuantity.Text = update.Quantity.ToString();
            comboBoxCarId.Text = update.CarId.ToString();
            comboBoxOrderId.Text = update.OrderId.ToString();
        }
        private void DisableSelect()
        {
            dataGridViewOrderCars.Enabled = false;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderCars.SelectedRows.Count > 0)
            {
                var item = dataGridViewOrderCars.SelectedRows[0].Cells;
                var orderId = int.Parse(item["OrderId"].Value.ToString());
                var carId = int.Parse(item["CarId"].Value.ToString());
                editOrderId = orderId;
                editCarId = carId;

                UpdateTextBoxes(orderId, carId);
                ToggleSaveUpdate();
                DisableSelect();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderCars.SelectedRows.Count > 0)
            {
                var item = dataGridViewOrderCars.SelectedRows[0].Cells;
                var orderId = int.Parse(item["OrderId"].Value.ToString());
                var carId = int.Parse(item["CarId"].Value.ToString());
                orderCarBusiness.Delete(orderId, carId);
                UpdateGrid();
                ResetSelect();
                ClearTextBoxes();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Order_Car editedOrderCar = GetEditedOrderCars();
            orderCarBusiness.Update(editedOrderCar);
            UpdateGrid();
        }

        private void dataGridViewOrderCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewOrderCars.CurrentRow.Selected = true;
            int carId = int.Parse(dataGridViewOrderCars.SelectedRows[0].Cells["CarId"].Value.ToString());
            comboBoxCarId.SelectedValue = carId;

            int orderId = int.Parse(dataGridViewOrderCars.SelectedRows[0].Cells["OrderId"].Value.ToString());
            comboBoxOrderId.SelectedValue = orderId;
            textBoxQuantity.Text = dataGridViewOrderCars.SelectedRows[0].Cells["Quantity"].Value.ToString();

        }
        private Order_Car GetEditedOrderCars()
        {
            Order_Car order_Car = new Order_Car();
            order_Car.Quantity = int.Parse(textBoxQuantity.Text);
            order_Car.CarId = editCarId;
            order_Car.OrderId = editOrderId;
            return order_Car;
        }
        private void ResetSelect()
        {
            dataGridViewOrderCars.ClearSelection();
            dataGridViewOrderCars.Enabled = true;
        }

        private void labelOrderCars_Click(object sender, EventArgs e)
        {

        }

        private void labelOrders_Click(object sender, EventArgs e)
        {

        }

        private void labelCars_Click(object sender, EventArgs e)
        {

        }
    }
}
