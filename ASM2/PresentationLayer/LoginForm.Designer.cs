namespace PresentationLayer
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Login = new Button();
            panel3 = new Panel();
            passwordTxt = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            EmailTextBox = new TextBox();
            Email = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Login);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, -150);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 578);
            panel1.TabIndex = 0;
            // 
            // Login
            // 
            Login.Location = new Point(3, 326);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(passwordTxt);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 70);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(3, 27);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(427, 23);
            passwordTxt.TabIndex = 1;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Password";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(EmailTextBox);
            panel2.Controls.Add(Email);
            panel2.Location = new Point(0, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 68);
            panel2.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(3, 27);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(427, 23);
            EmailTextBox.TabIndex = 1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 9);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 428);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += FromClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Email;
        private TextBox EmailTextBox;
        private Panel panel3;
        private TextBox passwordTxt;
        private Label label1;
        private Button Login;
    }
}
