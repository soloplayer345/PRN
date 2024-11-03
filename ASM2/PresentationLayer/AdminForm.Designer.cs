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
            ListViewItem listViewItem2 = new ListViewItem("");
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            AddPage = new TabPage();
            Addbtn = new Button();
            panel5 = new Panel();
            CountryAdding = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            CityAdding = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            EmailAdding = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            PasswordAdding = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            NameAdding = new TextBox();
            label1 = new Label();
            SearchPage = new TabPage();
            EditPage = new TabPage();
            Delete = new Button();
            Updatebtn = new Button();
            panel11 = new Panel();
            TxtId = new TextBox();
            label11 = new Label();
            panel6 = new Panel();
            TxtCountry = new TextBox();
            label6 = new Label();
            panel7 = new Panel();
            TxtCity = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            TxtEmail = new TextBox();
            label8 = new Label();
            panel9 = new Panel();
            TxtPassword = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            TxtName = new TextBox();
            label10 = new Label();
            MemberList = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            Password = new ColumnHeader();
            City = new ColumnHeader();
            Country = new ColumnHeader();
            label12 = new Label();
            SearchedId = new TextBox();
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            AddPage.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SearchPage.SuspendLayout();
            EditPage.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
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
            tabControl1.Controls.Add(EditPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 450);
            tabControl1.TabIndex = 0;
            // 
            // AddPage
            // 
            AddPage.Controls.Add(Addbtn);
            AddPage.Controls.Add(panel5);
            AddPage.Controls.Add(panel4);
            AddPage.Controls.Add(panel3);
            AddPage.Controls.Add(panel2);
            AddPage.Controls.Add(panel1);
            AddPage.Location = new Point(4, 24);
            AddPage.Name = "AddPage";
            AddPage.Padding = new Padding(3);
            AddPage.Size = new Size(258, 422);
            AddPage.TabIndex = 0;
            AddPage.Text = "Add";
            AddPage.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(3, 307);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 1;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(CountryAdding);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 245);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 56);
            panel5.TabIndex = 4;
            // 
            // CountryAdding
            // 
            CountryAdding.Location = new Point(5, 18);
            CountryAdding.Name = "CountryAdding";
            CountryAdding.Size = new Size(241, 23);
            CountryAdding.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 0;
            label5.Text = "Country";
            // 
            // panel4
            // 
            panel4.Controls.Add(CityAdding);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(5, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 56);
            panel4.TabIndex = 3;
            // 
            // CityAdding
            // 
            CityAdding.Location = new Point(5, 18);
            CityAdding.Name = "CityAdding";
            CityAdding.Size = new Size(241, 23);
            CityAdding.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 0;
            label4.Text = "City";
            // 
            // panel3
            // 
            panel3.Controls.Add(EmailAdding);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 56);
            panel3.TabIndex = 2;
            // 
            // EmailAdding
            // 
            EmailAdding.Location = new Point(5, 18);
            EmailAdding.Name = "EmailAdding";
            EmailAdding.Size = new Size(241, 23);
            EmailAdding.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordAdding);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 56);
            panel2.TabIndex = 1;
            // 
            // PasswordAdding
            // 
            PasswordAdding.Location = new Point(5, 18);
            PasswordAdding.Name = "PasswordAdding";
            PasswordAdding.Size = new Size(241, 23);
            PasswordAdding.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(NameAdding);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 56);
            panel1.TabIndex = 0;
            // 
            // NameAdding
            // 
            NameAdding.Location = new Point(5, 18);
            NameAdding.Name = "NameAdding";
            NameAdding.Size = new Size(241, 23);
            NameAdding.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // SearchPage
            // 
            SearchPage.Controls.Add(Searchbtn);
            SearchPage.Controls.Add(SearchedId);
            SearchPage.Controls.Add(label12);
            SearchPage.Location = new Point(4, 24);
            SearchPage.Name = "SearchPage";
            SearchPage.Padding = new Padding(3);
            SearchPage.Size = new Size(258, 422);
            SearchPage.TabIndex = 1;
            SearchPage.Text = "Search";
            SearchPage.UseVisualStyleBackColor = true;
            // 
            // EditPage
            // 
            EditPage.Controls.Add(Delete);
            EditPage.Controls.Add(Updatebtn);
            EditPage.Controls.Add(panel11);
            EditPage.Controls.Add(panel6);
            EditPage.Controls.Add(panel7);
            EditPage.Controls.Add(panel8);
            EditPage.Controls.Add(panel9);
            EditPage.Controls.Add(panel10);
            EditPage.Location = new Point(4, 24);
            EditPage.Name = "EditPage";
            EditPage.Padding = new Padding(3);
            EditPage.Size = new Size(258, 422);
            EditPage.TabIndex = 2;
            EditPage.Text = "Edit";
            EditPage.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(178, 395);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(4, 395);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 11;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(TxtId);
            panel11.Controls.Add(label11);
            panel11.Location = new Point(0, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(263, 65);
            panel11.TabIndex = 10;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(3, 24);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(257, 23);
            TxtId.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 6);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 0;
            label11.Text = "Id";
            // 
            // panel6
            // 
            panel6.Controls.Add(TxtCountry);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(4, 333);
            panel6.Name = "panel6";
            panel6.Size = new Size(249, 56);
            panel6.TabIndex = 9;
            // 
            // TxtCountry
            // 
            TxtCountry.Location = new Point(5, 18);
            TxtCountry.Name = "TxtCountry";
            TxtCountry.Size = new Size(241, 23);
            TxtCountry.TabIndex = 1;
            TxtCountry.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 0;
            label6.Text = "Country";
            // 
            // panel7
            // 
            panel7.Controls.Add(TxtCity);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(4, 271);
            panel7.Name = "panel7";
            panel7.Size = new Size(249, 56);
            panel7.TabIndex = 8;
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(5, 18);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(241, 23);
            TxtCity.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 0;
            label7.Text = "City";
            // 
            // panel8
            // 
            panel8.Controls.Add(TxtEmail);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(4, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(249, 56);
            panel8.TabIndex = 7;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(5, 18);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(241, 23);
            TxtEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // panel9
            // 
            panel9.Controls.Add(TxtPassword);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(4, 209);
            panel9.Name = "panel9";
            panel9.Size = new Size(249, 56);
            panel9.TabIndex = 6;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(5, 18);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(241, 23);
            TxtPassword.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 0;
            label9.Text = "Password";
            // 
            // panel10
            // 
            panel10.Controls.Add(TxtName);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(3, 85);
            panel10.Name = "panel10";
            panel10.Size = new Size(249, 56);
            panel10.TabIndex = 5;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(5, 18);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(241, 23);
            TxtName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 0;
            label10.Text = "Name";
            // 
            // MemberList
            // 
            MemberList.Columns.AddRange(new ColumnHeader[] { Id, Name, Email, Password, City, Country });
            MemberList.Dock = DockStyle.Fill;
            MemberList.Items.AddRange(new ListViewItem[] { listViewItem2 });
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(17, 15);
            label12.TabIndex = 0;
            label12.Text = "Id";
            // 
            // SearchedId
            // 
            SearchedId.Location = new Point(3, 18);
            SearchedId.Name = "SearchedId";
            SearchedId.Size = new Size(100, 23);
            SearchedId.TabIndex = 1;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(6, 47);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 23);
            Searchbtn.TabIndex = 2;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
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
            AddPage.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SearchPage.ResumeLayout(false);
            SearchPage.PerformLayout();
            EditPage.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView MemberList;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader Email;
        private ColumnHeader Password;
        private ColumnHeader City;
        private ColumnHeader Country;
        private TabControl tabControl1;
        private TabPage AddPage;
        private Button Addbtn;
        private Panel panel5;
        private TextBox CountryAdding;
        private Label label5;
        private Panel panel4;
        private TextBox CityAdding;
        private Label label4;
        private Panel panel3;
        private TextBox EmailAdding;
        private Label label3;
        private Panel panel2;
        private TextBox PasswordAdding;
        private Label label2;
        private Panel panel1;
        private TextBox NameAdding;
        private Label label1;
        private TabPage SearchPage;
        private TabPage EditPage;
        private Button Updatebtn;
        private Panel panel11;
        private TextBox TxtId;
        private Label label11;
        private Panel panel6;
        private TextBox TxtCountry;
        private Label label6;
        private Panel panel7;
        private TextBox TxtCity;
        private Label label7;
        private Panel panel8;
        private TextBox TxtEmail;
        private Label label8;
        private Panel panel9;
        private TextBox TxtPassword;
        private Label label9;
        private Panel panel10;
        private TextBox TxtName;
        private Label label10;
        private Button Delete;
        private Button Searchbtn;
        private TextBox SearchedId;
        private Label label12;
    }
}