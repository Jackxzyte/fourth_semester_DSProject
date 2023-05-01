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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace firstProject
{
    public partial class Main_window : Form
    {
        private String email;
        private String password;
        public String name;
        private int credits;
        private String connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn = null;
        public Main_window(String email, string password)
        {
            this.email = email;
            this.name = email.Replace("@gmail.com", "");
            this.password = password;
            conn = new SqlConnection(connString);
            InitializeComponent();
        }

        ~Main_window()
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Main_window_Load(object sender, EventArgs e)
        {
            otp.Visible = false;
            otpButton.Visible = false;
            status.Visible = false;
            depositInput.ForeColor = Color.Gray;
            depositInput.Text = "0";
            withdrawInput.ForeColor = Color.Gray;
            withdrawInput.Text = "0";
            greet.Text = "Welcome " + name + "!";
            credit.Text = "Credits : " + getCredit(email, password).ToString();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //wiithdraw
            int ip = Int32.Parse(withdrawInput.Text);
            credits = getCredit(email, password);
            credits -= ip;
            setCredits(email, password);
            status.Text = "";
            status.Text = "Withdrew";
            withdrawInput.Text = "0";
            withdrawInput.ForeColor = Color.Gray;
            otp.Visible = true;
            otpButton.Visible = true;
            status.Visible = true;
        }
        private void deposit_Click(object sender, EventArgs e)
        {
            //deposit
            int ip = Int32.Parse(depositInput.Text);
            credits = getCredit(email, password);
            credits += ip;
            setCredits(email, password);
            status.Text = "";
            status.Text = "Deposited";
            depositInput.Text = "0";
            depositInput.ForeColor = Color.Gray;
            otp.Visible = true;
            otpButton.Visible = true;
            status.Visible = true;
        }

        private void otpButton_Click(object sender, EventArgs e)
        {

        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //empty
        }

        public int getCredit(String email, String password) {
            int cred = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                String q = "select amount from Login where email = '" + email + "' and password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cred = Int32.Parse(dt.Rows[0][0].ToString());
            }
            return cred;
        }

        public void setCredits(String email, String password)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                //update credits
                try
                {
                    String q = "update Login set amount= " + credits.ToString() + " where email = '" + email + "' and password = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }catch (Exception ex) { status.Text = "Invalid Input Amount"; }
            }
            credit.Text = "Credits : " + getCredit(email, password).ToString();
        }

        private void depositInput_Enter(object sender, EventArgs e)
        {
            if(depositInput.Text == "0")
            {
                depositInput.Text = "";
                depositInput.ForeColor = Color.Black;
            }
        }

        private void depositInput_Leave(object sender, EventArgs e)
        {
            if(depositInput.Text == "")
            {
                depositInput.Text = "0";
                depositInput.ForeColor = Color.Gray;
            }
        }

        private void withdrawInput_Enter(object sender, EventArgs e)
        {
            if (withdrawInput.Text == "0")
            {
                withdrawInput.Text = "";
                withdrawInput.ForeColor = Color.Black;
            }
        }

        private void withdrawInput_Leave(object sender, EventArgs e)
        {
            if (withdrawInput.Text == "")
            {
                withdrawInput.Text = "0";
                withdrawInput.ForeColor = Color.Gray;
            }
        }
    }
}
