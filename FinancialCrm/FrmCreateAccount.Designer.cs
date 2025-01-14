namespace FinancialCrm
{
    partial class FrmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateAccount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.PbMinimize);
            this.panel2.Controls.Add(this.PbClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 46);
            this.panel2.TabIndex = 13;
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(608, 3);
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
            this.PbClose.Location = new System.Drawing.Point(671, 3);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(56, 40);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbClose.TabIndex = 1;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Kullanıcı Kayıt Ekranı";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox2.Image = global::FinancialCrm.Properties.Resources.padlock_create;
            this.pictureBox2.Location = new System.Drawing.Point(242, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Image = global::FinancialCrm.Properties.Resources.user_create1;
            this.pictureBox1.Location = new System.Drawing.Point(242, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.BtnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCreateAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCreateAccount.Location = new System.Drawing.Point(299, 255);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(209, 41);
            this.BtnCreateAccount.TabIndex = 16;
            this.BtnCreateAccount.Text = "Hesap Oluştur";
            this.BtnCreateAccount.UseVisualStyleBackColor = false;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(299, 200);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(209, 38);
            this.TxtPassword.TabIndex = 15;
            this.TxtPassword.Text = "Şifre";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.LightCyan;
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Gray;
            this.TxtUserName.Location = new System.Drawing.Point(299, 145);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(209, 38);
            this.TxtUserName.TabIndex = 14;
            this.TxtUserName.Text = "Kullanıcı Adı";
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // FrmCreateAccount
            // 
            this.AcceptButton = this.BtnCreateAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FinancialCrm.Properties.Resources.geometric_gradient_futuristic_background_23_2149116406;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.PictureBox PbClose;
    }
}