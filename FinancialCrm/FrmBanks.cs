using FinancialCrm.Models;
using System;
using System.Drawing;
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
        public string username;
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            LblZiraatBalance.Text = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";
            LblVakifbankBalance.Text = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";
            LblIsBankBalance.Text = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";

            //Banka Hareketleri
            var bankProcesses = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(7).ToList(); // En son 7 işlemi alıyoruz

            GroupBox targetGroupBox = this.Controls.Find("groupBox1", true).FirstOrDefault() as GroupBox; // Hedef GroupBox (GroupBox'ınızın adını yazın)
            Panel panel = new Panel
            {
                Location = targetGroupBox.Location, // GroupBox'ın konumuna yerleştir
                Size = targetGroupBox.Size,         // Aynı boyut
                AutoScroll = true                   // Kaydırma çubuğunu etkinleştir
            };

            // Mevcut GroupBox'ı Panel'e ekle
            this.Controls.Remove(targetGroupBox);
            panel.Controls.Add(targetGroupBox);
            this.Controls.Add(panel);

            // GroupBox'ı Panel içine yerleştir
            targetGroupBox.Location = new Point(0, 0);
            if (targetGroupBox != null)
            {
                // Mevcut kontrolleri temizle (isteğe bağlı)
                targetGroupBox.Controls.Clear();

                int yPosition = 36; // İlk Label'ın Y pozisyonu
                foreach (var bankProcess in bankProcesses)
                {
                    Label dynamicLabel = new Label
                    {
                        Text = $"{bankProcess.Description} {bankProcess.Amount} ₺ {bankProcess.ProcessDate}\n" +
                               $"-----------------------------------------------------------------------------------------------------------------------------",
                        Location = new Point(6, yPosition),
                        AutoSize = false,
                    };

                    // Metnin boyutunu ölç ve yüksekliği ayarla
                    var textSize = TextRenderer.MeasureText(dynamicLabel.Text, dynamicLabel.Font);
                    dynamicLabel.Size = new Size(targetGroupBox.Width - 12, textSize.Height + 10);

                    // Label'ı GroupBox'a ekle
                    targetGroupBox.Controls.Add(dynamicLabel);

                    // Bir sonraki Label için Y pozisyonunu ayarla
                    yPosition += dynamicLabel.Height + 10; // Aralarına boşluk ekleyin
                }
            }
        }

        private void BtnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
