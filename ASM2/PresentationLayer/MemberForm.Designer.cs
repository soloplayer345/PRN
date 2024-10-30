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
            ListViewItem listViewItem1 = new ListViewItem("");
            splitContainer1 = new SplitContainer();
            MemberList = new ListView();
            Id = new ColumnHeader();
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            Password = new ColumnHeader();
            City = new ColumnHeader();
            Country = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(MemberList);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // MemberList
            // 
            MemberList.Columns.AddRange(new ColumnHeader[] { Id, Name, Email, Password, City, Country });
            MemberList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            MemberList.Location = new Point(3, 0);
            MemberList.Name = "MemberList";
            MemberList.Size = new Size(527, 447);
            MemberList.TabIndex = 0;
            MemberList.UseCompatibleStateImageBehavior = false;
            MemberList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Text = "MemberForm";
            Load += MemberForm_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
    }
}