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
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        void Clean()
        {
            TxtPassword.UseSystemPasswordChar = false;
            TxtPassword.Text = "Şifre";
            TxtUserName.Text = "Kullanıcı Adı";
            TxtPassword.ForeColor = Color.Gray;
            TxtUserName.ForeColor = Color.Gray;
        }
        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;
            bool isUser = db.Users.Any(u => u.Username == username); //Kullanıcı kontrolü
            if (isUser == false)
            {
                if (username != "" && password != "" && username != "Kullanıcı Adı" && password != "Şifre")
                {
                    Users user = new Users();
                    user.Username = username;
                    user.Password = password;
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Hesabınız Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eksik bir tuşlama yapıldı.\nTekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı sistemde mevcuttur.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clean();
        }


        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "Kullanıcı Adı")
            {
                TxtUserName.Text = "";
                TxtUserName.ForeColor = Color.Black; // Yazı rengini varsayılan hale getir
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                TxtUserName.Text = "Kullanıcı Adı";
                TxtUserName.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Şifre")
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.Text = "Şifre";
                TxtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
