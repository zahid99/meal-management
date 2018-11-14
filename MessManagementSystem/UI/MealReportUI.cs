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
using Microsoft.Reporting.WinForms;

namespace MessManagementSystem.UI
{
    public partial class MealReportUI : Form
    {
        public MealReportUI()
        {
            InitializeComponent();
        }

        private void MealReportUI_Load(object sender, EventArgs e)
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



          //  totalMealLabel.Text = GeTotalMeal().ToString();


            this.reportViewer1.RefreshReport();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
           // mealListView.Items.Clear();
            MealManager aMealManager = new MealManager();
            int memberId = (int)nameComboBox.SelectedValue;

            DateTime input =Convert.ToDateTime(searchTimePicker.Text) ;
            string date = input.Month.ToString();
            List<MemberWithMeal> meals = aMealManager.GetMeals(memberId, date);




            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            ////Providing DataSource for the Report  
            //ReportDataSource rds = new ReportDataSource("GetMealReport", meals);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();


            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "MessManagementSystem.Report.MealReport.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("GetMealReport", meals); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = meals;
            //
            reportViewer1.RefreshReport();


        }
    }
}
