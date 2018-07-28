using System;
using System.Data;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class Categories : Form
    {
        CategoriesBLL categoriesBLL = new CategoriesBLL();

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // header part
            UserBLL userBLL = new UserBLL();
            DataTable dataTable = userBLL.getUserDetails(FormLoaderClass._username);
            lblUserFullName.Text = dataTable.Rows[0][0].ToString() + dataTable.Rows[0][1].ToString();
            lblUserType.Text = dataTable.Rows[0][2].ToString();

            // categories load
            loadCategories();
        }

        private void loadCategories()
        {
            dgvCategories.DataSource = categoriesBLL.loadCategories(FormLoaderClass._username);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (btnAddCategory.Text == "ADD")
            {
                if (String.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Please enter category name !!!");
                    txtCategoryName.Focus();
                    return;
                }
                else
                {
                    bool categoryStatus = categoriesBLL.verifyCategory(FormLoaderClass._username, txtCategoryName.Text);
                    if (categoryStatus)
                    {
                        categoriesBLL.insertCategory(FormLoaderClass._username, txtCategoryName.Text);
                        txtCategoryName.Clear();
                        loadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Category named " + txtCategoryName.Text + " has already been added !!!");
                        txtCategoryName.Clear();
                        txtCategoryName.Focus();
                        return;
                    }
                }
            }
            else if (btnAddCategory.Text == "UPDATE")
            {
                if (String.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Please enter category name !!!");
                    txtCategoryName.Focus();
                    return;
                }
                else
                {
                    bool categoryStatus = categoriesBLL.verifyCategory(FormLoaderClass._username, txtCategoryName.Text);
                    if (categoryStatus)
                    {
                        categoriesBLL.updateCategory(categoryCode, txtCategoryName.Text);
                        txtCategoryName.Clear();
                        btnAddCategory.Text = "ADD";
                        loadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Category named " + txtCategoryName.Text + " has already been added !!!");
                        txtCategoryName.Clear();
                        txtCategoryName.Focus();
                        return;
                    }
                }
            }
        }


        int categoryCode;
        private void dgvCategories_Click(object sender, EventArgs e)
        {
            categoryCode = int.Parse(dgvCategories.CurrentRow.Cells["categoryId"].Value.ToString());
            int columnIndex = dgvCategories.CurrentCell.ColumnIndex;

            if (dgvCategories.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                btnAddCategory.Text = "UPDATE";
                DataTable dataTable = categoriesBLL.loadCategories(categoryCode);

                txtCategoryName.Text = dataTable.Rows[0][1].ToString();
            }
            else if (dgvCategories.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    categoriesBLL.deleteCategory(categoryCode);
                    txtCategoryName.Clear();
                    loadCategories();
                }
            }
        }

        private void Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }
    }
}