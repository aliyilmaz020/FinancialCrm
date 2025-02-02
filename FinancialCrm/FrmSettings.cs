﻿using FinancialCrm.Models;
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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        public string username;
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        void Clean()
        {
            TxtPassword.UseSystemPasswordChar = false;
            TxtConfirmPassword.UseSystemPasswordChar = false;
            TxtPassword.ForeColor = Color.LightGray;
            TxtConfirmPassword.ForeColor = Color.LightGray;
            TxtPassword.Text = "Yeni Şifre";
            TxtConfirmPassword.Text = "Yeni Şifreyi Onayla";
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LblUsername.Text = username;
        }
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            var user = db.Users.Where(x => x.Username == username).FirstOrDefault();

            if (TxtPassword.Text == TxtConfirmPassword.Text)
            {
                user.Password = TxtConfirmPassword.Text;
                db.SaveChanges();
                MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girilen şifreler eşleşmiyor.\nTekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clean();
        }
        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
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

        private void BtnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.username = username;
            frm.Show();
            this.Hide();
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Yeni Şifre")
            {
                TxtPassword.Text = "";
                TxtPassword.UseSystemPasswordChar = true;
                TxtPassword.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.Text = "Yeni Şifre";
                TxtPassword.ForeColor = Color.LightGray;
            }
        }
        private void TxtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.Text == "Yeni Şifreyi Onayla")
            {
                TxtConfirmPassword.Text = "";
                TxtConfirmPassword.UseSystemPasswordChar = true;
                TxtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
            {
                TxtConfirmPassword.UseSystemPasswordChar = false;
                TxtConfirmPassword.Text = "Yeni Şifreyi Onayla";
                TxtConfirmPassword.ForeColor = Color.LightGray;
            }
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
    }
}
