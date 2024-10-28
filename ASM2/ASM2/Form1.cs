using PresentationLayer;
using RepositoryLayer;

namespace ASM2
{
    public partial class Form1 : Form
    {
        MemberController memberController = new MemberController();
        public Form1()
        {
            InitializeComponent();
        }

        public List<Member> ListView()
        {
            InitializeComponent();
            return memberController.Get;
        }
    }
}
