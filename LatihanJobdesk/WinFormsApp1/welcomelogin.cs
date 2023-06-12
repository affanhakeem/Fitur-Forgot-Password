using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class welcomelogin : Form
    {
        public welcomelogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            userregister ure = new userregister();
            this.Hide();
            ure.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sendcodes sc = new sendcodes();
            this.Hide();
            sc.Show();
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

            bool iseg = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
            NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT Username, Password FROM Register", conn);
            conn.Open();
            NpgsqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                string usn = read["Username"].ToString();
                string psw = read["Password"].ToString();
                if (textBox1.Text.Equals(usn) && textBox2.Text.Equals(psw))
                {
                    iseg = true;
                }
            }
            conn.Close();
            if (iseg == true)
            {
                MessageBox.Show("Successfully Login");
                this.Hide();
                enteremail enem = new enteremail();
                enem.Show();
            }
            else if (iseg == false)
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
    }
}
