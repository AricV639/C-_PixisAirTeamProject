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
    public partial class flightCustomers : Form
    {
        public flightCustomers()
        {
            InitializeComponent();
        }

        private void btnShowCust_Click(object sender, EventArgs e)
        {
            string connString = "DataSource=deathstar.gtc.edu;DefaultCollection=FLIGHT2025;";

            try
            {
                using (iDB2Connection conn = new iDB2Connection(connString))
                {
                    conn.Open();

                    string flightNum = txtFlightNum.Text.Trim();
                    if (string.IsNullOrEmpty(flightNum))
                    {
                        MessageBox.Show("Please enter Flight Number.");
                        return;
                    }

                    string query = "SELECT C.CUSTNO, C.CFNAME, C.CLNAME " +
                                   "FROM RESRVTN R " +
                                   "JOIN CUSTOMER C ON R.CUSTNO = C.CUSTNO " +
                                   "WHERE R.FLIGHTNO = @flightNumber";

                    using (iDB2Command cmd = new iDB2Command(query, conn))
                    {
                        cmd.Parameters.Add("@flightNumber", iDB2DbType.iDB2VarChar).Value = flightNum;

                        using (iDB2DataReader reader = cmd.ExecuteReader())
                        {
                            listBoxCust.Items.Clear();

                            if (!reader.HasRows)
                            {
                                listBoxCust.Items.Add("No customers found for this flight.");
                                return;
                            }

                            while (reader.Read())
                            {
                                string custInfo = $"{reader["CFNAME"]} {reader["CLNAME"]} - ID: {reader["CUSTNO"]}";
                                listBoxCust.Items.Add(custInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxCust.Items.Clear();
            txtFlightNum.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
