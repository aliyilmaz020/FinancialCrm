namespace FinancialCrm
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.LblBanner = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LnkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.PbMinimize);
            this.panel2.Controls.Add(this.PbClose);
            this.panel2.Controls.Add(this.LblBanner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 46);
            this.panel2.TabIndex = 4;
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(536, 3);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(56, 40);
            this.PbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMinimize.TabIndex = 4;
            this.PbMinimize.TabStop = false;
            this.PbMinimize.Click += new System.EventHandler(this.PbMinimize_Click);
            // 
            // PbClose
            // 
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = global::FinancialCrm.Properties.Resources.icons8_close_window_96;
            this.PbClose.Location = new System.Drawing.Point(599, 3);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(56, 40);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbClose.TabIndex = 1;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // LblBanner
            // 
            this.LblBanner.AutoSize = true;
            this.LblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBanner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblBanner.Location = new System.Drawing.Point(11, 11);
            this.LblBanner.Name = "LblBanner";
            this.LblBanner.Size = new System.Drawing.Size(124, 25);
            this.LblBanner.TabIndex = 3;
            this.LblBanner.Text = "Hoşgeldiniz";
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Gray;
            this.TxtUserName.Location = new System.Drawing.Point(405, 149);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(209, 38);
            this.TxtUserName.TabIndex = 7;
            this.TxtUserName.Text = "Kullanıcı Adı";
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(405, 203);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(209, 38);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.Text = "Şifre";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Location = new System.Drawing.Point(405, 259);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(209, 41);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinancialCrm.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(348, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FinancialCrm.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(348, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LnkCreateAccount
            // 
            this.LnkCreateAccount.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.LnkCreateAccount.AutoSize = true;
            this.LnkCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.LnkCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkCreateAccount.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.LnkCreateAccount.LinkColor = System.Drawing.Color.White;
            this.LnkCreateAccount.Location = new System.Drawing.Point(433, 313);
            this.LnkCreateAccount.Name = "LnkCreateAccount";
            this.LnkCreateAccount.Size = new System.Drawing.Size(181, 25);
            this.LnkCreateAccount.TabIndex = 12;
            this.LnkCreateAccount.TabStop = true;
            this.LnkCreateAccount.Text = "Yeni Hesap Oluştur";
            this.LnkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCreateAccount_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FinancialCrm.Properties.Resources.blue_digital_technology_background_with_white_building_logo_bank_666034_682;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.LnkCreateAccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
//            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Label LblBanner;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel LnkCreateAccount;
        private System.Windows.Forms.Timer timer1;
    }
}