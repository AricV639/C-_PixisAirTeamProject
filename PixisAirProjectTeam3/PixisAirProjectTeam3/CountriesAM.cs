using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Anjelica Martinez
//Form uses load button to display all Country records in the list box
//pulled from the iBM i DB2 database

namespace PixisAirProjectTeam3
{
    public partial class CountriesAM : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public CountriesAM()
        {
            InitializeComponent();
        }

        private void CountriesAM_Load(object sender, EventArgs e)
        {

        }

        private void loadBttn_Click(object sender, EventArgs e)
        {
            conn = new iDB2Connection();
            conn.ConnectionString = "DataSource=DEATHSTAR.GTC.EDU;";

            try { 
            iDB2Command cmd = new iDB2Command("SELECT * FROM FLIGHT2025.COUNTRY", conn);
                conn.Open();
                iDB2DataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                
                    DisplayListBox.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));

                }

            }
            catch(Exception ex){
                DisplayListBox.Items.Add(ex.Message);
            }

        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            string cmdString = "INSERT INTO FLIGHT2025.COUNTRY (CNCD, CNNM) VALUES (@CNCD, @CNNM)";

            try
            {
                using (iDB2Connection connection = new iDB2Connection(
                    "DataSource=DEATHSTAR.GTC.EDU"))
                {
                    connection.Open();

                    using (iDB2Command cmd = new iDB2Command(cmdString, connection))
                    {
                        cmd.Parameters.Add("CNCD", iDB2DbType.iDB2Char).Value =
                            txtCountryCode.Text.Trim();

                        cmd.Parameters.Add("CNNM", iDB2DbType.iDB2VarChar).Value =
                            txtCountryName.Text.Trim();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record added successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
