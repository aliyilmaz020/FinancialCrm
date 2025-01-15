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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public string username;
        void GetProcesses()
        {
            var processes = db.GetProcess().ToList();
            dataGridView1.DataSource = processes;
        }
        void Clean()
        {
            TxtBankProcessId.Text = "";
            TxtAmount.Text = "";
            DtpProcessDate.Text = "";
            TxtProcessType.Text = "";
            CmbBank.Text = "";
            RchDescription.Text = "";
        }
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var banks = db.Banks.Select(x => new
            {
                x.BankId,
                x.BankTitle
            }).ToList();
            CmbBank.ValueMember = "BankId";
            CmbBank.DisplayMember = "BankTitle";
            CmbBank.DataSource = banks;
        }
        private void BtnListProcesses_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }
        private void BtnAddProcess_Click(object sender, EventArgs e)
        {
            try
            {
                BankProcesses bp = new BankProcesses();
                bp.Description = RchDescription.Text;
                bp.Amount = decimal.Parse(TxtAmount.Text);
                bp.ProcessDate = DateTime.Parse(DtpProcessDate.Text);
                bp.ProcessType = TxtProcessType.Text;
                bp.BankId = int.Parse(CmbBank.SelectedValue.ToString());
                db.BankProcesses.Add(bp);
                db.SaveChanges();
                MessageBox.Show("İşleminiz Başarıyla Kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProcesses();
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

        private void BtnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
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

        private void TxtFind_Enter(object sender, EventArgs e)
        {
            if (TxtFind.Text == "Ara")
            {
                TxtFind.Text = "";
                TxtFind.ForeColor = Color.Black;
            }
        }

        private void TxtFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFind.Text))
            {
                TxtFind.ForeColor = Color.DimGray;
                TxtFind.Text = "Ara";
            }
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            string find = TxtFind.Text;
            var values = db.BankProcesses.Join(db.Banks, d1 => d1.BankId, d2 => d2.BankId, (d1, d2) => new { d1, d2 }).
                Where(x => x.d1.Amount.ToString().Contains(find) || x.d1.Description.Contains(find) || x.d2.BankTitle.Contains(find) ||
                x.d1.ProcessType.Contains(find) || x.d1.ProcessDate.ToString().Contains(find)).Select(y => new
                {
                    İşlemID = y.d1.BankProcessId,
                    Açıklama = y.d1.Description,
                    İşlemTarihi = y.d1.ProcessDate,
                    İşlemTürü = y.d1.ProcessType,
                    Miktar = y.d1.Amount,
                    Banka = y.d2.BankTitle
                }).ToList();
            dataGridView1.DataSource = values;

        }
    }
}
