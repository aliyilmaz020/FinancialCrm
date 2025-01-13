using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            LblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            LblLastBankProcessAmount.Text = lastProcessAmount.ToString();

            //chart 1
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //chart2
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var billElectricalTitle = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                LblBillTitle.Text = "Elektrik Faturası";
                LblBillAmount.Text = billElectricalTitle.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var billNaturalGasTitle = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                LblBillTitle.Text = "Doğalgaz Faturası";
                LblBillAmount.Text = billNaturalGasTitle.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var billWaterTitle = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                LblBillTitle.Text = "Su Faturası";
                LblBillAmount.Text = billWaterTitle.ToString() + " ₺";
            }
            if (count % 6 == 5)
            {
                var billSportTitle = db.Bills.Where(x => x.BillTitle == "Bein Spor Faturası").Select(y => y.BillAmount).FirstOrDefault();
                LblBillTitle.Text = "Bein Spor Faturası";
                LblBillAmount.Text = billSportTitle.ToString() + " ₺";
            }
            if (count % 7 == 6)
            {
                var billInternetTitle = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                LblBillTitle.Text = "İnternet Faturası";
                LblBillAmount.Text = billInternetTitle.ToString() + " ₺";
            }

        }
    }
}
