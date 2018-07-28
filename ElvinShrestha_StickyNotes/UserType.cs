using System;
using System.Data;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class UserType : Form
    {
        UserTypeBLL userTypeBLL = new UserTypeBLL();

        public UserType()
        {
            InitializeComponent();
        }

        private void loadUserTypes()
        {
            dgvUserType.DataSource = userTypeBLL.loadUserType();
        }

        private void btnAddUserType_Click(object sender, EventArgs e)
        {
            if (btnAddUserType.Text == "ADD")
            {
                if (String.IsNullOrEmpty(txtUserTypeName.Text))
                {
                    MessageBox.Show("Please enter user type name !!!");
                    txtUserTypeName.Focus();
                    return;
                }
                else
                {
                    bool userTypeStatus = userTypeBLL.verifyUserType(txtUserTypeName.Text);

                    if (userTypeStatus == false)
                    {
                        userTypeBLL.insertUserType(txtUserTypeName.Text);
                        loadUserTypes();
                        txtUserTypeName.Clear();
                        txtUserTypeName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User type already available !!!");
                        txtUserTypeName.Clear();
                        txtUserTypeName.Focus();
                        return;
                    }
                }
            }
            else if (btnAddUserType.Text == "UPDATE")
            {
                if (String.IsNullOrEmpty(txtUserTypeName.Text))
                {
                    MessageBox.Show("Please enter user type name !!!");
                    txtUserTypeName.Focus();
                    return;
                }
                else
                {
                    bool userTypeStatus = userTypeBLL.verifyUserType(txtUserTypeName.Text);

                    if (userTypeStatus == false)
                    {
                        userTypeBLL.updateUserType(userTypeCode, txtUserTypeName.Text);
                        btnAddUserType.Text = "ADD";
                        loadUserTypes();
                        txtUserTypeName.Clear();
                        txtUserTypeName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("User type already available !!!");
                        txtUserTypeName.Clear();
                        txtUserTypeName.Focus();
                        return;
                    }
                }
            }
        }

        private void UserType_Load(object sender, EventArgs e)
        {
            // header part
            UserBLL userBLL = new UserBLL();
            DataTable dataTable = userBLL.getUserDetails(FormLoaderClass._username);
            lblUserFullName.Text = dataTable.Rows[0][0].ToString() + " " + dataTable.Rows[0][1].ToString();
            lblUserType.Text = dataTable.Rows[0][2].ToString();

            loadUserTypes();
        }

        private void btnStickyNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }

        int userTypeCode;
        private void dgvUserType_Click(object sender, EventArgs e)
        {
            userTypeCode = int.Parse(dgvUserType.CurrentRow.Cells["userTypeId"].Value.ToString());
            int columnIndex = dgvUserType.CurrentCell.ColumnIndex;

            if (dgvUserType.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                btnAddUserType.Text = "UPDATE";
                DataTable dataTable = userTypeBLL.loadUserType(userTypeCode);

                txtUserTypeName.Text = dataTable.Rows[0][1].ToString();
            }
            else if (dgvUserType.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    userTypeBLL.deleteUserType(userTypeCode);
                    txtUserTypeName.Clear();
                    loadUserTypes();
                }
            }
        }
    }
}
