using System;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class ResetPassword : Form
    {
        UserBLL userBLL = new UserBLL();

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadLogin();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Check")
            {
                if (String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please enter username !!!");
                    txtUsername.Focus();
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
                else
                {
                    bool userStatus = userBLL.validateUser(txtUsername.Text, txtEmail.Text, txtContactNumber.Text);

                    if (userStatus)
                    {
                        txtUsername.Enabled = txtEmail.Enabled = txtContactNumber.Enabled = false;
                        txtNewPassword.Enabled = txtConfirmPassword.Enabled = true;
                        btnReset.Text = "Reset";
                        txtNewPassword.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct details !!!");
                        txtUsername.Clear();
                        txtEmail.Clear();
                        txtContactNumber.Clear();
                        txtUsername.Focus();
                        return;
                    }
                }
            }
            else if (btnReset.Text == "Reset")
            {
                if (String.IsNullOrEmpty(txtNewPassword.Text))
                {
                    MessageBox.Show("Please enter new password !!!");
                    txtNewPassword.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please confirm the password !!!");
                    txtConfirmPassword.Focus();
                    return;
                }
                else
                {
                    if (txtNewPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Password didn't match !!!");
                        txtNewPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtNewPassword.Focus();
                        return;
                    }
                    else
                    {
                        userBLL.resetUserPassword(txtUsername.Text, txtEmail.Text, txtContactNumber.Text, txtNewPassword.Text);
                        MessageBox.Show("Password reset successfully !!!");
                        this.Hide();
                        FormLoaderClass.loadLogin();
                        this.Close();
                    }
                }
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = txtConfirmPassword.Enabled = false;
        }
    }
}
