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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
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


            GetTotalMealAndCost();
        }

        MealManager aMealManager = new MealManager();
        DepositManager aDepositManager = new DepositManager();
        ShopingManager aShopingManager = new ShopingManager();

        private void GetTotalMealAndCost()
        {
            var totalMeal = GetTotalMeal();

            var totalShopingAmount = GetTotalShopingAmount();

            var perMeal = GetPerMealCost();


            totalMealLabel.Text = totalMeal.ToString();
            totalShopingCostLabel.Text = totalShopingAmount.ToString();
            perMealCostLabel.Text = perMeal.ToString();
        }

        private  double GetPerMealCost()
        {
            double perMeal = GetTotalShopingAmount() / GetTotalMeal();
            return perMeal;
        }

        private int GetTotalShopingAmount()
        {
            string date = DateTime.Now.Month.ToString();
            List<MemberWithShoping> shopingList = aShopingManager.GetShopingList(date);
            int totalShopingAmount = 0;
            foreach (var deposit in shopingList)
            {
                totalShopingAmount = totalShopingAmount + deposit.Cost;
            }
            return totalShopingAmount;
        }

        private double GetTotalMeal()
        {
            List<Meal> mealList = aMealManager.GetMealList();
            double totalMeal = 0;
            foreach (var meal in mealList)
            {
                totalMeal = totalMeal + meal.TotalMeal;
            }
            return totalMeal;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int memberId = (int) nameComboBox.SelectedValue;
            string date = DateTime.Now.Month.ToString();
            List<MemberWithDeposit> depositList = aDepositManager.MemberdDeposits(memberId,date);
            List<MemberWithMeal> memberWithMealList = aMealManager.GetMeals(memberId,date);

            int depositAmount=0;
            double totalMeal = 0;
            foreach (var deposit in depositList)
            {
                depositAmount = depositAmount + deposit.Amount;
            }


            foreach (var meal in memberWithMealList)
            {
                totalMeal += meal.TotalMeal;
            }


            totalDepositAmountLabel.Text = depositAmount.ToString();
            totalMealMemberlabel.Text = totalMeal.ToString();

            double totalCost = totalMeal*GetPerMealCost();
            totalMealCostLabel.Text = (totalCost).ToString();
            remainingAmountLabel.Text = (depositAmount - totalCost).ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            DashboardUI dUI = new DashboardUI();
            dUI.Show();
            this.Hide();
        }
    }
}
