using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MemberForm : Form
    {
        MemberController memberController = new MemberController();
        public MemberForm()
        {
            InitializeComponent();
        }

        private void Read()
        {
            List<Member> members = memberController.Get();
            foreach (Member member in members)
            {
                ListViewItem listItem = MemberList.Items.Add(member.Id.ToString());
                listItem.SubItems.Add(member.Name);
                listItem.SubItems.Add(member.Email);
                listItem.SubItems.Add(member.Password);
                listItem.SubItems.Add(member.City);
                listItem.SubItems.Add(member.Country);
                MemberList.View = View.Details;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            Read();
        }
    }
}
