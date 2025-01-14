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
        void GetProcesses()
        {
            var processes = db.ListBankProcess().ToList();
            dataGridView1.DataSource = processes;
        }
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var banks = db.Banks.Select(x=>new
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
            BankProcesses bp = new BankProcesses();
            bp.Description = RchDescription.Text;
            bp.Amount = decimal.Parse(TxtAmount.Text);
            bp.ProcessDate = DateTime.Parse(DtpProcessDate.Text);
            bp.ProcessType = TxtProcessType.Text;
            bp.BankId = int.Parse(CmbBank.SelectedValue.ToString());
            db.BankProcesses.Add(bp);
            db.SaveChanges();
            MessageBox.Show("İşleminiz Başarıyla Kaydedilmiştir.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetProcesses();

        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void BtnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void FrmDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
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

        
    }
}
