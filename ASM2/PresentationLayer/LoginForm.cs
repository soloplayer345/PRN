using RepositoryLayer;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        MemberForm memberForm = new MemberForm();
        AdminForm AdminForm = new AdminForm();
        MemberController memberController = new MemberController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Member member = memberController.Login(EmailTextBox.Text, passwordTxt.Text);

            //if (member == null)
            //{
            //    MessageBox.Show("wrong account", "Error", MessageBoxButtons.OKCancel);
            //    return;
            //}
            this.Hide();
            //if (member.Email == "admin@fstore.com"&& member.Password== "admin@@")
            //{
            AdminForm.ShowDialog();
            //}
            //else
            //{
            //memberForm.ShowDialog();
            //}
            this.Show();

        }

        private void Form(object sender, FormClosingEventArgs e)
        {

        }

        private void FromClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
