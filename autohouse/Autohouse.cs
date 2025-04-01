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
    }
}
