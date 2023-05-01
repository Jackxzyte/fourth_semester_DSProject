using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Net.Mail;

namespace firstProject
{
    public partial class ds_lab_project : Form
    {
        private String connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn = null;
        public ds_lab_project()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        ~ds_lab_project()
        {
            if (conn != null) { 
                conn.Close();
            }
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "gmail";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "password";
            textBox2.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //register
            String email = textBox1.Text, password = textBox2.Text;
            if (validate(email, password))
            {
                if (!check(email, password))
                {
                    //insert into table
                    String q = "insert into Login (email,password,amount) values ('" + email + "','" + password + "' ,-1000)";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    q = "select count(*) from Login where email = '" + email + "' and password = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(q, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        label4.Text = "Account registered, Login";
                        try { conn.Close(); }
                        catch (Exception ex) { label4.Text = ex.ToString(); }
                    }
                    else 
                    {
                        label4.Text = "";
                        label4.Text = "Some error occured";
                    }
                }
                else
                {
                    label4.Text = "";
                    label4.Text = "Account already exists";
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "gmail")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "gmail";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login
            String email = textBox1.Text, password = textBox2.Text;
            if (validate(email, password))
            {
                if (check(email, password))
                {
                    this.Hide();
                    label4.Text = "Logged-in";
                    //send email? yes
                    //sendEmail(email);
                    Main_window main = new Main_window(email, password);
                    main.Show();
                }
                else
                {
                    label4.Text = "Invalid email or passowrd , Register?";
                }
            }
        }

        public bool validate(string email, string password)
        {
            if (email.Equals("") || password.Equals(""))
            {
                label4.Text = "Fields cannot be empty";
                return false;
            }
            else label4.Text = "";
            if (!(email.Contains("@gmail.com")))
            {
                label4.Text = "Enter a gmail ID";
                return false;
            }
            else label4.Text = "";
            if (email.Length < 12)
            {
                label4.Text = "Invalid email";
                return false;
            }
            else label4.Text = "";
            if (password.Length < 9 || password.Length > 14) {
                label4.Text = "Password must be between 8 and 13 chars";
                return false;
            }
            else label4.Text = "";
            return true;
        }

        private bool check(string email, string password)
        {
            //querry
            String q = "select count(*) from Login where email = '" + email + "' and password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                try{ conn.Close(); }
                catch (Exception ex) { Console.Write(ex); }
                return true; 
            }
            return false;
        }

        public bool sendEmail(String email)
        {
            string senderEmail = "jackzyte@gmail.com";
            string senderPassword = "jniqekhafpggikfx";

            Random random = new Random();
            string otp = random.Next(100000, 999999).ToString();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
                client.EnableSsl = true;

                mail.From = new MailAddress(senderEmail);
                mail.To.Add(email);
                mail.Subject = "OTP for authentication";
                mail.Body = "Your OTP is " + otp;
                Console.WriteLine(otp);
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
