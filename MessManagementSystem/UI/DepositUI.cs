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
    public partial class DepositUI : Form
    {
        public DepositUI()
        {
            InitializeComponent();
        }

        private DepositManager aDepositManager=new DepositManager(); 


        private void saveDepositAmountButton_Click(object sender, EventArgs e)
        {
            DepositAmount deposit=new DepositAmount();
            deposit.MemberId = (int) nameComboBox.SelectedValue;
            deposit.Date = Convert.ToDateTime(depositDateTimePicker.Text);
            deposit.Amount = Convert.ToInt32(amountTextBox.Text);


            if (saveDepositAmountButton.Text == "Save")
            {
                string message = aDepositManager.SaveDeposit(deposit);
                MessageBox.Show(message);

            }
            else
            {
                deposit.MemberId = Convert.ToInt32(HiddenIdLabel.Text);
                string message = aDepositManager.UpdateDepositAmount(deposit);
                MessageBox.Show(message);
            }
            
            GeMemberWithDepositList();
            Reset();
        }

        private void DepositUI_Load(object sender, EventArgs e)
        {
            string CurrentMonth = String.Format("{0:MMMM}", DateTime.Now).ToString();
            monthLabel.Text = CurrentMonth;
            GetMemberList();


            GeMemberWithDepositList();
        }

        private void GetMemberList()
        {
            MemberManager aMemberManager = new MemberManager();
            Member defaultMember = new Member();
            defaultMember.MemeberId = -1;
            defaultMember.MemberName = "---Select--";

            List<Member> memberList = aMemberManager.GetMembers();
            memberList.Insert(0, defaultMember);
            nameComboBox.DataSource = memberList;
            nameComboBox.DisplayMember = "MemberName";
            nameComboBox.ValueMember = "MemeberId";
        }

        private void GeMemberWithDepositList()
        {
            int subtotal = 0;
            string date = DateTime.Now.Month.ToString();

            depositListView.Items.Clear();
            List<MemberWithDeposit> memberWithDepositList = aDepositManager.GetMemberWithDepositList(date);

            foreach (var member in memberWithDepositList)
            {
                subtotal = subtotal + member.Amount;
                ListViewItem item = new ListViewItem();

                item.Text = member.MemberName;
                item.SubItems.Add(member.Date.ToString());
                item.SubItems.Add(member.Amount.ToString());
                item.SubItems.Add(subtotal.ToString());
                item.Tag = member;
                depositListView.Items.Add(item);
            }
        }

        private void depositListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedMember = depositListView.SelectedItems[0];

            MemberWithDeposit memberWithDeposit = (MemberWithDeposit) selectedMember.Tag;

            depositDateTimePicker.Text = memberWithDeposit.Date.ToString();
            nameComboBox.Text = memberWithDeposit.MemberName.ToString();
            amountTextBox.Text = memberWithDeposit.Amount.ToString();
            HiddenIdLabel.Text = memberWithDeposit.MemberId.ToString();

            saveDepositAmountButton.Text = "Update";
            removeButton.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            saveDepositAmountButton.Text = "Save";
            amountTextBox.Clear();
            nameComboBox.Text = string.Empty;
            HiddenIdLabel.Text = string.Empty;
            removeButton.Enabled = false;
            GetMemberList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            DashboardUI dUI = new DashboardUI();
            //dUI.Show();
            this.Hide();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string month = "10";
            //shopingReportCrystal.GetMonth(month);
            DepositCrystalReportUI depositReportCrystal = new DepositCrystalReportUI(month);


            depositReportCrystal.Show();
        }
    }
}
