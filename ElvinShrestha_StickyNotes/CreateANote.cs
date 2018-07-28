using System;
using System.Data;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class CreateANote : Form
    {
        StickyNotesBLL stickyNotesBLL = new StickyNotesBLL();

        public CreateANote()
        {
            InitializeComponent();
        }

        private void CreateANote_Load(object sender, EventArgs e)
        {
            // header part
            UserBLL userBLL = new UserBLL();
            DataTable dataTable = userBLL.getUserDetails(FormLoaderClass._username);
            lblUserFullName.Text = dataTable.Rows[0][0].ToString() + dataTable.Rows[0][1].ToString();
            lblUserType.Text = dataTable.Rows[0][2].ToString();

            // load categories
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            cboNoteCategory.DataSource = categoriesBLL.loadCategories(FormLoaderClass._username);
            cboNoteCategory.DisplayMember = "categoryName";
            cboNoteCategory.ValueMember = "categoryId";
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoteTitle.Text))
            {
                MessageBox.Show("Please enter note title !!!");
                txtNoteTitle.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtNoteContent.Text))
            {
                MessageBox.Show("Please enter note content !!!");
                txtNoteContent.Focus();
                return;
            }
            else
            {
                int categoryId = (int)cboNoteCategory.SelectedValue;
                int stickyStatus = 0;
                if (chkSticky.Checked)
                {
                    stickyStatus = 1;
                }
                UserBLL userBLL = new UserBLL();
                int userId = userBLL.getUserId(FormLoaderClass._username);

                stickyNotesBLL.addNote(txtNoteTitle.Text, categoryId, txtNoteContent.Text, stickyStatus, userId);

                this.Hide();
                FormLoaderClass.loadStickyNotes();
                this.Close();
            }
        }

        private void CreateANote_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }
    }
}
