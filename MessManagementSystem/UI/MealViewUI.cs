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
    public partial class MealViewUI : Form
    {
        public MealViewUI()
        {
            InitializeComponent();
        }



        double GeTotalMeal()
        {
            MealManager aMealManager=new MealManager();
            List<Meal> meals=aMealManager.GetMealList();

            double totalMeal = 0;
            foreach (var meal in meals)
            {
                totalMeal =(totalMeal + meal.TotalMeal);
            }
            return totalMeal;
        }

        
        private void viewButton_Click(object sender, EventArgs e)
        {
            mealListView.Items.Clear();
            MealManager aMealManager=new MealManager();
            int memberId = (int) nameComboBox.SelectedValue;

            string date = DateTime.Now.Month.ToString();
            List<MemberWithMeal> meals=aMealManager.GetMeals(memberId,date);


            double subtotal = 0;
            int count=1;
            foreach (var meal in meals)
            {
                subtotal = subtotal + meal.TotalMeal;
                ListViewItem item=new ListViewItem();
                item.Text = count++.ToString();
                item.SubItems.Add(meal.Date.ToString());
                item.SubItems.Add(meal.TotalMeal.ToString());
                item.SubItems.Add(subtotal.ToString());
                mealListView.Items.Add(item);

            }
        }

         
        private void MealViewUI_Load(object sender, EventArgs e)
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



            totalMealLabel.Text = GeTotalMeal().ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            DashboardUI dUI = new DashboardUI();
            //dUI.Show();
            this.Hide();
        }

        private void printButton_Click(object sender, EventArgs e)
        {

            int memberId = (int)nameComboBox.SelectedValue;
            CrystalReport crystalReport=new CrystalReport(memberId);
            crystalReport.Show();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
