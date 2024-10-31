namespace PresentationLayer
{
    partial class AdminForm
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
            ListViewItem listViewItem1 = new ListViewItem("");
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            AddPage = new TabPage();
            SearchPage = new TabPage();
            UpdatePage = new TabPage();
            DeletePage3 = new TabPage();
            MemberList = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            Password = new ColumnHeader();
            City = new ColumnHeader();
            Country = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(MemberList);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AddPage);
            tabControl1.Controls.Add(SearchPage);
            tabControl1.Controls.Add(UpdatePage);
            tabControl1.Controls.Add(DeletePage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 450);
            tabControl1.TabIndex = 0;
            // 
            // AddPage
            // 
            AddPage.Location = new Point(4, 24);
            AddPage.Name = "AddPage";
            AddPage.Padding = new Padding(3);
            AddPage.Size = new Size(258, 422);
            AddPage.TabIndex = 0;
            AddPage.Text = "Add";
            AddPage.UseVisualStyleBackColor = true;
            // 
            // SearchPage
            // 
            SearchPage.Location = new Point(4, 24);
            SearchPage.Name = "SearchPage";
            SearchPage.Padding = new Padding(3);
            SearchPage.Size = new Size(258, 422);
            SearchPage.TabIndex = 1;
            SearchPage.Text = "Search";
            SearchPage.UseVisualStyleBackColor = true;
            // 
            // UpdatePage
            // 
            UpdatePage.Location = new Point(4, 24);
            UpdatePage.Name = "UpdatePage";
            UpdatePage.Padding = new Padding(3);
            UpdatePage.Size = new Size(258, 422);
            UpdatePage.TabIndex = 2;
            UpdatePage.Text = "Update";
            UpdatePage.UseVisualStyleBackColor = true;
            // 
            // DeletePage3
            // 
            DeletePage3.Location = new Point(4, 24);
            DeletePage3.Name = "DeletePage3";
            DeletePage3.Padding = new Padding(3);
            DeletePage3.Size = new Size(258, 422);
            DeletePage3.TabIndex = 3;
            DeletePage3.Text = "Delete";
            DeletePage3.UseVisualStyleBackColor = true;
            // 
            // MemberList
            // 
            MemberList.Columns.AddRange(new ColumnHeader[] { Id, Name, Email, Password, City, Country });
            MemberList.Dock = DockStyle.Fill;
            MemberList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            MemberList.Location = new Point(0, 0);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(530, 450);
            MemberList.TabIndex = 0;
            MemberList.UseCompatibleStateImageBehavior = false;
            MemberList.SelectedIndexChanged += MemberList_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.Text = "Password";
            // 
            // City
            // 
            City.Text = "City";
            // 
            // Country
            // 
            Country.Text = "Country";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Text = "AdminForm";
            Load += AdminForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage AddPage;
        private TabPage SearchPage;
        private ListView MemberList;
        private TabPage UpdatePage;
        private TabPage DeletePage3;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader Email;
        private ColumnHeader Password;
        private ColumnHeader City;
        private ColumnHeader Country;
    }
}