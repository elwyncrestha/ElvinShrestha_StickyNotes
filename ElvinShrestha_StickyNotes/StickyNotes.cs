using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class StickyNotes : Form
    {
        StickyNotesBLL stickyNotesBLL = new StickyNotesBLL();

        int formHeight;
        int panelHeaderMiddle;

        public StickyNotes()
        {
            InitializeComponent();
        }

        private void StickyNotes_Load(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();

            bool adminStatus = userBLL.isAdmin(FormLoaderClass._username);
            if (!adminStatus)
            {
                msiAdmin.Visible = false;
            }
            else
            {
                msiDeleteAccount.Visible = false;
            }

            // send username to BLL
            stickyNotesBLL._username = FormLoaderClass._username;
            
            // header part
            DataTable dataTable = userBLL.getUserDetails(FormLoaderClass._username);
            lblUserFullName.Text = dataTable.Rows[0][0].ToString() + " " + dataTable.Rows[0][1].ToString();
            lblUserType.Text = dataTable.Rows[0][2].ToString();

            // panelHeader controls positioning
            int panelHeaderWidth = panelHeader.Width;
            lblUserFullName.Location = new Point(50, 30);
            lblUserTypeStatic.Location = new Point(50, 80);
            lblUserType.Location = new Point(150, 80);

            panelHeaderMiddle = panelHeaderWidth / 2;
            lblSearchNotes.Location = new Point(panelHeaderMiddle, 30);
            rdoDate.Location = new Point(panelHeaderMiddle + 200, 30);
            rdoTitleContent.Location = new Point(panelHeaderMiddle + 300, 30);
            dtpSearchByDate.Location = new Point(panelHeaderMiddle, 80);
            btnSearch.Location = new Point(panelHeaderMiddle + 210, 80);

            // sticky notes load
            loadStickyNotes(false, "null", "null", "Sticky", 1);
        }

        private void loadStickyNotes(bool isSearch, String searchDate, String searchTitle, String isStickyorCompletedorAll, int status)
        {
            // sticky notes load codes here
            int x = 10, y = 10; // initial coordinates of panel
            int panelSpacing = 10;
            int panelWidth = this.panelParentStickyNotes.Width;
            int panelHeight = this.panelParentStickyNotes.Height;
            formHeight = this.panelHeader.Height + this.panelEnableDisable.Height + this.panelNoteTitle.Height + this.panelParentStickyNotes.Height;

            int totalNotesCount = stickyNotesBLL.countNotes(isSearch, searchDate, searchTitle, isStickyorCompletedorAll,status);
            if(totalNotesCount == 0)
            {
                MessageBox.Show("Notes list empty !!!");
            }
            int startNoteCount = 0;

            DataTable dataTable = null;
            if (totalNotesCount > 0)
            {
                dataTable = stickyNotesBLL.loadStickyOrCompletedorAll(isSearch, searchDate, searchTitle, isStickyorCompletedorAll, status);
            }

            // display starts here
            while (startNoteCount < totalNotesCount)
            {
                int nId = int.Parse(dataTable.Rows[startNoteCount][0].ToString());
                String nDate = dataTable.Rows[startNoteCount][1].ToString();
                String nTitle = dataTable.Rows[startNoteCount][2].ToString();
                String nContent = dataTable.Rows[startNoteCount][3].ToString();
                String nCompletionStatus = dataTable.Rows[startNoteCount][4].ToString();
                String nStickyStatus = dataTable.Rows[startNoteCount][5].ToString();
                String nCategoryName = dataTable.Rows[startNoteCount][6].ToString();

                // object initialization starts
                Label lblNoteId = new Label();
                TextBox txtTitle = new TextBox();
                TextBox txtContent = new TextBox();
                ComboBox cboCategory = new ComboBox();
                // object initialization ends

                Panel panelStickyNote = new Panel();
                panelStickyNote.Name = "panelStickyNote";
                panelStickyNote.Size = new Size(200, 304);

                panelStickyNote.MouseHover += (s, ea) =>
                {
                    Button btnUpdate = new Button();
                    btnUpdate.BackColor = Color.Transparent;
                    btnUpdate.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.refreshButton_white;
                    btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
                    btnUpdate.FlatStyle = FlatStyle.Flat;
                    btnUpdate.FlatAppearance.BorderSize = 0;
                    btnUpdate.UseVisualStyleBackColor = false;
                    btnUpdate.Location = new Point(160, 270);
                    btnUpdate.Name = "btnUpdate";
                    btnUpdate.Size = new Size(25, 23);
                    btnUpdate.TabIndex = 12;
                    btnUpdate.UseVisualStyleBackColor = true;
                    btnUpdate.MouseEnter += (s1, ea1) =>
                    {
                        btnUpdate.BackColor = Color.White;
                        btnUpdate.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.refreshButton_black;
                    };
                    btnUpdate.MouseLeave += (s1, ea1) =>
                    {
                        btnUpdate.BackColor = Color.Transparent;
                        btnUpdate.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.refreshButton_white;
                    };
                    btnUpdate.Click += (s1, ea1) =>
                    {
                        int noteId = int.Parse(lblNoteId.Text);

                        stickyNotesBLL.updateNote(noteId, txtTitle.Text, txtContent.Text,(int)cboCategory.SelectedValue);
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(false,"null","null",isStickyorCompletedorAll, status);
                    };

                    panelStickyNote.Controls.Add(btnUpdate);
                };

                if ((x + panelStickyNote.Width) < panelWidth)
                {
                    panelStickyNote.Location = new Point(x, y);
                    panelStickyNote.BackColor = Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(76)))), ((int)(((byte)(35)))));

                    // hidden lblNoteId
                    // global object for stickyNote load
                    lblNoteId.Name = "lblNoteId";
                    lblNoteId.Location = new Point(3, 23);
                    lblNoteId.Text = nId.ToString();
                    lblNoteId.ForeColor = Color.White;
                    lblNoteId.Size = new Size(62, 16);
                    lblNoteId.AutoSize = true;
                    lblNoteId.Visible = false;

                    // chkSticky
                    CheckBox chkSticky = new CheckBox();
                    chkSticky.AutoSize = true;
                    chkSticky.ForeColor = Color.White;
                    chkSticky.Location = new Point(4, 4);
                    chkSticky.Name = "chkSticky";
                    chkSticky.Size = new Size(57, 20);
                    chkSticky.TabIndex = 0;
                    chkSticky.Text = "Sticky";
                    chkSticky.UseVisualStyleBackColor = true;
                    if(nStickyStatus == "True")
                    {
                        chkSticky.Checked = true;
                    }
                    chkSticky.CheckedChanged += (s, ea) =>
                    {
                        int noteId = int.Parse(lblNoteId.Text);
                        bool isSticky = false;

                        if (chkSticky.Checked)
                        {
                            isSticky = true;
                        }

                        stickyNotesBLL.updateNoteStickyStatus(noteId, isSticky);

                        // refresh
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(false,"null","null",isStickyorCompletedorAll, status);
                    };

                    // chkCompleted
                    CheckBox chkCompleted = new CheckBox();
                    chkCompleted.AutoSize = true;
                    chkCompleted.ForeColor = Color.White;
                    chkCompleted.Location = new Point(108, 4);
                    chkCompleted.Name = "chkCompleted";
                    chkCompleted.Size = new Size(89, 20);
                    chkCompleted.TabIndex = 1;
                    chkCompleted.Text = "Completed";
                    chkCompleted.UseVisualStyleBackColor = true;
                    if(nCompletionStatus == "True")
                    {
                        chkCompleted.Checked = true;
                    }
                    chkCompleted.CheckedChanged += (s, ea) =>
                    {
                        int noteId = int.Parse(lblNoteId.Text);
                        bool isCompleted = false;

                        if (chkCompleted.Checked)
                        {
                            isCompleted = true;
                        }

                        stickyNotesBLL.updateNoteCompletionStatus(noteId, isCompleted);

                        // refresh
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(false, "null", "null", isStickyorCompletedorAll, status);
                    };

                    // lblCategory
                    Label lblCategory = new Label();
                    lblCategory.AutoSize = true;
                    lblCategory.ForeColor = Color.White;
                    lblCategory.Location = new Point(4, 39);
                    lblCategory.Name = "lblCategory";
                    lblCategory.Size = new Size(62, 16);
                    lblCategory.TabIndex = 2;
                    lblCategory.Text = "Category:";

                    // lblCategoryContent
                    Label lblCategoryContent = new Label();
                    lblCategoryContent.AutoSize = true;
                    lblCategoryContent.ForeColor = Color.White;
                    lblCategoryContent.Location = new Point(64, 39);
                    lblCategoryContent.Name = "lblCategoryContent";
                    lblCategoryContent.Size = new Size(62, 16);
                    lblCategoryContent.Text = nCategoryName;

                    // lnklblCategoryEdit
                    LinkLabel lnklblCategoryEdit = new LinkLabel();
                    lnklblCategoryEdit.AutoSize = true;
                    lnklblCategoryEdit.LinkColor = Color.White;
                    lnklblCategoryEdit.Location = new Point(4, 58);
                    lnklblCategoryEdit.Name = "lnklblCategoryEdit";
                    lnklblCategoryEdit.Size = new Size(62, 16);
                    lnklblCategoryEdit.TabIndex = 3;
                    lnklblCategoryEdit.Text = "Click to edit Category";
                    lnklblCategoryEdit.Click += (s,ea) =>
                    {
                        lnklblCategoryEdit.Visible = false;
                        cboCategory.Visible = true;
                        cboCategory.Focus();
                    };

                    // cboCategory
                    // global object for stickyNote load
                    cboCategory.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    cboCategory.FormattingEnabled = true;
                    cboCategory.Location = new Point(4, 58);
                    cboCategory.Name = "cboCategory";
                    cboCategory.Size = new Size(193, 24);
                    cboCategory.TabIndex = 3;
                    cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                    CategoriesBLL categoriesBLL = new CategoriesBLL();
                    cboCategory.DataSource = categoriesBLL.loadCategories(FormLoaderClass._username);
                    cboCategory.DisplayMember = "categoryName";
                    cboCategory.ValueMember = "categoryId";
                    cboCategory.Visible = false;

                    // lblTitle
                    Label lblTitle = new Label();
                    lblTitle.AutoSize = true;
                    lblTitle.ForeColor = Color.White;
                    lblTitle.Location = new Point(4, 85);
                    lblTitle.Name = "lblTitle";
                    lblTitle.Size = new Size(28, 16);
                    lblTitle.TabIndex = 4;
                    lblTitle.Text = "Title";

                    // txtTitle
                    // global object for stickyNote load
                    txtTitle.Location = new Point(3, 104);
                    txtTitle.Name = "txtTitle";
                    txtTitle.Size = new Size(193, 21);
                    txtTitle.TabIndex = 5;
                    txtTitle.Text = nTitle;

                    // lblContent
                    Label lblContent = new Label();
                    lblContent.AutoSize = true;
                    lblContent.ForeColor = Color.White;
                    lblContent.Location = new Point(1, 128);
                    lblContent.Name = "lblContent";
                    lblContent.Size = new Size(53, 16);
                    lblContent.TabIndex = 6;
                    lblContent.Text = "Content";

                    // txtContent
                    // global object for stickyNote load
                    txtContent.Location = new Point(3, 147);
                    txtContent.Multiline = true;
                    txtContent.Name = "txtContent";
                    txtContent.Size = new Size(193, 90);
                    txtContent.TabIndex = 7;
                    txtContent.ScrollBars = ScrollBars.Vertical;
                    txtContent.Text = nContent;

                    // lblDateCreated
                    Label lblDateCreated = new Label();
                    lblDateCreated.AutoSize = true;
                    lblDateCreated.ForeColor = Color.White;
                    lblDateCreated.Location = new Point(4, 244);
                    lblDateCreated.Name = "lblDateCreated";
                    lblDateCreated.Size = new Size(87, 16);
                    lblDateCreated.TabIndex = 8;
                    lblDateCreated.Text = "Date Created:";

                    // lblDateCreatedValue
                    Label lblDateCreatedValue = new Label();
                    lblDateCreatedValue.AutoSize = true;
                    lblDateCreatedValue.ForeColor = Color.White;
                    lblDateCreatedValue.Location = new Point(97, 244);
                    lblDateCreatedValue.Name = "lblDateCreatedValue";
                    lblDateCreatedValue.Size = new Size(64, 16);
                    lblDateCreatedValue.TabIndex = 9;
                    lblDateCreatedValue.Text = nDate;

                    // lblDeleteNote
                    Label lblDeleteNote = new Label();
                    lblDeleteNote.AutoSize = true;
                    lblDeleteNote.ForeColor = Color.White;
                    lblDeleteNote.Location = new Point(4, 277);
                    lblDeleteNote.Name = "lblDeleteNote";
                    lblDeleteNote.Size = new Size(71, 16);
                    lblDeleteNote.TabIndex = 10;
                    lblDeleteNote.Text = "Delete note";

                    // btnDelete
                    Button btnDelete = new Button();
                    btnDelete.BackColor = Color.Transparent;
                    btnDelete.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.deleteIcon;
                    btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.FlatAppearance.BorderSize = 0;
                    btnDelete.UseVisualStyleBackColor = false;
                    btnDelete.Location = new Point(86, 270);
                    btnDelete.Name = "btnDelete";
                    btnDelete.Size = new Size(25, 23);
                    btnDelete.TabIndex = 11;
                    btnDelete.UseVisualStyleBackColor = true;
                    btnDelete.Click += (s, ea) =>
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            panelStickyNote.Hide(); // panel hidden but deleted also.
                            int noteId = int.Parse(lblNoteId.Text);
                            stickyNotesBLL.deleteNote(noteId);

                            // refresh sticky notes
                            panelParentStickyNotes.Controls.Clear();
                            loadStickyNotes(isSearch, searchDate, searchTitle, isStickyorCompletedorAll, status);
                        }
                    };
                    btnDelete.MouseEnter += (s, ea) =>
                    {
                        btnDelete.BackColor = Color.White;
                        btnDelete.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.deleteIcon_dark;
                    };
                    btnDelete.MouseLeave += (s, ea) =>
                    {
                        btnDelete.BackColor = Color.Transparent;
                        btnDelete.BackgroundImage = global::ElvinShrestha_StickyNotes.Properties.Resources.deleteIcon;
                    };
                    
                    
                    // added to panelStickyNote 
                    panelStickyNote.Controls.Add(lblNoteId);
                    panelStickyNote.Controls.Add(chkSticky);
                    panelStickyNote.Controls.Add(chkCompleted);
                    panelStickyNote.Controls.Add(lblCategory);
                    panelStickyNote.Controls.Add(lblCategoryContent);
                    panelStickyNote.Controls.Add(lnklblCategoryEdit);
                    panelStickyNote.Controls.Add(cboCategory);
                    panelStickyNote.Controls.Add(lblTitle);
                    panelStickyNote.Controls.Add(txtTitle);
                    panelStickyNote.Controls.Add(lblContent);
                    panelStickyNote.Controls.Add(txtContent);
                    panelStickyNote.Controls.Add(lblDateCreated);
                    panelStickyNote.Controls.Add(lblDateCreatedValue);
                    panelStickyNote.Controls.Add(lblDeleteNote);
                    panelStickyNote.Controls.Add(btnDelete);

                    // added to panelParentStickyNotes
                    panelParentStickyNotes.Controls.Add(panelStickyNote);

                    // coordinate update
                    x = x + panelStickyNote.Width + panelSpacing;
                    startNoteCount = startNoteCount + 1;
                }
                else if ((x + panelStickyNote.Width) >= panelWidth)
                {
                    x = 10;
                    y = y + panelStickyNote.Height + panelSpacing;
                }
            }
        }

       
        int parentPanelSize;
        private void btnHidePanels_Click(object sender, EventArgs e)
        {
            if (btnHidePanels.Text == "Hide above panels")
            {
                btnHidePanels.BackColor = Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
                btnHidePanels.Text = "Show panels";
                this.panelHeader.Hide();
                parentPanelSize = this.panelParentStickyNotes.Height;
                this.panelParentStickyNotes.Height = formHeight - panelHeader.Height;
            }
            else if (btnHidePanels.Text == "Show panels")
            {
                btnHidePanels.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
                btnHidePanels.Text = "Hide above panels";
                this.panelHeader.Show();
                this.panelParentStickyNotes.Height = parentPanelSize;
            }
        }

        private void msiCheckNotesStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadDashboard();
            this.Close();
        }

        private void btnEditSwitch_Click(object sender, EventArgs e)
        {
            if (btnEditSwitch.Text == "Enabled")
            {
                btnEditSwitch.Text = "Disabled";
                btnEditSwitch.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
                panelParentStickyNotes.Enabled = false;
            }
            else if (btnEditSwitch.Text == "Disabled")
            {
                btnEditSwitch.Text = "Enabled";
                btnEditSwitch.BackColor = Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
                panelParentStickyNotes.Enabled = true;
            }
        }

        private void category_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadCategories();
            this.Close();
        }

        private void msiLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadLogin();
            this.Close();
        }

        private void msiCreateANote_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadCreateANote();
            this.Close();
        }

        private void msiAddUserType_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadUserType();
            this.Close();
        }

        private void msiCompletedNotes_Click(object sender, EventArgs e)
        {
            lblNoteType.Text = "Completed Notes";
            panelParentStickyNotes.Controls.Clear();
            loadStickyNotes(false, "null", "null", "Completed", 1);
        }

        private void msiIncompleteNotes_Click(object sender, EventArgs e)
        {
            lblNoteType.Text = "Incomplete Notes";
            panelParentStickyNotes.Controls.Clear();
            loadStickyNotes(false, "null", "null", "Completed", 0);
        }

        private void msiStickiedNotes_Click(object sender, EventArgs e)
        {
            lblNoteType.Text = "Stickied Notes";
            panelParentStickyNotes.Controls.Clear();
            loadStickyNotes(false, "null", "null", "Sticky", 1);
        }

        private void msiAllNotes_Click(object sender, EventArgs e)
        {
            lblNoteType.Text = "All Notes - Comprehensive List";
            panelParentStickyNotes.Controls.Clear();
            loadStickyNotes(false, "null", "null", "All", 123123); // status is useless in case of 'All'
        }

        private void msiChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadChangePassword();
            this.Close();
        }

        private void msiDisplayUserDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadUserDetails();
            this.Close();
        }

        private void msiDisplayUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadUserDetailAdmin();
            this.Close();
        }

        // for note search
        TextBox txtSearchByTitleContent = new TextBox();
        private void searchRadio_Changed(object sender, EventArgs e)
        {
            if (rdoDate.Checked == true && rdoTitleContent.Checked == false)
            {
                txtSearchByTitleContent.Enabled = false;
                txtSearchByTitleContent.Visible = false;

                dtpSearchByDate.Enabled = true;
                dtpSearchByDate.Visible = true;
            }
            else if (rdoDate.Checked == false && rdoTitleContent.Checked == true)
            {
                txtSearchByTitleContent.Name = "txtSearchByTitleContent";
                txtSearchByTitleContent.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtSearchByTitleContent.Location = new Point(panelHeaderMiddle, 80);
                txtSearchByTitleContent.Size = new Size(200, 31);
                txtSearchByTitleContent.Clear();
                panelHeader.Controls.Add(txtSearchByTitleContent);

                dtpSearchByDate.Enabled = false;
                dtpSearchByDate.Visible = false;

                txtSearchByTitleContent.Enabled = true;
                txtSearchByTitleContent.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rdoDate.Checked && dtpSearchByDate.Enabled == true)
            {
                bool noteStatus = stickyNotesBLL.verifyNoteByDate(dtpSearchByDate.Text);
                if(noteStatus)
                {
                    if (lblNoteType.Text == "Stickied Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, dtpSearchByDate.Text, "null", "Sticky", 1);
                    }
                    else if(lblNoteType.Text == "Completed Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, dtpSearchByDate.Text, "null", "Completed", 1);
                    }
                    else if (lblNoteType.Text == "Incomplete Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, dtpSearchByDate.Text, "null", "Completed", 0);
                    }
                    else if(lblNoteType.Text == "All Notes - Comprehensive List")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, dtpSearchByDate.Text, "null", "All", 123);
                    }
                }
                else
                {
                    MessageBox.Show("No notes saved on that day !!!");
                }
            }
            else if (rdoTitleContent.Checked && txtSearchByTitleContent.Enabled == true)
            {
                bool noteStatus = stickyNotesBLL.verifyNoteByTitle(txtSearchByTitleContent.Text);
                if (noteStatus)
                {
                    if (lblNoteType.Text == "Stickied Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, "null", txtSearchByTitleContent.Text, "Sticky", 1);
                    }
                    else if (lblNoteType.Text == "Completed Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, "null", txtSearchByTitleContent.Text, "Completed", 1);
                    }
                    else if (lblNoteType.Text == "Incomplete Notes")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, "null", txtSearchByTitleContent.Text, "Completed", 0);
                    }
                    else if (lblNoteType.Text == "All Notes - Comprehensive List")
                    {
                        panelParentStickyNotes.Controls.Clear();
                        loadStickyNotes(true, "null", txtSearchByTitleContent.Text, "All", 123);
                    }
                }
                else
                {
                    MessageBox.Show("No notes saved with that title !!!");
                }
            }
        }

        private void msiAboutStickyNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadAboutStickyNote();
            this.Close();
        }

        private void msiDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserBLL userBLL = new UserBLL();
                int currentUserId = userBLL.getUserId(FormLoaderClass._username);
                userBLL.deleteUser(currentUserId);
                FormLoaderClass.loadLogin();
                this.Close();
            }
        }
    }
}
