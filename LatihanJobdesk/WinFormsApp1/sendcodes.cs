using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection.PortableExecutable;

namespace WinFormsApp1
{
    public partial class sendcodes : Form
    {
        string randomcode;
        public static string to;
        public sendcodes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string namaortu = textBox1.Text;
            //DateTime selectedDateTime = dateTimePicker1.Value;

            //string connectionString = "Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;";
            //using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT COUNT(*) from register WHERE namaortu = @namaortu AND hbdortu = @hbdortu";
            //    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@namaortu", namaortu);
            //        command.Parameters.AddWithValue("@hbdortu", hbdortu);
            //        //Convert.ToInt64(command.ExecuteScalar());
            //        int count = (int)command.ExecuteScalar();
            //    }
            //    bool iseg = false;
            //    if (iseg == true)
            //    {
            //        MessageBox.Show("Authentication Correct");
            //        this.Hide();
            //        forgotpassword fp = new forgotpassword();
            //        fp.Show();
            //    }
            //}
            bool iseg = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
            NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT namaortu, hbdortu FROM Register", conn);
            conn.Open();
            NpgsqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                string namaortu = read["namaortu"].ToString();
                DateTime selectedDateTime = dateTimePicker1.Value;
                if (textBox1.Text.Equals(namaortu) && dateTimePicker1.Value.Equals(selectedDateTime))
                {
                    iseg = true;
                }
            }
            conn.Close();
            if (iseg == true)
            {
                this.Hide();
                forgotpassword fp = new forgotpassword();
                fp.Show();
            }
            else if (iseg == false)
            {
                MessageBox.Show("Ortu Name or HBD Ortu is Incorrect");
            }
        }

        //bool iseg = false;
        //NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = LatihanJobdesk; User Id = postgres; Password = Affanboy_31;");
        //NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT nama, tanggal_lahir FROM register", conn);
        //conn.Open();
        //NpgsqlDataReader read = cmd.ExecuteReader();



        //while (read.Read())
        //{
        //    string usn = read["username"].ToString();
        //    string name = read["namaortu"].ToString();
        //    string tglhr = read["hbdortu"].ToString();
        //    if (textBox1.Text.Equals(name) && textBox3.Text.Equals(usn) && dateTimePicker1.Equals(tglhr))
        //    {
        //        iseg = true;
        //    }
        //}
        //conn.Close();
        //if (iseg == true)
        //{
        //    MessageBox.Show("Successfully Sending Code");
        //    this.Hide();
        //    enteremail enem = new enteremail();
        //    enem.Show();
        //}
        //else if (iseg == false)
        //{
        //    MessageBox.Show("Data is Invalid");
        //}

        //string messagebody;
        //Random rand = new Random();
        //randomcode = (rand.Next(999999)).ToString();
        //to = (textBox1.Text).ToString();
        //messagebody = $"Your Reset Code is {randomcode}";
        //try
        //{
        //    smtp.Send(message);
        //    MessageBox.Show("Code Successfully Send");
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}


        //{
        //    if (textBox1.Text == "")
        //    {
        //        MessageBox.Show("Please Enter Email");
        //        return;
        //    }

        //    string from, pass, messagebody;
        //    Random rand = new Random();
        //    randomcode = (rand.Next(999999)).ToString();
        //    MailMessage message = new MailMessage();
        //    to = (textBox1.Text).ToString();
        //    from = "rembanganvacation@gmail.com";
        //    pass = "Rembangan123";
        //    messagebody = $"Your Reset Code is {randomcode}";
        //    message.To.Add(to);
        //    message.From = new MailAddress(from);
        //    message.Body = messagebody;
        //    message.Subject = "Password Reset Code";
        //    SmtpClient smtp = new SmtpClient("smtp@gmail.com");
        //    smtp.EnableSsl = true;
        //    smtp.Port = 587;
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    smtp.Credentials = new NetworkCredential(from, pass);
        //    try
        //    {
        //        smtp.Send(message);
        //        MessageBox.Show("Code Successfully Send");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    string fromMail = "thedotnetchannelsender22@gmail.com";
        //    string fromPassword = "";
        //    MailMessage message = new MailMessage();
        //    message.From = new MailAddress(fromMail);
        //    message.Subject = "Test Subject";
        //    message.To.Add(new MailAddress("thedotnetchannelreceiver22@gmail.com"));
        //    message.Body = "<html><body> Test Body </body></html>";
        //    message.IsBodyHtml = true;

        //    var smtpClient = new SmtpClient("smtp.gmail.com")
        //    {
        //        Port = 587,
        //        Credentials = new NetworkCredential(fromMail, fromPassword),
        //        EnableSsl = true,
        //    };
        //    smtpClient.Send(message);
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomelogin wl = new welcomelogin();
            wl.Show();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (randomcode == (textBox2.Text).ToString())
        //    {
        //        to = textBox1.Text;
        //        resetpassword rp = new resetpassword();
        //        this.Hide();
        //        rp.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Wrong Code");
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendcodes_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;
        }
    }
}

