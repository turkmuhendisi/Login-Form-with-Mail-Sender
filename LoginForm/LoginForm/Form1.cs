using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace LoginForm
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LENOVO-PARS;Initial Catalog=logindb;Integrated Security=True;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private bool userValidation(string username, string password)
        {
      
            try
            {
                cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM accounts";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (username == reader["username"].ToString() && password == reader["password"].ToString())
                    {
                        connection.Close();
                        return true;
                    }
                }
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameField.Text;
            String password = passwordField.Text;
            if (userValidation(username, password)) MessageBox.Show("Connection Successfully");
            else MessageBox.Show("User not found! Please try again.");
        }

        private string getPassword(string email)
        {
            cmd = new SqlCommand();   
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM accounts WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string password = reader["password"].ToString();
                connection.Close();
                return password;
            }
            cmd.Parameters.Clear();
            connection.Close();
            return "ERROR";

        }
        
        private void emailSender(string email)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "ja***er*@gmail.com";
            string smtpPassword = "***secret***";

            // Sender and Receiver
            string fromEmail = "ja***er*@gmail.com";
            string toEmail = email;

            // Create Message
            MailMessage mail = new MailMessage(fromEmail, toEmail);
            mail.Subject = "Your password";
            mail.Body = getPassword(email);

            // SMTP Configurations
                SmtpClient smtpClient = new SmtpClient(smtpServer);
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                // Send Message
                try
                {
                    smtpClient.Send(mail);
                    Console.WriteLine("E-mail successfully sent");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while sending E-mail: " + ex.Message);
                }
        }


        private void forgotPasswordLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emailField.Visible = true;
            emailLbl.Visible = true;
            sendEmailBtn.Visible = true;
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            emailSender(email);
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
