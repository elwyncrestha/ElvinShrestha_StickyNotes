using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class UserDetails : Form
    {
        int userId;

        UserBLL userBLL = new UserBLL();

        public UserDetails()
        {
            InitializeComponent();
        }

        
        private void UserDetails_Load(object sender, EventArgs e)
        {
            panelUserDetails.Enabled = btnUpdate.Enabled = false;

            DataTable dataTable = userBLL.loadUsers(FormLoaderClass._username);
            userId = int.Parse(dataTable.Rows[0][0].ToString());
            txtFirstName.Text = dataTable.Rows[0][1].ToString();
            txtLastName.Text = dataTable.Rows[0][2].ToString();
            dtpDOB.Text = dataTable.Rows[0][3].ToString();
            txtAddress.Text = dataTable.Rows[0][4].ToString();
            txtContactNumber.Text = dataTable.Rows[0][5].ToString();
            txtEmail.Text = dataTable.Rows[0][6].ToString();
            txtUsername.Text = dataTable.Rows[0][7].ToString();
        }

        private void btnEditSwitch_Click(object sender, EventArgs e)
        {
            if(btnEditSwitch.Text == "Disabled")
            {
                btnEditSwitch.Text = "Enabled";
                btnEditSwitch.BackColor = Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
                panelUserDetails.Enabled = btnUpdate.Enabled = true;
            }
            else if (btnEditSwitch.Text == "Enabled")
            {
                btnEditSwitch.Text = "Disabled";
                btnEditSwitch.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
                panelUserDetails.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                if (usernameAvailibilty || txtUsername.Text == FormLoaderClass._username)
                {
                    userBLL._firstName = txtFirstName.Text;

                    userBLL._lastName = txtLastName.Text;

                    userBLL._dob = dtpDOB.Text;

                    userBLL._address = txtAddress.Text;

                    userBLL._email = txtEmail.Text;

                    userBLL._contactNumber = txtContactNumber.Text;

                    userBLL._username = txtUsername.Text;

                    userBLL.updateUser(userId);
                    FormLoaderClass._username = userBLL._username;   // for updating username

                    MessageBox.Show("User updated successfully !!!");
                    this.Hide();
                    FormLoaderClass.loadStickyNotes();
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

        private void lnkBackToStickyNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }
    }
}
