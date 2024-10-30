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
            TxtId.Text = MemberList.SelectedItems[0].SubItems[0].Text;
            TxtName.Text = MemberList.SelectedItems[0].SubItems[1].Text;
            TxtEmail.Text = MemberList.SelectedItems[0].SubItems[2].Text;
            TxtPassword.Text = MemberList.SelectedItems[0].SubItems[3].Text;
            TxtCity.Text = MemberList.SelectedItems[0].SubItems[4].Text;
            TxtCountry.Text = MemberList.SelectedItems[0].SubItems[5].Text;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            Read();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            memberController.Update(id, new Member
            {
                Id = id,
                Name = TxtName.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                City = TxtCity.Text,
                Country = TxtCountry.Text
            });
            MemberList.Items.Clear();
            Read();
        }
    }
}
