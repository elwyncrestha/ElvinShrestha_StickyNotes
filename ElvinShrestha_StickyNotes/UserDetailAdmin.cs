using System;
using System.Data;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class UserDetailAdmin : Form
    {
        UserBLL userBLL = new UserBLL();

        public UserDetailAdmin()
        {
            InitializeComponent();
        }

        private void lnkBackToStickyNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }

        private void loadUsersDGV()
        {
            int formWidth = this.Width;
            dgvUser.Width = formWidth - 80;
            dgvUser.DataSource = userBLL.loadAllUsers();
        }

        private void loadUserType()
        {
            UserTypeBLL userTypeBLL = new UserTypeBLL();
            cboUserType.DataSource = userTypeBLL.loadUserType();
            cboUserType.DisplayMember = "userTypeName";
            cboUserType.ValueMember = "userTypeId";
        }

        private void UserDetailAdmin_Load(object sender, EventArgs e)
        {
            loadUsersDGV();
            loadUserType();
        }

        int userCode;
        private void dgvUser_Click(object sender, EventArgs e)
        {
            userCode = int.Parse(dgvUser.CurrentRow.Cells["userId"].Value.ToString());
            int columnIndex = dgvUser.CurrentCell.ColumnIndex;

            if (dgvUser.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dataTable = userBLL.loadUserForAdmin(userCode);
                // load full name
                lblFullName.Text = dataTable.Rows[0][0].ToString();

                // load user type
                int userTypeId = int.Parse(dataTable.Rows[0][1].ToString());
                UserTypeBLL userTypeBLL = new UserTypeBLL();
                DataTable dtUserType = userTypeBLL.loadUserType(userTypeId);
                String userTypeName = dtUserType.Rows[0][1].ToString();
                cboUserType.SelectedIndex = cboUserType.FindStringExact(userTypeName);

                // load activation status
                if (dataTable.Rows[0][2].ToString() == "True")
                {
                    rdoActive.Checked = true;
                    rdoInactive.Checked = false;
                }
                else
                {
                    rdoActive.Checked = false;
                    rdoInactive.Checked = true;
                }
            }
            else if (dgvUser.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userBLL.deleteUser(userCode);
                    loadUsersDGV();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!rdoActive.Checked && !rdoInactive.Checked)
            {
                MessageBox.Show("Please choose activation status !!!");
                return;
            }
            else
            {
                int userType = (int)cboUserType.SelectedValue;
                int activationStatus = 0;
                if (rdoActive.Checked)
                {
                    activationStatus = 1;
                }

                userBLL.updateByAdmin(userType, activationStatus, userCode);
                MessageBox.Show("Updated successfully !!!");
                lblFullName.Text = "";
                rdoActive.Checked = rdoInactive.Checked = false;
                loadUsersDGV();
            }
        }
    }
}
