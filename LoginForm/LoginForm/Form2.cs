using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Form2 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LENOVO-PARS;Initial Catalog=logindb;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameField.Text;
                string password = passwordField.Text;
                string email = emailField.Text;
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO accounts (username,password,email) VALUES (@username,@password,@email)";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Registration Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please try again. " + ex.Message);
            }
            connection.Close();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Visible = true;
            this.Close();
        }
    }
}
