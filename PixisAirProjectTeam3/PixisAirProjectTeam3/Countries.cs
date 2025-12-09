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
using IBM.Data.DB2.iSeries;

namespace PixisAirProjectTeam3
{
    public partial class Countries : Form
    {
        iDB2Connection connection;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public Countries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cmdString = "INSERT INTO COUNTRY VALUES(@CNCD,@CNNM)";

            try
            {
                connection = new iDB2Connection("DataSource=10.250.0.30");
                connection.Open();

                iDB2Command cmd = new iDB2Command(cmdString, connection);
                cmd.DeriveParameters();
                cmd.Parameters["@CNCD"].Value = "TQ";
                cmd.Parameters["@CNNM"].Value = "Transelvania";
                cmd.ExecuteNonQuery();
                connection.Close();

                label1.Text = "Database Updated!";

            }
            catch (Exception ex) { label1.Text = ex.Message; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
