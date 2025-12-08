using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirProjectTeam3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            flightCustomers custForm = new flightCustomers();
            custForm.Show();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCar custForm = new AddCar();
            custForm.Show();
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReshist_Click(object sender, EventArgs e)
        {
            ReshistAM f = new ReshistAM();
            f.ShowDialog();
        }
    }
}
