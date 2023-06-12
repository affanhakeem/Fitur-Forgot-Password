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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class resetpassword : Form
    {
        string email = sendcodes.to;
        public resetpassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetpassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcomelogin wl = new welcomelogin();
            this.Hide();
            wl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (textBox1.Text == password)
            {
                NpgsqlConnection conn = new NpgsqlConnection(@"Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
                string q = "update [Register] set [Password] = '" + password + "' where Email = '" + email + "' ";
                NpgsqlCommand cmd = new NpgsqlCommand(q, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Password Successfully Changed");
            }
            else
            {
                MessageBox.Show("Sorry Your Your New Password and Confirm Password Are Not Match");
            }
        }
    }
}
