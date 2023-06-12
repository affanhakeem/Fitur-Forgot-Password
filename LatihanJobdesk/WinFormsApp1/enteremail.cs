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
    public partial class enteremail : Form
    {
        public enteremail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcomelogin wl = new welcomelogin();
            this.Hide();
            wl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email;
            email = textBox1.Text;
            NpgsqlConnection conn = new NpgsqlConnection(@"Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
            string q = "DELETE FROM Register where Email = '"+email+"'";
            NpgsqlCommand cmd = new NpgsqlCommand(q, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show($"{email} Record Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Sorry Your Email Is Incorrect");
            }
            conn.Close();
        }
    }
}
