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
    public partial class MealUI : Form
    {
        public MealUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private MealManager aMealManager=new MealManager();

        private void saveButton_Click(object sender, EventArgs e)
        {

            Meal aMeal=new Meal();

            aMeal.MemberId = (int) nameComboBox.SelectedValue;
            aMeal.Date = Convert.ToDateTime(mealDateTimePicker.Text);
            try
            {
                aMeal.TotalMeal = Convert.ToDouble(totalMealTextBox.Text);

            }
            catch (Exception)
            {
                
                MessageBox.Show("Please input correct");
                return;
            }

            if (aMeal.MemberId == -1)
            {
                MessageBox.Show("Please Select Name");
                return;
            }
            
            string message = aMealManager.SaveMeal(aMeal);
            MessageBox.Show(message);
        }

        private void MealUI_Load(object sender, EventArgs e)
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




            GeMealList();
        }

        private void GeMealList()
        {
            mealListView.Items.Clear();

            HelperClass helper = new HelperClass();
            monthLabel.Text = helper.CurrentMonthAsString();
            int currentDate = helper.GetCurrentDate();
            int previousDate = currentDate - 3;

            string date = helper.GetCurrentMonthAsNumber();
            List<MemberWithMeal> memberWithMeallist = aMealManager.GetMealListThreeDay(currentDate, previousDate, date);

            int count = 0;
            foreach (var memberWithMeal in memberWithMeallist)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = memberWithMeal;
                item.Text = count++.ToString();
                item.SubItems.Add(memberWithMeal.MemberName.ToString());
                item.SubItems.Add(memberWithMeal.Date.ToString());
                item.SubItems.Add(memberWithMeal.TotalMeal.ToString());

                mealListView.Items.Add(item);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            nameComboBox.Text = string.Empty;
            totalMealTextBox.Clear();
            hiddenIdLabel.Text = string.Empty;
            GeMealList();
            removeButton.Enabled = false;
            saveButton.Text = "Save";
        }

        private void mealListView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void mealListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem mealListSelected = mealListView.SelectedItems[0];

            MemberWithMeal memberWithMeal = (MemberWithMeal)mealListSelected.Tag;

            nameComboBox.Text = memberWithMeal.MemberName;
            mealDateTimePicker.Text = memberWithMeal.Date.ToString();
            totalMealTextBox.Text = memberWithMeal.TotalMeal.ToString();
            hiddenIdLabel.Text = memberWithMeal.MemberId.ToString();
            saveButton.Text = "Update";
            removeButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        { 
            int memberId = Convert.ToInt32(hiddenIdLabel.Text);
            string date = mealDateTimePicker.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to Delete", "confirmation",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
            if (result == DialogResult.OK)
            {
             string message = aMealManager.RemoveMeal(memberId, date);
              MessageBox.Show(message);
            }
            GeMealList();
            Reset();
        }
    }
}
