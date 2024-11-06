using Microsoft.Extensions.Configuration;
using Service;

namespace SaleWinApp
{
    public partial class LoginForm : Form
    {
        private readonly IMemberService? memberRepository;
        IConfiguration? configuration;
        AdminForm adminForm = new AdminForm();
        MemberForm memberForm = new MemberForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (IsAdmin(EmailLogin.Text, PasswordLogin.Text))
            {
                this.Hide();                
                adminForm.ShowDialog();
                this.Show();
                return;

            }
            var member = memberRepository.MemberLogin(EmailLogin.Text, PasswordLogin.Text);
            if (member != null)
            {
                this.Hide();
                memberForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }

        }

        private bool IsAdmin(string email, string password)
        {
            var path = Directory.GetCurrentDirectory();
            this.configuration = new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json", true, true).Build();
            var adminEmail = configuration["admin-account:email"];
            var pass = configuration["admin-account:password"];
            return adminEmail.Equals(email) && pass.Equals(password);
        }
    }
}
