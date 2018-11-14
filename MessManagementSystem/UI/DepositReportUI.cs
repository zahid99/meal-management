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
    public partial class DepositReportUI : Form
    {
        public DepositReportUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            depositReportListView.Items.Clear();
            int row = 1;
            int subTotal = 0;
            DepositManager aDepositManager=new DepositManager();
            int memberId = (int) nameComboBox.SelectedValue;

            string date = DateTime.Now.Month.ToString();
            List<MemberWithDeposit> memberWithDeposit = aDepositManager.MemberdDeposits(memberId,date);


            foreach (var deposit in memberWithDeposit)
            {

             
                ListViewItem item=new ListViewItem();

                item.Text =row++.ToString();
                item.SubItems.Add(deposit.Date.ToString());
                item.SubItems.Add(deposit.Amount.ToString());
                item.SubItems.Add((subTotal = subTotal + deposit.Amount).ToString());
                depositReportListView.Items.Add(item);
            }
        }

        private void DepositReportUI_Load(object sender, EventArgs e)
        {
            MemberManager aMemberManager=new MemberManager();
            Member defaultMember = new Member();
            defaultMember.MemeberId = -1;
            defaultMember.MemberName = "---Select--";

            List<Member> memberList = aMemberManager.GetMembers();
            memberList.Insert(0, defaultMember);
            nameComboBox.DataSource = memberList;
            nameComboBox.DisplayMember = "MemberName";
            nameComboBox.ValueMember = "MemeberId";


            GetGrouByDepositAmountList();


            string CurrentMonth = String.Format("{0:MMMM}", DateTime.Now).ToString();
            monthLabel.Text = CurrentMonth;
        }

        private void GetGrouByDepositAmountList()
        {
            string date = DateTime.Now.Month.ToString();
            DepositManager aDepositManager = new DepositManager();
            List<MemberWithDeposit> memberWithDeposits = aDepositManager.GetMemberWithDepositAmountGroupByName(date);
            int sno = 1;
            int subTotal = 0;
            foreach (var deposit in memberWithDeposits)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sno++.ToString();
                item.SubItems.Add(deposit.MemberName);
                item.SubItems.Add(deposit.Amount.ToString());
                item.SubItems.Add((subTotal = subTotal + deposit.Amount).ToString());
                depositListView.Items.Add(item);
            }
        }
    }
}
