using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hostel
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myconnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myconn = new MySqlConnection(myconnection);

                MySqlCommand selectcommand = new MySqlCommand("update db.data set password='" + this.textBox3.Text + "' where username = '" + this.textBox1.Text + "';", myconn);

                MySqlDataReader myreader;
                myconn.Open();
                myreader = selectcommand.ExecuteReader();
                int count = 0;
                while (myreader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Password Changed Successfully.");
                }
                else
                {
                    MessageBox.Show("Password Changed Successfully.");

                }

                this.Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 el = new Form5();
            el.ShowDialog();
        }
    }
}
