using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirProjectTeam3
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCarId.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtCarId.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCarId.Text.Trim() == "" || txtMake.Text.Trim() == "" || txtModel.Text.Trim() == "")
            {
                MessageBox.Show("Please make sure to enter info in all boxes.");
                return;
            }

            try
            {
                using (iDB2Connection conn = new iDB2Connection("DataSource=deathstar.gtc.edu;DefaultCollection=FLIGHT2025;"))
                {
                    conn.Open();

                    string sql = "INSERT INTO CARS (ID, MAKE, MODEL) VALUES (@id, @make, @model)";

                    using (iDB2Command cmd = new iDB2Command(sql, conn))
                    {
                        cmd.Parameters.Add("@id", iDB2DbType.iDB2Decimal).Value = Convert.ToInt32(txtCarId.Text.Trim());
                        cmd.Parameters.Add("@make", iDB2DbType.iDB2VarChar).Value = txtMake.Text.Trim();
                        cmd.Parameters.Add("@model", iDB2DbType.iDB2VarChar).Value = txtModel.Text.Trim();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
