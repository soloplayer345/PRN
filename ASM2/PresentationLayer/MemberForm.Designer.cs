namespace PresentationLayer
{
    partial class MemberForm
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
            Updatebtn = new Button();
            panel6 = new Panel();
            TxtCountry = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            TxtCity = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            TxtPassword = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            TxtEmail = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            TxtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            TxtId = new TextBox();
            label1 = new Label();
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
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(Updatebtn);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(MemberList);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(6, 424);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 23);
            Updatebtn.TabIndex = 1;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(TxtCountry);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 358);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 65);
            panel6.TabIndex = 2;
            // 
            // TxtCountry
            // 
            TxtCountry.Location = new Point(3, 24);
            TxtCountry.Name = "TxtCountry";
            TxtCountry.Size = new Size(257, 23);
            TxtCountry.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 0;
            label6.Text = "Country";
            // 
            // panel5
            // 
            panel5.Controls.Add(TxtCity);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 287);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 65);
            panel5.TabIndex = 2;
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(3, 24);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(257, 23);
            TxtCity.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 0;
            label5.Text = "City";
            // 
            // panel4
            // 
            panel4.Controls.Add(TxtPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 65);
            panel4.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(3, 24);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(257, 23);
            TxtPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(TxtEmail);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 65);
            panel3.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(3, 24);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(257, 23);
            TxtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(TxtName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 65);
            panel2.TabIndex = 1;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(3, 24);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(257, 23);
            TxtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 65);
            panel1.TabIndex = 0;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(3, 24);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(257, 23);
            TxtId.TabIndex = 1;
            TxtId.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // MemberList
            // 
            MemberList.Columns.AddRange(new ColumnHeader[] { Id, Name, Email, Password, City, Country });
            MemberList.Items.AddRange(new ListViewItem[] { listViewItem2 });
            MemberList.Location = new Point(3, 0);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(527, 447);
            MemberList.TabIndex = 0;
            MemberList.UseCompatibleStateImageBehavior = false;
            MemberList.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Text = "MemberForm";
            Load += MemberForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel1;
        private Label label1;
        private TextBox TxtId;
        private Panel panel2;
        private TextBox TxtName;
        private Label label2;
        private Panel panel6;
        private TextBox TxtCountry;
        private Label label6;
        private Panel panel5;
        private TextBox TxtCity;
        private Label label5;
        private Panel panel4;
        private TextBox TxtPassword;
        private Label label4;
        private Panel panel3;
        private TextBox TxtEmail;
        private Label label3;
        private Button Updatebtn;
    }
}