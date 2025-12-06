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
    public partial class Customers : Form
    {
        iDB2Connection connection;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cmdString = "INSERT INTO CUSTOMERS VALUES(@CUSTNO,@CFNAME,@CLNAME,@CADDR,@CCITY,@CSTATE,@CZIP,@CPHONE,@CEMAIL,@CDOB,@CGENDER,@CPWORD)";

            try 
            { 
                connection = new iDB2Connection("DataSource=deathstar.gtc.edu");
                connection.Open();

                iDB2Command cmd = new iDB2Command(cmdString, connection);
                cmd.DeriveParameters();
                cmd.Parameters["@CUSTNO"].Value = 111111111;
                cmd.Parameters["@CFNAME"].Value = "John";
                cmd.Parameters["@CLNAME"].Value = "Doe";
                cmd.Parameters["@CADDR"].Value = "123 Main Street";
                cmd.Parameters["@CCITY"].Value = "Chicago";
                cmd.Parameters["@CSTATE"].Value = "IL";
                cmd.Parameters["@CZIP"].Value = 22222;
                cmd.Parameters["@CPHONE"].Value = 3333333333;
                cmd.Parameters["@CEMAIL"].Value = "johndoe@gmail.com";
                cmd.Parameters["@CDOB"].Value = 01012000;
                cmd.Parameters["@CGENDER"].Value = "Male";
                cmd.Parameters["@CPWORD"].Value = "password";

                cmd.ExecuteNonQuery();
                connection.Close();
                label1.Text = "Database updated!";

            }

            catch { label1.Text = "Database not updated."; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
