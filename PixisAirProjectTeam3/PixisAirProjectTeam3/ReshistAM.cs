using IBM.Data.DB2.iSeries;
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


//Anjelica Martinez
//Form uses load button to display all Reshist records in the list box
//pulled from the iBM i DB2 database

namespace PixisAirProjectTeam3
{
    public partial class ReshistAM : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public ReshistAM()
        {
            InitializeComponent();
        }

        private void loadBttn_Click(object sender, EventArgs e)
        {
            conn = new iDB2Connection();
            conn.ConnectionString = "DataSource=DEATHSTAR.GTC.EDU;";

            try
            {
                iDB2Command cmd = new iDB2Command("SELECT * FROM FLIGHT2025.RESHIST", conn);
                conn.Open();
                iDB2DataReader reader = cmd.ExecuteReader();
                DisplayListBox.Items.Clear(); // Clear previous items

                while (reader.Read())
                {
                    // Columns: 0-6, packed decimals at 1, 4, 5
                    string item = reader[0].ToString() + " - " +          
                                  reader.GetDecimal(1).ToString() + " - " +  
                                  reader[2].ToString() + " - " +          
                                  reader[3].ToString() + " - " +          
                                  reader.GetDecimal(4).ToString() + " - " +  
                                  reader.GetDecimal(5).ToString() + " - " + 
                                  reader[6].ToString();                   

                    DisplayListBox.Items.Add(item);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            string cmdString = @"
        INSERT INTO FLIGHT2025.RESHIST 
        (RESNO, CUSTNO, FLIGHTNO, ROUTENO, FLPRICE, TCOST, SEATNO) 
        VALUES 
        (@RESNO, @CUSTNO, @FLIGHTNO, @ROUTENO, @FLPRICE, @TCOST, @SEATNO)";

            try
            {
                using (iDB2Connection connection = new iDB2Connection(
                    "DataSource=DEATHSTAR.GTC.EDU;"))
                {
                    connection.Open();

                    using (iDB2Command cmd = new iDB2Command(cmdString, connection))
                    {
                        // CHAR/Text fields
                        cmd.Parameters.Add("@RESNO", iDB2DbType.iDB2Char).Value = resTxt.Text.Trim();
                        cmd.Parameters.Add("@FLIGHTNO", iDB2DbType.iDB2Char).Value = flightnoTxt.Text.Trim();
                        cmd.Parameters.Add("@ROUTENO", iDB2DbType.iDB2Char).Value = routenoTxt.Text.Trim();
                        cmd.Parameters.Add("@SEATNO", iDB2DbType.iDB2Char).Value = seatTxt.Text.Trim();

                        // Packed Decimal fields
                        cmd.Parameters.Add("@CUSTNO", iDB2DbType.iDB2Decimal).Value = decimal.Parse(custnoTxt.Text.Trim());
                        cmd.Parameters.Add("@FLPRICE", iDB2DbType.iDB2Decimal).Value = decimal.Parse(fllpTxt.Text.Trim());
                        cmd.Parameters.Add("@TCOST", iDB2DbType.iDB2Decimal).Value = decimal.Parse(ttlcTxt.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record added successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (FormatException fex)
            {
                MessageBox.Show($"Invalid number format: {fex.Message}", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
