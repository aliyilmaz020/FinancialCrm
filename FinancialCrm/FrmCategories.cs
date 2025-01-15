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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        public string username;
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        void Clean()
        {
            TxtCategoryId.Text = "";
            TxtCategoryName.Text = "";
        }
        void GetCategory()
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCategoryId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnListCategory_Click(object sender, EventArgs e)
        {
            GetCategory();
        }
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Categories category = new Categories();
                category.CategoryName = TxtCategoryName.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                MessageBox.Show("Yeni Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCategory();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();
        }

        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtCategoryId.Text);
                var updateCategory = db.Categories.Find(id);
                updateCategory.CategoryName = TxtCategoryName.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetCategory();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();

        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtCategoryId.Text);
                var removeCategory = db.Categories.Find(id);
                db.Categories.Remove(removeCategory);
                db.SaveChanges();
                MessageBox.Show("Kategori Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetCategory();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış ya da eksik bilgi girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clean();
        }
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            GetCategory();
        }

        private void BtnBanksForm_Click(object sender, EventArgs e)
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
        private void BtnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.username = username;
            frm.Show();
            this.Hide();
        }
    }
}
