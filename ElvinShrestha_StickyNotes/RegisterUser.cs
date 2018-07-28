using System;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class RegisterUser : Form
    {
        UserBLL userBLL = new UserBLL();

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadLogin();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name !!!");
                txtFirstName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name !!!");
                txtLastName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter address !!!");
                txtAddress.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter email address !!!");
                txtEmail.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtContactNumber.Text))
            {
                MessageBox.Show("Please enter contact number !!!");
                txtContactNumber.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username !!!");
                txtUsername.Focus();
                return;
            }
            else
            {
                bool usernameAvailibilty = userBLL.isUsernameAvailable(txtUsername.Text);

                if (usernameAvailibilty)
                {
                    userBLL._firstName = txtFirstName.Text;

                    userBLL._lastName = txtLastName.Text;

                    userBLL._dob = dtpDOB.Text;

                    userBLL._address = txtAddress.Text;

                    userBLL._email = txtEmail.Text;

                    userBLL._contactNumber = txtContactNumber.Text;

                    userBLL._username = txtUsername.Text;

                    Service service = new ServiceImpl();
                    userBLL._password = service.getRandomCode(10);

                    userBLL.insertUser();
                    MessageBox.Show("Your password is: " + userBLL._password);

                    this.Hide();
                    FormLoaderClass.loadLogin();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already taken !!!" + "\nChoose another username");
                    txtUsername.Clear();
                    txtUsername.Focus();
                    return;
                }
            }
        }
    }
}
