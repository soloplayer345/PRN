namespace SaleWinApp
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
            EmailLogin = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            PasswordLogin = new TextBox();
            label2 = new Label();
            Loginbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(EmailLogin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 53);
            panel1.TabIndex = 0;
            // 
            // EmailLogin
            // 
            EmailLogin.Location = new Point(3, 18);
            EmailLogin.Name = "EmailLogin";
            EmailLogin.Size = new Size(312, 23);
            EmailLogin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordLogin);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 53);
            panel2.TabIndex = 1;
            // 
            // PasswordLogin
            // 
            PasswordLogin.Location = new Point(3, 18);
            PasswordLogin.Name = "PasswordLogin";
            PasswordLogin.Size = new Size(312, 23);
            PasswordLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(0, 118);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(75, 23);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(Loginbtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox EmailLogin;
        private Label label1;
        private Panel panel2;
        private TextBox PasswordLogin;
        private Label label2;
        private Button Loginbtn;
    }
}
