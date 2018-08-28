using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hostel
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            load_table();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        void load_table()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=1234";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("Select * from db.user1", conDatabase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 el = new Form5();
            el.ShowDialog();
        }
    }
}
