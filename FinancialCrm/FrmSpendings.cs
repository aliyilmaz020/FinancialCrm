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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public string username;
        void Clean()
        {
            TxtAmount.Text = "";
            TxtSpendingId.Text = "";
            TxtSpendingTitle.Text = "";
            DtpSpendingDate.Text = "";
            CmbCategory.Text = "";
        }
        void GetSpendings()
        {
            var values = db.Spendings.Join(db.Categories, d1 => d1.CategoryId, d2 => d2.CategoryId, (d1, d2) => new { d1, d2 })
                .Select(x => new
                {
                    x.d1.SpendingId,
                    x.d1.SpendingTitle,
                    x.d1.SpendingAmount,
                    x.d1.SpendingDate,
                    x.d2.CategoryName
                }).ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            GetSpendings();

            //cmbCategory
            var categories = db.Categories.ToList();
            CmbCategory.ValueMember = "CategoryId";
            CmbCategory.DisplayMember = "CategoryName";
            CmbCategory.DataSource = categories;
        }

        private void BtnListSpending_Click(object sender, EventArgs e)
        {
            GetSpendings();
        }

        private void BtnAddSpending_Click(object sender, EventArgs e)
        {
            try
            {
                Spendings sp = new Spendings();
                sp.SpendingTitle = TxtSpendingTitle.Text;
                sp.SpendingDate = DateTime.Parse(DtpSpendingDate.Text);
                sp.SpendingAmount = decimal.Parse(TxtAmount.Text);
                sp.CategoryId = int.Parse(CmbCategory.SelectedValue.ToString());
                db.Spendings.Add(sp);
                db.SaveChanges();
                MessageBox.Show("Yeni harcama başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSpendings();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();
        }

        private void BtnUpdateSpending_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtSpendingId.Text);
                var removeSpending = db.Spendings.Find(id);
                db.Spendings.Remove(removeSpending);
                db.SaveChanges();
                MessageBox.Show("Harcama bilgileri başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSpendings();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();
        }

        private void BtnRemoveSpending_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtSpendingId.Text);
                var updateSpending = db.Spendings.Find(id);
                updateSpending.CategoryId = int.Parse(CmbCategory.SelectedValue.ToString());
                updateSpending.SpendingDate = DateTime.Parse(DtpSpendingDate.Text);
                updateSpending.SpendingTitle = TxtSpendingTitle.Text;
                updateSpending.SpendingAmount = decimal.Parse(TxtAmount.Text);
                db.SaveChanges();
                MessageBox.Show("Harcama bilgileri başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSpendings();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
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

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
