namespace ElvinShrestha_StickyNotes
{
    partial class StickyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNotes));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserTypeStatic = new System.Windows.Forms.Label();
            this.dtpSearchByDate = new System.Windows.Forms.DateTimePicker();
            this.lblUserType = new System.Windows.Forms.Label();
            this.rdoTitleContent = new System.Windows.Forms.RadioButton();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.lblSearchNotes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCreateANote = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAllNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCompletedNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiIncompleteNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStickiedNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCheckNotesStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDisplayCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDisplayUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAddUserType = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDisplayUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAboutStickyNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelNoteTitle = new System.Windows.Forms.Panel();
            this.lblNoteType = new System.Windows.Forms.Label();
            this.panelParentStickyNotes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHidePanels = new System.Windows.Forms.Button();
            this.panelEnableDisable = new System.Windows.Forms.Panel();
            this.btnEditSwitch = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelNoteTitle.SuspendLayout();
            this.panelEnableDisable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(72)))));
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.lblUserTypeStatic);
            this.panelHeader.Controls.Add(this.dtpSearchByDate);
            this.panelHeader.Controls.Add(this.lblUserType);
            this.panelHeader.Controls.Add(this.rdoTitleContent);
            this.panelHeader.Controls.Add(this.lblUserFullName);
            this.panelHeader.Controls.Add(this.rdoDate);
            this.panelHeader.Controls.Add(this.lblSearchNotes);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(825, 132);
            this.panelHeader.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(541, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUserTypeStatic
            // 
            this.lblUserTypeStatic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserTypeStatic.AutoSize = true;
            this.lblUserTypeStatic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTypeStatic.Location = new System.Drawing.Point(28, 85);
            this.lblUserTypeStatic.Name = "lblUserTypeStatic";
            this.lblUserTypeStatic.Size = new System.Drawing.Size(101, 22);
            this.lblUserTypeStatic.TabIndex = 4;
            this.lblUserTypeStatic.Text = "User Type:";
            this.lblUserTypeStatic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpSearchByDate
            // 
            this.dtpSearchByDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSearchByDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchByDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchByDate.Location = new System.Drawing.Point(295, 79);
            this.dtpSearchByDate.Name = "dtpSearchByDate";
            this.dtpSearchByDate.Size = new System.Drawing.Size(200, 31);
            this.dtpSearchByDate.TabIndex = 3;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(130, 85);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(96, 22);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "User Type";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoTitleContent
            // 
            this.rdoTitleContent.AutoSize = true;
            this.rdoTitleContent.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.rdoTitleContent.Location = new System.Drawing.Point(642, 41);
            this.rdoTitleContent.Name = "rdoTitleContent";
            this.rdoTitleContent.Size = new System.Drawing.Size(61, 26);
            this.rdoTitleContent.TabIndex = 2;
            this.rdoTitleContent.TabStop = true;
            this.rdoTitleContent.Text = "Title";
            this.rdoTitleContent.UseVisualStyleBackColor = true;
            this.rdoTitleContent.CheckedChanged += new System.EventHandler(this.searchRadio_Changed);
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.lblUserFullName.Location = new System.Drawing.Point(25, 27);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(183, 42);
            this.lblUserFullName.TabIndex = 0;
            this.lblUserFullName.Text = "Full Name";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.rdoDate.Location = new System.Drawing.Point(500, 41);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(74, 26);
            this.rdoDate.TabIndex = 1;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.searchRadio_Changed);
            // 
            // lblSearchNotes
            // 
            this.lblSearchNotes.AutoSize = true;
            this.lblSearchNotes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchNotes.Location = new System.Drawing.Point(291, 41);
            this.lblSearchNotes.Name = "lblSearchNotes";
            this.lblSearchNotes.Size = new System.Drawing.Size(179, 24);
            this.lblSearchNotes.TabIndex = 0;
            this.lblSearchNotes.Text = "Search notes by:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(192)))), ((int)(((byte)(95)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.userToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCreateANote,
            this.displayToolStripMenuItem,
            this.msiCheckNotesStatus});
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notesToolStripMenuItem.Text = "Notes";
            // 
            // msiCreateANote
            // 
            this.msiCreateANote.Name = "msiCreateANote";
            this.msiCreateANote.Size = new System.Drawing.Size(173, 22);
            this.msiCreateANote.Text = "Create a note";
            this.msiCreateANote.Click += new System.EventHandler(this.msiCreateANote_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAllNotes,
            this.msiCompletedNotes,
            this.msiIncompleteNotes,
            this.msiStickiedNotes});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // msiAllNotes
            // 
            this.msiAllNotes.Name = "msiAllNotes";
            this.msiAllNotes.Size = new System.Drawing.Size(237, 22);
            this.msiAllNotes.Text = "All Notes (Comprehensive List)";
            this.msiAllNotes.Click += new System.EventHandler(this.msiAllNotes_Click);
            // 
            // msiCompletedNotes
            // 
            this.msiCompletedNotes.Name = "msiCompletedNotes";
            this.msiCompletedNotes.Size = new System.Drawing.Size(237, 22);
            this.msiCompletedNotes.Text = "Completed Notes";
            this.msiCompletedNotes.Click += new System.EventHandler(this.msiCompletedNotes_Click);
            // 
            // msiIncompleteNotes
            // 
            this.msiIncompleteNotes.Name = "msiIncompleteNotes";
            this.msiIncompleteNotes.Size = new System.Drawing.Size(237, 22);
            this.msiIncompleteNotes.Text = "Incomplete Notes";
            this.msiIncompleteNotes.Click += new System.EventHandler(this.msiIncompleteNotes_Click);
            // 
            // msiStickiedNotes
            // 
            this.msiStickiedNotes.Name = "msiStickiedNotes";
            this.msiStickiedNotes.Size = new System.Drawing.Size(237, 22);
            this.msiStickiedNotes.Text = "Stickied Notes";
            this.msiStickiedNotes.Click += new System.EventHandler(this.msiStickiedNotes_Click);
            // 
            // msiCheckNotesStatus
            // 
            this.msiCheckNotesStatus.Name = "msiCheckNotesStatus";
            this.msiCheckNotesStatus.Size = new System.Drawing.Size(173, 22);
            this.msiCheckNotesStatus.Text = "Check notes status";
            this.msiCheckNotesStatus.Click += new System.EventHandler(this.msiCheckNotesStatus_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAddCategory,
            this.msiDisplayCategories});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // msiAddCategory
            // 
            this.msiAddCategory.Name = "msiAddCategory";
            this.msiAddCategory.Size = new System.Drawing.Size(171, 22);
            this.msiAddCategory.Text = "Add Category";
            this.msiAddCategory.Click += new System.EventHandler(this.category_Click);
            // 
            // msiDisplayCategories
            // 
            this.msiDisplayCategories.Name = "msiDisplayCategories";
            this.msiDisplayCategories.Size = new System.Drawing.Size(171, 22);
            this.msiDisplayCategories.Text = "Display Categories";
            this.msiDisplayCategories.Click += new System.EventHandler(this.category_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDisplayUserDetails});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // msiDisplayUserDetails
            // 
            this.msiDisplayUserDetails.Name = "msiDisplayUserDetails";
            this.msiDisplayUserDetails.Size = new System.Drawing.Size(176, 22);
            this.msiDisplayUserDetails.Text = "Display User Details";
            this.msiDisplayUserDetails.Click += new System.EventHandler(this.msiDisplayUserDetails_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiChangePassword,
            this.msiLogout,
            this.msiAdmin,
            this.msiDeleteAccount});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // msiChangePassword
            // 
            this.msiChangePassword.Name = "msiChangePassword";
            this.msiChangePassword.Size = new System.Drawing.Size(168, 22);
            this.msiChangePassword.Text = "Change Password";
            this.msiChangePassword.Click += new System.EventHandler(this.msiChangePassword_Click);
            // 
            // msiLogout
            // 
            this.msiLogout.Name = "msiLogout";
            this.msiLogout.Size = new System.Drawing.Size(168, 22);
            this.msiLogout.Text = "Logout";
            this.msiLogout.Click += new System.EventHandler(this.msiLogout_Click);
            // 
            // msiAdmin
            // 
            this.msiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAddUserType,
            this.msiDisplayUsers});
            this.msiAdmin.Name = "msiAdmin";
            this.msiAdmin.Size = new System.Drawing.Size(168, 22);
            this.msiAdmin.Text = "Admin";
            // 
            // msiAddUserType
            // 
            this.msiAddUserType.Name = "msiAddUserType";
            this.msiAddUserType.Size = new System.Drawing.Size(205, 22);
            this.msiAddUserType.Text = "Add or Display User Type";
            this.msiAddUserType.Click += new System.EventHandler(this.msiAddUserType_Click);
            // 
            // msiDisplayUsers
            // 
            this.msiDisplayUsers.Name = "msiDisplayUsers";
            this.msiDisplayUsers.Size = new System.Drawing.Size(205, 22);
            this.msiDisplayUsers.Text = "Display Users";
            this.msiDisplayUsers.Click += new System.EventHandler(this.msiDisplayUsers_Click);
            // 
            // msiDeleteAccount
            // 
            this.msiDeleteAccount.Name = "msiDeleteAccount";
            this.msiDeleteAccount.Size = new System.Drawing.Size(168, 22);
            this.msiDeleteAccount.Text = "Delete Account";
            this.msiDeleteAccount.Click += new System.EventHandler(this.msiDeleteAccount_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAboutStickyNotes});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // msiAboutStickyNotes
            // 
            this.msiAboutStickyNotes.Name = "msiAboutStickyNotes";
            this.msiAboutStickyNotes.Size = new System.Drawing.Size(175, 22);
            this.msiAboutStickyNotes.Text = "About Sticky Notes";
            this.msiAboutStickyNotes.Click += new System.EventHandler(this.msiAboutStickyNotes_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelNoteTitle
            // 
            this.panelNoteTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(72)))));
            this.panelNoteTitle.Controls.Add(this.lblNoteType);
            this.panelNoteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoteTitle.Location = new System.Drawing.Point(0, 215);
            this.panelNoteTitle.Name = "panelNoteTitle";
            this.panelNoteTitle.Size = new System.Drawing.Size(825, 51);
            this.panelNoteTitle.TabIndex = 7;
            // 
            // lblNoteType
            // 
            this.lblNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteType.AutoSize = true;
            this.lblNoteType.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteType.Location = new System.Drawing.Point(291, 12);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.Size = new System.Drawing.Size(151, 24);
            this.lblNoteType.TabIndex = 1;
            this.lblNoteType.Text = "Stickied Notes";
            this.lblNoteType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelParentStickyNotes
            // 
            this.panelParentStickyNotes.AutoScroll = true;
            this.panelParentStickyNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(65)))));
            this.panelParentStickyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParentStickyNotes.Location = new System.Drawing.Point(0, 266);
            this.panelParentStickyNotes.Name = "panelParentStickyNotes";
            this.panelParentStickyNotes.Size = new System.Drawing.Size(825, 483);
            this.panelParentStickyNotes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enable or disable editing";
            // 
            // btnHidePanels
            // 
            this.btnHidePanels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.btnHidePanels.FlatAppearance.BorderSize = 0;
            this.btnHidePanels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePanels.Location = new System.Drawing.Point(526, 10);
            this.btnHidePanels.Name = "btnHidePanels";
            this.btnHidePanels.Size = new System.Drawing.Size(122, 37);
            this.btnHidePanels.TabIndex = 6;
            this.btnHidePanels.Text = "Hide above panels";
            this.btnHidePanels.UseVisualStyleBackColor = false;
            this.btnHidePanels.Click += new System.EventHandler(this.btnHidePanels_Click);
            // 
            // panelEnableDisable
            // 
            this.panelEnableDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(231)))), ((int)(((byte)(108)))));
            this.panelEnableDisable.Controls.Add(this.btnHidePanels);
            this.panelEnableDisable.Controls.Add(this.btnEditSwitch);
            this.panelEnableDisable.Controls.Add(this.label2);
            this.panelEnableDisable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEnableDisable.Location = new System.Drawing.Point(0, 156);
            this.panelEnableDisable.Name = "panelEnableDisable";
            this.panelEnableDisable.Size = new System.Drawing.Size(825, 59);
            this.panelEnableDisable.TabIndex = 6;
            // 
            // btnEditSwitch
            // 
            this.btnEditSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(251)))), ((int)(((byte)(147)))));
            this.btnEditSwitch.FlatAppearance.BorderSize = 0;
            this.btnEditSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSwitch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSwitch.Location = new System.Drawing.Point(348, 10);
            this.btnEditSwitch.Name = "btnEditSwitch";
            this.btnEditSwitch.Size = new System.Drawing.Size(112, 37);
            this.btnEditSwitch.TabIndex = 5;
            this.btnEditSwitch.Text = "Enabled";
            this.btnEditSwitch.UseVisualStyleBackColor = false;
            this.btnEditSwitch.Click += new System.EventHandler(this.btnEditSwitch_Click);
            // 
            // StickyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 749);
            this.Controls.Add(this.panelParentStickyNotes);
            this.Controls.Add(this.panelNoteTitle);
            this.Controls.Add(this.panelEnableDisable);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StickyNotes";
            this.Text = "Sticky Notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StickyNotes_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNoteTitle.ResumeLayout(false);
            this.panelNoteTitle.PerformLayout();
            this.panelEnableDisable.ResumeLayout(false);
            this.panelEnableDisable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiCreateANote;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAllNotes;
        private System.Windows.Forms.ToolStripMenuItem msiCompletedNotes;
        private System.Windows.Forms.ToolStripMenuItem msiIncompleteNotes;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAddCategory;
        private System.Windows.Forms.ToolStripMenuItem msiDisplayCategories;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAboutStickyNotes;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelNoteTitle;
        private System.Windows.Forms.Label lblNoteType;
        private System.Windows.Forms.Panel panelParentStickyNotes;
        private System.Windows.Forms.ToolStripMenuItem msiCheckNotesStatus;
        private System.Windows.Forms.Label lblSearchNotes;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoTitleContent;
        private System.Windows.Forms.DateTimePicker dtpSearchByDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditSwitch;
        private System.Windows.Forms.Button btnHidePanels;
        private System.Windows.Forms.Panel panelEnableDisable;
        private System.Windows.Forms.ToolStripMenuItem msiLogout;
        private System.Windows.Forms.Label lblUserTypeStatic;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiDisplayUserDetails;
        private System.Windows.Forms.ToolStripMenuItem msiAdmin;
        private System.Windows.Forms.ToolStripMenuItem msiAddUserType;
        private System.Windows.Forms.ToolStripMenuItem msiDisplayUsers;
        private System.Windows.Forms.ToolStripMenuItem msiStickiedNotes;
        private System.Windows.Forms.ToolStripMenuItem msiDeleteAccount;
    }
}