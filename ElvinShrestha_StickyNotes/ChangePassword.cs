using System;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void lnkBackToStickyNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show("Please enter old password !!!");
                txtOldPassword.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter new password !!!");
                txtNewPassword.Focus();
                return;
            }
            else if(String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm the password !!!");
                txtConfirmPassword.Focus();
                return;
            }
            else
            {
                UserBLL userBLL = new UserBLL();
                userBLL._username = FormLoaderClass._username;
                userBLL._password = txtOldPassword.Text;
                int userStatus = userBLL.validateUserLogin();

                if(userStatus == 1)
                {
                    userBLL.resetUserPassword(userBLL._username, txtNewPassword.Text);
                    MessageBox.Show("Password changed successfully !!!");
                    this.Hide();
                    FormLoaderClass.loadStickyNotes();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter correct old password !!!");
                    txtOldPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtOldPassword.Focus();
                    return;
                }
            }
        }

        
    }
}
