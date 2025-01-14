namespace FinancialCrm
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBankProcesses = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnBanks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnUpdateBill = new System.Windows.Forms.Button();
            this.BtnDeleteBill = new System.Windows.Forms.Button();
            this.BtnCreateBill = new System.Windows.Forms.Button();
            this.BtnListBill = new System.Windows.Forms.Button();
            this.TxtBillPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBillAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBillTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBillId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1172, 49);
            this.panel2.TabIndex = 3;
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(1112, 3);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(57, 43);
            this.PbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMinimize.TabIndex = 4;
            this.PbMinimize.TabStop = false;
            this.PbMinimize.Click += new System.EventHandler(this.PbMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödeme ve Fatura Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnBankProcesses);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnBanks);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 521);
            this.panel1.TabIndex = 4;
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
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Location = new System.Drawing.Point(35, 353);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(192, 39);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Ayarlar";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(35, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = false;
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
            // BtnBanks
            // 
            this.BtnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBanks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBanks.Location = new System.Drawing.Point(36, 128);
            this.BtnBanks.Name = "BtnBanks";
            this.BtnBanks.Size = new System.Drawing.Size(192, 39);
            this.BtnBanks.TabIndex = 1;
            this.BtnBanks.Text = "Bankalar";
            this.BtnBanks.UseVisualStyleBackColor = true;
            this.BtnBanks.Click += new System.EventHandler(this.BtnBanks_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.BtnUpdateBill);
            this.panel3.Controls.Add(this.BtnDeleteBill);
            this.panel3.Controls.Add(this.BtnCreateBill);
            this.panel3.Controls.Add(this.BtnListBill);
            this.panel3.Controls.Add(this.TxtBillPeriod);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtBillAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtBillTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtBillId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(266, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 205);
            this.panel3.TabIndex = 5;
            // 
            // BtnUpdateBill
            // 
            this.BtnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUpdateBill.Location = new System.Drawing.Point(718, 161);
            this.BtnUpdateBill.Name = "BtnUpdateBill";
            this.BtnUpdateBill.Size = new System.Drawing.Size(177, 39);
            this.BtnUpdateBill.TabIndex = 11;
            this.BtnUpdateBill.Text = "Ödeme Güncelle";
            this.BtnUpdateBill.UseVisualStyleBackColor = true;
            this.BtnUpdateBill.Click += new System.EventHandler(this.BtnUpdateBill_Click);
            // 
            // BtnDeleteBill
            // 
            this.BtnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDeleteBill.Location = new System.Drawing.Point(535, 161);
            this.BtnDeleteBill.Name = "BtnDeleteBill";
            this.BtnDeleteBill.Size = new System.Drawing.Size(177, 39);
            this.BtnDeleteBill.TabIndex = 10;
            this.BtnDeleteBill.Text = "Ödeme Sil";
            this.BtnDeleteBill.UseVisualStyleBackColor = true;
            this.BtnDeleteBill.Click += new System.EventHandler(this.BtnDeleteBill_Click);
            // 
            // BtnCreateBill
            // 
            this.BtnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCreateBill.Location = new System.Drawing.Point(352, 161);
            this.BtnCreateBill.Name = "BtnCreateBill";
            this.BtnCreateBill.Size = new System.Drawing.Size(177, 39);
            this.BtnCreateBill.TabIndex = 9;
            this.BtnCreateBill.Text = "Yeni Ödeme";
            this.BtnCreateBill.UseVisualStyleBackColor = true;
            this.BtnCreateBill.Click += new System.EventHandler(this.BtnCreateBill_Click);
            // 
            // BtnListBill
            // 
            this.BtnListBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListBill.Location = new System.Drawing.Point(169, 161);
            this.BtnListBill.Name = "BtnListBill";
            this.BtnListBill.Size = new System.Drawing.Size(177, 39);
            this.BtnListBill.TabIndex = 8;
            this.BtnListBill.Text = "Ödeme Listesi";
            this.BtnListBill.UseVisualStyleBackColor = true;
            this.BtnListBill.Click += new System.EventHandler(this.BtnListBill_Click);
            // 
            // TxtBillPeriod
            // 
            this.TxtBillPeriod.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtBillPeriod.Location = new System.Drawing.Point(130, 125);
            this.TxtBillPeriod.Name = "TxtBillPeriod";
            this.TxtBillPeriod.Size = new System.Drawing.Size(765, 30);
            this.TxtBillPeriod.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Periyot:";
            // 
            // TxtBillAmount
            // 
            this.TxtBillAmount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtBillAmount.Location = new System.Drawing.Point(130, 89);
            this.TxtBillAmount.Name = "TxtBillAmount";
            this.TxtBillAmount.Size = new System.Drawing.Size(765, 30);
            this.TxtBillAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar:";
            // 
            // TxtBillTitle
            // 
            this.TxtBillTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtBillTitle.Location = new System.Drawing.Point(130, 53);
            this.TxtBillTitle.Name = "TxtBillTitle";
            this.TxtBillTitle.Size = new System.Drawing.Size(765, 30);
            this.TxtBillTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlık:";
            // 
            // TxtBillId
            // 
            this.TxtBillId.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtBillId.Location = new System.Drawing.Point(130, 17);
            this.TxtBillId.Name = "TxtBillId";
            this.TxtBillId.Size = new System.Drawing.Size(765, 30);
            this.TxtBillId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödeme Id:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(266, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 305);
            this.panel4.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1172, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme ve Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBankProcesses;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnBanks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnUpdateBill;
        private System.Windows.Forms.Button BtnDeleteBill;
        private System.Windows.Forms.Button BtnCreateBill;
        private System.Windows.Forms.Button BtnListBill;
        private System.Windows.Forms.TextBox TxtBillPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBillTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBillId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PbMinimize;
    }
}