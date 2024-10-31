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

        private void MemberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberList.SelectedItems.Count == 0)
            {
                return;
            }
            Id.Text = MemberList.SelectedItems[0].SubItems[0].Text;
            Name.Text = MemberList.SelectedItems[0].SubItems[1].Text;
            Email.Text = MemberList.SelectedItems[0].SubItems[2].Text;
            Password.Text = MemberList.SelectedItems[0].SubItems[3].Text;
            City.Text = MemberList.SelectedItems[0].SubItems[4].Text;
            Country.Text = MemberList.SelectedItems[0].SubItems[5].Text;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Read();
        }
    }
}
