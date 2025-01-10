using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            LblZiraatBalance.Text = db.Banks.Where(x=>x.BankTitle=="Ziraat Bankası").Select(y=> y.BankBalance).FirstOrDefault().ToString() + " ₺";
            LblVakifbankBalance.Text = db.Banks.Where(x=>x.BankTitle== "Vakıfbank").Select(y=> y.BankBalance).FirstOrDefault().ToString() + " ₺";
            LblIsBankBalance.Text = db.Banks.Where(x=>x.BankTitle=="İş Bankası").Select(y=> y.BankBalance).FirstOrDefault().ToString() + " ₺";
        }
    }
}
