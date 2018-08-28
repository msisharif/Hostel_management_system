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
    public partial class Form14 : Form
    {
        private MySqlDataReader myReader;

        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=1234";
            string Query = "insert into db.employee values ('" + this.textBox1.Text + "', '" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox2.Text + "', '" + null + "','" + null + "' );";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f9 = new Form3();
            f9.ShowDialog();
        }
    }
}
