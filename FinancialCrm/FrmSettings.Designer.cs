namespace FinancialCrm
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBankProcesses = new System.Windows.Forms.Button();
            this.BtnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ayarlar";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.PbMinimize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 46);
            this.panel2.TabIndex = 7;
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(1108, 0);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(57, 43);
            this.PbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMinimize.TabIndex = 11;
            this.PbMinimize.TabStop = false;
            this.PbMinimize.Click += new System.EventHandler(this.PbMinimize_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogout.Location = new System.Drawing.Point(35, 398);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(192, 39);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "Çıkış Yap";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSettings.Enabled = false;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Location = new System.Drawing.Point(35, 353);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(192, 39);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Ayarlar";
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDashboard.Location = new System.Drawing.Point(35, 308);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(192, 39);
            this.BtnDashboard.TabIndex = 5;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnBankProcesses
            // 
            this.BtnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBankProcesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBankProcesses.Location = new System.Drawing.Point(35, 263);
            this.BtnBankProcesses.Name = "BtnBankProcesses";
            this.BtnBankProcesses.Size = new System.Drawing.Size(192, 39);
            this.BtnBankProcesses.TabIndex = 4;
            this.BtnBankProcesses.Text = "Banka Hareketleri";
            this.BtnBankProcesses.UseVisualStyleBackColor = true;
            this.BtnBankProcesses.Click += new System.EventHandler(this.BtnBankProcesses_Click);
            // 
            // BtnBillForm
            // 
            this.BtnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBillForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBillForm.Location = new System.Drawing.Point(35, 218);
            this.BtnBillForm.Name = "BtnBillForm";
            this.BtnBillForm.Size = new System.Drawing.Size(192, 39);
            this.BtnBillForm.TabIndex = 3;
            this.BtnBillForm.Text = "Giderler";
            this.BtnBillForm.UseVisualStyleBackColor = true;
            this.BtnBillForm.Click += new System.EventHandler(this.BtnBillForm_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(36, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnBanksForm
            // 
            this.BtnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBanksForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBanksForm.Location = new System.Drawing.Point(36, 128);
            this.BtnBanksForm.Name = "BtnBanksForm";
            this.BtnBanksForm.Size = new System.Drawing.Size(192, 39);
            this.BtnBanksForm.TabIndex = 1;
            this.BtnBanksForm.Text = "Bankalar";
            this.BtnBanksForm.UseVisualStyleBackColor = true;
            this.BtnBanksForm.Click += new System.EventHandler(this.BtnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(35, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnBankProcesses);
            this.panel1.Controls.Add(this.BtnBillForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 531);
            this.panel1.TabIndex = 6;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TxtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPassword.Location = new System.Drawing.Point(837, 261);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(246, 30);
            this.TxtPassword.TabIndex = 18;
            this.TxtPassword.Text = "Yeni Şifre";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Location = new System.Drawing.Point(954, 217);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(45, 25);
            this.LblUsername.TabIndex = 22;
            this.LblUsername.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(832, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassword.Location = new System.Drawing.Point(837, 345);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(246, 36);
            this.BtnChangePassword.TabIndex = 21;
            this.BtnChangePassword.Text = "Şifreyi Değiştir";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.LightGray;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(837, 300);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(246, 30);
            this.TxtConfirmPassword.TabIndex = 20;
            this.TxtConfirmPassword.Text = "Yeni Şifreyi Onayla";
            this.TxtConfirmPassword.Enter += new System.EventHandler(this.TxtConfirmPassword_Enter);
            this.TxtConfirmPassword.Leave += new System.EventHandler(this.TxtConfirmPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinancialCrm.Properties.Resources.password_background1;
            this.pictureBox1.Location = new System.Drawing.Point(316, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1172, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBankProcesses;
        private System.Windows.Forms.Button BtnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}