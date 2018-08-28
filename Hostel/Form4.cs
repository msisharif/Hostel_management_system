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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string myconnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myconn = new MySqlConnection(myconnection);
                MySqlDataAdapter mydataadapter = new MySqlDataAdapter();
                mydataadapter.SelectCommand = new MySqlCommand(" select * from db.employee ;", myconn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(mydataadapter);
                myconn.Open();
                DataSet ds = new DataSet();
                //MessageBox.Show("connected");
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string myconnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myconn = new MySqlConnection(myconnection);

                MySqlCommand selectcommand = new MySqlCommand("select * from db.employee where emp_id = '" + this.textBox1.Text + "' and emp_pass= '" + this.textBox2.Text + "' ;", myconn);

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
                    this.Hide();
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

