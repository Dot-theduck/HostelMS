using System;
using System.Windows.Forms;

namespace HostelMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set PasswordTb to mask the input with '*' character
            PasswordTb.PasswordChar = '*';
        }

        private void Reset()
        {
            // Clear both username and password fields
            UnameTb.Text = "";
            PasswordTb.Text = "";  // Use .Text to clear the password input
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            // You can add additional behavior if needed when the password text changes
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Check if both username and password are entered
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please enter both Username and Password!!");
                Reset();
            }
            else if (UnameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                // If username is Admin and password is Admin, open the Dashboard form
                Dashboard Obj = new Dashboard();
                Obj.Show();
                this.Hide(); // Hide the login form
            }
            else if (UnameTb.Text == "Abigael" && PasswordTb.Text == "test123")
            {
                // If username is Abigael and password is test123, open the Abigael form
                Abigael Obj = new Abigael();
                Obj.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // If the username or password is incorrect
                MessageBox.Show("Incorrect Username or Password!!");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

       
    }
}
