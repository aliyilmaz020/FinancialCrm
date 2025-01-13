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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = TxtUserName.Text;
            string password = TxtPassword.Text;
            var userControl = db.Users.Any(x => x.Username == user && x.Password == password);
            if (userControl)
            {
                FrmBanks frm = new FrmBanks();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalıdır.\nTekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                TxtUserName.ForeColor = Color.White; // Yazı rengini varsayılan hale getir
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
            if(TxtPassword.Text == "Şifre")
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.White;
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
