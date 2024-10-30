namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        MemberForm memberForm = new MemberForm();
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
            //if (memberController.Login(EmailTextBox.Text,passwordTxt.Text) != null) 
            //{
                this.Hide();
                memberForm.ShowDialog();
                this.Show();
            //}
            //else 
            //{
            //    MessageBox.Show("wrong account", "Error", MessageBoxButtons.OKCancel);
            //}
        }

        private void Form(object sender, FormClosingEventArgs e)
        {

        }

        private void FromClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
