using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace autohouse
{
    public partial class CarForm : Form
    {
        private CarBusiness carBusiness;
        private BrandBusiness brandBusiness;
        public CarForm()
        {
            InitializeComponent();
            carBusiness = new CarBusiness();
            brandBusiness = new BrandBusiness();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

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
    }
}
