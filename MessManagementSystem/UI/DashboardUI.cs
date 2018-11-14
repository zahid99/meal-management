using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessManagementSystem.UI
{
    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            InitializeComponent();
        }

        private void aDDMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberUI member=new MemberUI();
            member.Show();
        }

        private void aDDCOSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopingUI shoping=new ShopingUI();
            shoping.Show();
            //this.Hide();
        }

        private void aDDMEALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealUI mUI=new MealUI();
            mUI.Show();
        }

        private void viewMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealViewUI mealViewUi=new MealViewUI();
            mealViewUi.Show();
        }

        private void aDDDEPOSITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DepositUI dUI=new DepositUI();
            dUI.Show();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositReportUI dUI=new DepositReportUI();
            dUI.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report=new Report();
            report.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUI aUI=new AboutUI();
            aUI.Show();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopingReportUI shopingReportUi=new ShopingReportUI();
            shopingReportUi.Show();


        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MealReportUI mui=new MealReportUI();
            mui.Show();
        }
    }
}
