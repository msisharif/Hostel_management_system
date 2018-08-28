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
    public partial class Form13 : Form
    {
        private MySqlDataReader myReader;

        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=1234";
            string Query = "insert into db.user1 values ('" + this.textBox1.Text + "', '" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + "employee" + "','" + this.textBox2.Text + "', '" + this.textBox3.Text + "' );";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string myconnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myconn = new MySqlConnection(myconnection);

                MySqlCommand selectcommand1 = new MySqlCommand("update db.seat set avalability='" + "invalid" + "' where seat_id = '" + this.textBox6.Text + "';", myconn);

                MySqlDataReader myreader1;
                myconn.Open();
                myreader1 = selectcommand1.ExecuteReader();

                int count = 0;
                while (myreader1.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    //MessageBox.Show("");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f9 = new Form5();
            f9.ShowDialog();
        }
    }
}
