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
    public partial class ShopingReportCrystalReportUI : Form
    {
        public ShopingReportCrystalReportUI(string month)
        {
            InitializeComponent();



            ShopingManager aShopingManager = new ShopingManager();
            HelperClass helper = new HelperClass();


            List<MemberWithShoping> shopingList = aShopingManager.GetShopingList(month);

            ShopingCrystalReport shopingCrystalReport = new ShopingCrystalReport();
            shopingCrystalReport.SetDataSource(shopingList);
            shopingCrystalReport.SetParameterValue("Month", helper.CurrentMonthAsString());
            shopingCrystalReportViewer.ReportSource = shopingCrystalReport;
        }


        public string GetMonth(string month)
        {
            return month;
        }
        private void ShopingReportUI_Load(object sender, EventArgs e)
        {

            
            
        }
    }
}
