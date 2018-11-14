using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessManagementSystem.Gateway;
using MessManagementSystem.Manager;
using MessManagementSystem.Model;

namespace MessManagementSystem.UI
{
    public partial class CrystalReport : Form
    {
        public CrystalReport(int memberId)
        {
            InitializeComponent();

            string date = DateTime.Now.Month.ToString();
            ShowMemberInformation(memberId, date);
        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {
            //MealManager aMealManager = new MealManager();
            //List<Meal> mealList = aMealManager.GetMealList();

            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("SNo", typeof(string));
            //dataTable.Columns.Add("Date", typeof(string));
            //dataTable.Columns.Add("Meal", typeof(double));


            //foreach (var meal in mealList)
            //{
            //    dataTable.Rows.Add(meal.MealId.ToString(), meal.Date.ToString(), Convert.ToDouble(meal.TotalMeal));
            //}



            //MealCrystalReport mealCrystal = new MealCrystalReport();
            //mealCrystal.Database.Tables["MealDataTable"].SetDataSource(dataTable);
            //mealCrystalReportViewer.ReportSource = null;
            //mealCrystalReportViewer.ReportSource = mealCrystal;


           


            //MealManager aMealManager=new MealManager();
            //List<Meal> mealList = aMealManager.GetMealList();

            //MealCrystalReport mealCrystal = new MealCrystalReport();



            //MemberGateway aGateway = new MemberGateway();
            //Member member = aGateway.GetMemberById(19);

            //mealCrystal.SetDataSource(mealList);
            //mealCrystal.SetParameterValue("mName", member.MemberName.ToString());
            //mealCrystal.SetParameterValue("mPhone", member.MemberName.ToString());
            //mealCrystal.SetParameterValue("date", member.MemberName.ToString());
            //mealCrystalReportViewer.ReportSource = null;
            //mealCrystalReportViewer.ReportSource = mealCrystal;


           
        }


        public void ShowMemberInformation(int memberId,String date)
        {
           

            MealManager aMealManager = new MealManager();
            List<MemberWithMeal> mealList = aMealManager.GetMeals(memberId, date);
            MemberManager aMemberManager=new MemberManager();
            MemberGateway aGateway=new MemberGateway();
            Member member=aGateway.GetMemberById(memberId);

           // CrystalReport crystalReport=new CrystalReport();
            MealCrystalReport mealCrystal = new MealCrystalReport();
            mealCrystal.SetDataSource(mealList);
             mealCrystal.SetParameterValue("mName",member.MemberName.ToString());
             mealCrystal.SetParameterValue("mPhone", member.Phone.ToString());
             mealCrystal.SetParameterValue("date", DateTime.Today);
            mealCrystalReportViewer.ReportSource = mealCrystal;
        }
    }
}
