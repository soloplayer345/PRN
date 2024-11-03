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
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class AdminForm : Form
    {
        MemberController memberController = new MemberController();
        public AdminForm()
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

        private void Read(int id)
        {
            List<Member> members = new List<Member>();
            members.Add(memberController.Get(id));
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

        private void MemberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberList.SelectedItems.Count == 0)
            {
                return;
            }
            TxtId.Text = MemberList.SelectedItems[0].SubItems[0].Text;
            TxtName.Text = MemberList.SelectedItems[0].SubItems[1].Text;
            TxtEmail.Text = MemberList.SelectedItems[0].SubItems[2].Text;
            TxtPassword.Text = MemberList.SelectedItems[0].SubItems[3].Text;
            TxtCity.Text = MemberList.SelectedItems[0].SubItems[4].Text;
            TxtCountry.Text = MemberList.SelectedItems[0].SubItems[5].Text;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MemberList.Items.Clear();
            Read();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            List<Member> members = memberController.Get();
            int id = members.Count + 1;
            memberController.Create(new Member
            {
                Id = id,
                Name = NameAdding.Text,
                Email = EmailAdding.Text,
                Password = PasswordAdding.Text,
                City = CityAdding.Text,
                Country = CountryAdding.Text
            });
            MemberList.Items.Clear();
            Read();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            if (MessageBox.Show("Are you sure you want to delete this member?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                memberController.Delete(id);
            }
            MemberList.Items.Clear();
            Read();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            String id = SearchedId.Text;
            MemberList.Items.Clear();
            if (id.Equals("")||id.Equals("0"))
            {
                Read();
            }
            else
            {
                Read(int.Parse(id));
            }
        }
    }
}
