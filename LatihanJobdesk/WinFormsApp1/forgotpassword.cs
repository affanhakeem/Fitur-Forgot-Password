using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }

        private void forgotpassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            forgotmethods fm = new forgotmethods();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Your Username");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter New Password");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter Confirm Password");
                return;
            }
            //string username, password;
            //username = textBox2.Text;
            //password = textBox4.Text;
            //if (textBox3.Text == textBox4.Text)
            //{
            //    NpgsqlConnection conn = new NpgsqlConnection(@"Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
            //    string q = "update [Register] set [Password] = '" + password + "' where  Username = '" + username + "' ";
            //    NpgsqlCommand cmd = new NpgsqlCommand(q, conn);
            //    cmd.Connection = conn;
            //    conn.Open();
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        MessageBox.Show("Password Successfully Changed");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sorry Your Details Are Incorrect");
            //    }
            //    conn.Close();
            //}
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Your New Password and Confirm Password Is Not Match");
                return;
            }

            //bool iseg = false;
            //NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
            //NpgsqlCommand cmd = new NpgsqlCommand(@"UPDATE register SET password = @password", conn);
            //cmd.Parameters.AddWithValue("@password", "password");
            //conn.Open();
            ////NpgsqlDataReader read = cmd.ExecuteReader();
            //NpgsqlDataReader update = cmd.ExecuteReader();


            //while (update.Read())
            //{
            //    string psw = update["Password"].ToString();
            //    if (textBox3.Text.Equals(psw) && textBox4.Text.Equals(psw))
            //    {
            //        iseg = true;
            //    }
            //}
            //conn.Close();
            //if (iseg == true)
            //{
            //    MessageBox.Show("Successfully Changed Password");
            //    this.Hide();
            //    welcomelogin wl = new welcomelogin();
            //    wl.Show();
            //}

            //NpgsqlConnection cone = new NpgsqlConnection("Server = localhost;Port = 5432;Database = TugasUlul; User Id = postgres;Password = password123;");
            //cone.Open();
            //NpgsqlCommand conup = new NpgsqlCommand();
            //conup.Connection = cone;
            //conup.CommandText = "UPDATE menu_makanan SET nama_makanan = (@nama_makanan), harga_makanan = (@harga_makanan) WHERE id_makanan = @id_makanan";
            //conup.CommandType = CommandType.Text;
            //conup.Parameters.Add(new NpgsqlParameter("@id_makanan", int.Parse(textBox1.Text)));
            //conup.Parameters.Add(new NpgsqlParameter("@nama_makanan", textBox2.Text));
            //conup.Parameters.Add(new NpgsqlParameter("@harga_makanan", int.Parse(textBox3.Text)));
            //conup.ExecuteNonQuery();
            //conup.Dispose();
            //cone.Close();
            //MessageBox.Show("Data Telah Ter-Update!");

            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost;Port = 5432;Database = LatihanJobdesk; User Id = postgres;Password = password123;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE register SET password = (@password) WHERE username = @username";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@username", textBox1.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@password", textBox3.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@password", textBox4.Text));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Successfully Changed Password");

            welcomelogin wl = new welcomelogin();
            this.Hide();
            wl.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
