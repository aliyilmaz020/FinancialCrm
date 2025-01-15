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
        public string username;
        void Clean()
        {
            TxtBillAmount.Text = "";
            TxtBillId.Text = "";
            TxtBillPeriod.Text = "";
            TxtBillTitle.Text = "";
        }
        void GetBills()
        {
            var values = db.Bills.Select(x=>new
            {
                FaturaID = x.BillId,
                Başlık = x.BillTitle,
                Miktar = x.BillAmount,
                Dönem = x.BillPeriod
            }).ToList();
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
            try
            {
                Bills bills = new Bills();
                bills.BillTitle = TxtBillTitle.Text;
                bills.BillAmount = decimal.Parse(TxtBillAmount.Text.Replace(".", ","));
                bills.BillPeriod = TxtBillPeriod.Text;
                db.Bills.Add(bills);
                db.SaveChanges();
                MessageBox.Show("Yeni Ödeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBills();
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clean();
        }

        private void BtnDeleteBill_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtBillId.Text);
                var removeValue = db.Bills.Find(id);
                db.Bills.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Ödeme Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBills();
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clean();
        }

        private void BtnUpdateBill_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtBillId.Text);
                var updateValue = db.Bills.Find(id);
                updateValue.BillTitle = TxtBillTitle.Text;
                updateValue.BillAmount = decimal.Parse(TxtBillAmount.Text.Replace(".",","));
                updateValue.BillPeriod = TxtBillPeriod.Text;
                db.SaveChanges();
                MessageBox.Show("Ödemeniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBills();
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clean();
        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtBillId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtBillTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtBillAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtBillPeriod.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
