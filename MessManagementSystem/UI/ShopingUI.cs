using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessManagementSystem.Manager;
using MessManagementSystem.Model;

namespace MessManagementSystem.UI
{
    public partial class ShopingUI : Form
    {
        public ShopingUI()
        {
            InitializeComponent();
        }

        private MemberManager aMemberManager = new MemberManager();
        private ShopingManager aShopingManager=new ShopingManager();
        private void ShopingUI_Load(object sender, EventArgs e)
        {
            GetMemberList();

            GetShopingListWithMember();
            string CurrentMonth = String.Format("{0:MMMM}", DateTime.Now).ToString();
            monthLabel.Text = CurrentMonth;
        }

        private void GetMemberList()
        {
            Member defaultMember = new Member();
            defaultMember.MemeberId = -1;
            defaultMember.MemberName = "---Select--";

            List<Member> memberList = aMemberManager.GetMembers();
            memberList.Insert(0, defaultMember);
            nameComboBox.DataSource = memberList;
            nameComboBox.DisplayMember = "MemberName";
            nameComboBox.ValueMember = "MemeberId";
        }

        private void GetShopingListWithMember()
        {
            string date = DateTime.Now.Month.ToString();

            shopingListView.Items.Clear();
            List<MemberWithShoping> memberShopingList = aShopingManager.GetShopingList(date);
            int subcost = 0;
            foreach (var memberShoping in memberShopingList)
            {

               
                subcost = subcost + memberShoping.Cost;
                ListViewItem item = new ListViewItem();
                item.Text = memberShoping.Date.ToString();
                item.SubItems.Add(memberShoping.MemberName);
                item.SubItems.Add(memberShoping.Cost.ToString());
                item.SubItems.Add(subcost.ToString());

                item.Tag = memberShoping;
                shopingListView.Items.Add(item);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ShopingModel aShoping=new ShopingModel();
            aShoping.MemberId = Convert.ToInt32(nameComboBox.SelectedValue);
            aShoping.Date = Convert.ToDateTime(shopingDateTimePicker.Text);

            if (aShoping.MemberId == -1)
            {
                MessageBox.Show("Please select name"); 
                return;
            }

            try
            {
                aShoping.Cost = Convert.ToInt32(costTextBox.Text);
            }
            catch (Exception exception)
            {
                
                MessageBox.Show("Input must be integer Number");
                
            }
            

            if (saveButton.Text == "Save")
            {
                string message = aShopingManager.SaveShopingCost(aShoping);
                MessageBox.Show(message);
            }
            else
            {
                
            }
            GetShopingListWithMember();
            Reset();
        }


        

        private void shopingListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem shopingListSelected = shopingListView.SelectedItems[0];

            MemberWithShoping memberWithShoping = (MemberWithShoping) shopingListSelected.Tag;

            nameComboBox.Text = memberWithShoping.MemberName;
            shopingDateTimePicker.Text = memberWithShoping.Date.ToString();
            costTextBox.Text = memberWithShoping.Cost.ToString();

            saveButton.Text = "Update";
            removeButton.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            nameComboBox.Text = string.Empty;
            costTextBox.Clear();
            hiddelIdLabel.Text = string.Empty;
            GetMemberList();
            removeButton.Enabled = false;
            saveButton.Text = "Save";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ShopingManager aShopingManager=new ShopingManager();
            string date = shopingDateTimePicker.Text.ToString();

            int memberId = Convert.ToInt32(nameComboBox.SelectedValue);

            string message = aShopingManager.RemoveShiopingCost(memberId, date);
            MessageBox.Show(message);
            GetShopingListWithMember();

            Reset();

           
        }

        private void printButton_Click(object sender, EventArgs e)
        {

            HelperClass helperClass=new HelperClass();
           ShopingReportCrystalReportUI shopingReportCrystalReportUi=new ShopingReportCrystalReportUI(helperClass.GetCurrentMonthAsNumber());
            shopingReportCrystalReportUi.Show();
        }
    }
}
