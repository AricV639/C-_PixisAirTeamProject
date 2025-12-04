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
                while (reader.Read())
                {

                    DisplayListBox.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));

                }

            }
            catch (Exception ex)
            {
                DisplayListBox.Items.Add(ex.Message);
            }
        }
    }
}
