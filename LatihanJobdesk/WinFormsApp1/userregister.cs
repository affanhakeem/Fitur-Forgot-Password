using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class userregister : Form
    {
        public userregister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            welcomelogin wl = new welcomelogin();
            this.Hide();
            wl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter Ortu Name");
                return;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please Input Ortu Birth Day");
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;"))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Register VALUES (@username, @password, @namaortu, @hbdortu)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@username", textBox1.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@password", textBox2.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@namaortu", textBox4.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@hbdortu", dateTimePicker1.MaxDate));
                //conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Successfully Registred");
                }
                cmd.Dispose();
                conn.Close();

                bool iseg = false;
                if (iseg == true)
                {
                    MessageBox.Show("Successfully Login");
                    this.Hide();
                    welcomelogin wl = new welcomelogin();
                    wl.Show();
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//{
//    NpgsqlConnection conc = new NpgsqlConnection("Server = localhost;Port = 5432;Database = TugasUlul; User Id = postgres;Password = password123;");
//    conc.Open();
//    NpgsqlCommand concr = new NpgsqlCommand();
//    concr.Connection = conc;
//    concr.CommandText = "INSERT INTO menu_makanan (id_makanan, nama_makanan, harga_makanan) VALUES (@id_makanan, @nama_makanan, @harga_makanan)";
//    concr.CommandType = CommandType.Text;
//    concr.Parameters.Add(new NpgsqlParameter("@id_makanan", int.Parse(textBox1.Text)));
//    concr.Parameters.Add(new NpgsqlParameter("@nama_makanan", textBox2.Text));
//    concr.Parameters.Add(new NpgsqlParameter("@harga_makanan", int.Parse(textBox3.Text)));
//    concr.ExecuteNonQuery();

//    conc.Close();
//    MessageBox.Show("Data Baru Telah Dimasukkan!");
//}

