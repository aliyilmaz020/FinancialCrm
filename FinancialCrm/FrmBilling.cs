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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        void GetBills()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            GetBills();
        }
        private void BtnListBill_Click(object sender, EventArgs e)
        {
            GetBills();
        }
        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.BillTitle = TxtBillTitle.Text;
            bills.BillAmount = decimal.Parse(TxtBillAmount.Text);
            bills.BillPeriod = TxtBillPeriod.Text;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Yeni Ödeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBills();
        }

        private void BtnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBills();
        }

        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtBillId.Text);
            var updateValue = db.Bills.Find(id);
            updateValue.BillTitle = TxtBillTitle.Text;
            updateValue.BillAmount = decimal.Parse(TxtBillAmount.Text);
            updateValue.BillPeriod = TxtBillPeriod.Text;
            db.SaveChanges();
            MessageBox.Show("Ödemeniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetBills();
        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void BtnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }
    }
}
