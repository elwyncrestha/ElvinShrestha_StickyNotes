using System;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class Login : Form
    {
        UserBLL userBLL = new UserBLL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username !!!");
                txtUsername.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password !!!");
                txtPassword.Focus();
                return;
            }
            else
            {
                userBLL._username = txtUsername.Text;
                userBLL._password = txtPassword.Text;

                int userStatus = userBLL.validateUserLogin();
                if (userStatus == 1)
                {
                    // store username
                    FormLoaderClass._username = txtUsername.Text;

                    this.Hide();
                    FormLoaderClass.loadDashboard();
                    this.Close();
                }
                else if (userStatus == 0)
                {
                    MessageBox.Show("Invalid user !!!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else if (userStatus == 2)
                {
                    MessageBox.Show("User not activated by admin !!!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // addition to database tables
            userBLL.addBasicUserTypes();
            userBLL.addAdmin();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadResetPassword();
            this.Close();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadRegisterUser();
            this.Close();
        }
    }
}
