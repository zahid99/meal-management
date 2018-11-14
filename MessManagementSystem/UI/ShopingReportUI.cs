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
    public partial class ShopingReportUI : Form
    {
        public ShopingReportUI()
        {
            InitializeComponent();

            LoadDailyMal();
        }

        private void ShopingReportUI_Load(object sender, EventArgs e)
        {


            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "MMMM";
            this.dailyShopingReportViewer.RefreshReport();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            shopingListView.Items.Clear();

            string month = dateTimePicker1.Value.Month.ToString();

            ShopingManager shopingManager=new ShopingManager();

            List<MemberWithShoping> shopingList = shopingManager.GetShopingList(month);

            int subcost = 0;
            foreach (var memberShoping in shopingList)
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


            LoadDailyMal(month);
        }

        private  void LoadDailyMal(string month)
        {
            MealManager aMealManager = new MealManager();

            //string month = dateTimePicker1.Value.Month.ToString();

            ShopingManager shopingManager = new ShopingManager();

            List<MemberWithShoping> shopingList = shopingManager.GetShopingList(month);

            dailyShopingReportViewer.LocalReport.DataSources.Clear(); //clear report
            dailyShopingReportViewer.LocalReport.ReportEmbeddedResource =
                "MessManagementSystem.Report.DailyShopingReport.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset =
                new Microsoft.Reporting.WinForms.ReportDataSource("DailyShoping", shopingList); // set the datasource
            dailyShopingReportViewer.LocalReport.DataSources.Add(dataset);
            dataset.Value = shopingList;
            //
            dailyShopingReportViewer.RefreshReport();
        }


        private void LoadDailyMal()
        {
            MealManager aMealManager = new MealManager();

           string month = DateTime.Now.Month.ToString();

            ShopingManager shopingManager = new ShopingManager();

            List<MemberWithShoping> shopingList = shopingManager.GetShopingList(month);

            dailyShopingReportViewer.LocalReport.DataSources.Clear(); //clear report
            dailyShopingReportViewer.LocalReport.ReportEmbeddedResource =
                "MessManagementSystem.Report.DailyShopingReport.rdlc"; // bind reportviewer with .rdlc
            Microsoft.Reporting.WinForms.ReportDataSource dataset =
                new Microsoft.Reporting.WinForms.ReportDataSource("DailyShoping", shopingList); // set the datasource
            dailyShopingReportViewer.LocalReport.DataSources.Add(dataset);
            dataset.Value = shopingList;
            //
            dailyShopingReportViewer.RefreshReport();
        }


    }
}
