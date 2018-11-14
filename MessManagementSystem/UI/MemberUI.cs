using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessManagementSystem.Manager;
using MessManagementSystem.Model;

namespace MessManagementSystem.UI
{
    public partial class MemberUI : Form
    {
        public MemberUI()
        {
            InitializeComponent();
        }


        private MemberManager aMemberManager=new MemberManager();
        private void MemberUI_Load(object sender, EventArgs e)
        {
            GetMemberList();
        }

        private void GetMemberList()
        {
            memberListView.Items.Clear();
            List<Member> memberList = aMemberManager.GetMembers();

            foreach (var member in memberList)
            {

                ListViewItem item = new ListViewItem();
                item.Text = member.MemberName;
                item.SubItems.Add(member.Email);
                item.SubItems.Add(member.Phone);
                
                item.Tag = member;
                memberListView.Items.Add(item);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MemberManager aMemberManager = new MemberManager();
            Member aMember = new Member();
            aMember.MemberName = nameTextBox.Text;
            aMember.Email = emailTextBox.Text;
            aMember.Phone = phoneTextBox.Text;
            if (saveButton.Text == "Save")
            {
                  string message = aMemberManager.SaveMember(aMember);
                MessageBox.Show(message);
                GetMemberList();
                Reset();
            }
            else 
            {
                aMember.MemeberId = Convert.ToInt32(hiddelIdLabel.Text);
            
                string message = aMemberManager.UpdateMember(aMember);
                MessageBox.Show(message);
                GetMemberList();
                Reset();
            }
        

    }

        private void memberListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem memberSelected = memberListView.SelectedItems[0];

            Member aMember = (Member) memberSelected.Tag;

            nameTextBox.Text = aMember.MemberName;
            emailTextBox.Text = aMember.Email;
            phoneTextBox.Text = aMember.Phone;
            hiddelIdLabel.Text = aMember.MemeberId.ToString();
            saveButton.Text = "Update";
            removeBtton.Enabled = true;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            hiddelIdLabel.Text = string.Empty;
            removeBtton.Enabled = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete member?",
            "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int memberId = Convert.ToInt32(hiddelIdLabel.Text);
                string message = aMemberManager.RemoveMember(memberId);
                MessageBox.Show(message);
                GetMemberList();
                Reset();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            DashboardUI dUI = new DashboardUI();
            //dUI.Show();
            this.Hide();
        }

       
       
    }
}
