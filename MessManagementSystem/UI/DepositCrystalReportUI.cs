using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessManagementSystem.DataSet;
using MessManagementSystem.Manager;
using MessManagementSystem.Model;

namespace MessManagementSystem.UI
{
    public partial class DepositCrystalReportUI : Form
    {
        public DepositCrystalReportUI(string month)
        {
            InitializeComponent();


            DepositManager aDepositManager = new DepositManager();
            HelperClass helper = new HelperClass();


            List<MemberWithDeposit> depositList = aDepositManager.GetMemberWithDepositList(month);

            DepositCrystalReport depositCrystalReport = new DepositCrystalReport();
            depositCrystalReport.SetDataSource(depositList);
            //depositCrystalReport.SetParameterValue("Month", helper.CurrentMonthAsString());
            //shopingCrystalReportViewer.ReportSource = shopingCrystalReport;
            depositCrystalReportViewer.ReportSource = depositCrystalReport;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
