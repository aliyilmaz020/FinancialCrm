namespace FinancialCrm
{
    partial class FrmSpendings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpendings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdateSpending = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnListSpending = new System.Windows.Forms.Button();
            this.BtnAddSpending = new System.Windows.Forms.Button();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRemoveSpending = new System.Windows.Forms.Button();
            this.DtpSpendingDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSpendingId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBankProcesses = new System.Windows.Forms.Button();
            this.BtnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnBanks = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(907, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnUpdateSpending
            // 
            this.BtnUpdateSpending.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateSpending.Location = new System.Drawing.Point(503, 106);
            this.BtnUpdateSpending.Name = "BtnUpdateSpending";
            this.BtnUpdateSpending.Size = new System.Drawing.Size(263, 39);
            this.BtnUpdateSpending.TabIndex = 24;
            this.BtnUpdateSpending.Text = "Harcamayı Güncelle";
            this.BtnUpdateSpending.UseVisualStyleBackColor = false;
            this.BtnUpdateSpending.Click += new System.EventHandler(this.BtnUpdateSpending_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kategori:";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(247, 194);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(181, 33);
            this.CmbCategory.TabIndex = 22;
            // 
            // BtnListSpending
            // 
            this.BtnListSpending.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnListSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListSpending.Location = new System.Drawing.Point(503, 16);
            this.BtnListSpending.Name = "BtnListSpending";
            this.BtnListSpending.Size = new System.Drawing.Size(263, 39);
            this.BtnListSpending.TabIndex = 21;
            this.BtnListSpending.Text = "Harcamaları Listele";
            this.BtnListSpending.UseVisualStyleBackColor = false;
            this.BtnListSpending.Click += new System.EventHandler(this.BtnListSpending_Click);
            // 
            // BtnAddSpending
            // 
            this.BtnAddSpending.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnAddSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSpending.Location = new System.Drawing.Point(503, 61);
            this.BtnAddSpending.Name = "BtnAddSpending";
            this.BtnAddSpending.Size = new System.Drawing.Size(263, 39);
            this.BtnAddSpending.TabIndex = 20;
            this.BtnAddSpending.Text = "Harcamayı Kaydet";
            this.BtnAddSpending.UseVisualStyleBackColor = false;
            this.BtnAddSpending.Click += new System.EventHandler(this.BtnAddSpending_Click);
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(247, 108);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(181, 30);
            this.TxtAmount.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Miktar:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(265, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 275);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.TxtSpendingTitle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BtnRemoveSpending);
            this.panel3.Controls.Add(this.DtpSpendingDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BtnUpdateSpending);
            this.panel3.Controls.Add(this.BtnAddSpending);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CmbCategory);
            this.panel3.Controls.Add(this.BtnListSpending);
            this.panel3.Controls.Add(this.TxtAmount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtSpendingId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(265, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 238);
            this.panel3.TabIndex = 14;
            // 
            // TxtSpendingTitle
            // 
            this.TxtSpendingTitle.Location = new System.Drawing.Point(247, 65);
            this.TxtSpendingTitle.Name = "TxtSpendingTitle";
            this.TxtSpendingTitle.Size = new System.Drawing.Size(181, 30);
            this.TxtSpendingTitle.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Başlık:";
            // 
            // BtnRemoveSpending
            // 
            this.BtnRemoveSpending.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnRemoveSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveSpending.Location = new System.Drawing.Point(503, 151);
            this.BtnRemoveSpending.Name = "BtnRemoveSpending";
            this.BtnRemoveSpending.Size = new System.Drawing.Size(263, 39);
            this.BtnRemoveSpending.TabIndex = 27;
            this.BtnRemoveSpending.Text = "Harcamayı Sil";
            this.BtnRemoveSpending.UseVisualStyleBackColor = false;
            this.BtnRemoveSpending.Click += new System.EventHandler(this.BtnRemoveSpending_Click);
            // 
            // DtpSpendingDate
            // 
            this.DtpSpendingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpSpendingDate.Location = new System.Drawing.Point(250, 151);
            this.DtpSpendingDate.Name = "DtpSpendingDate";
            this.DtpSpendingDate.Size = new System.Drawing.Size(178, 30);
            this.DtpSpendingDate.TabIndex = 26;
            this.DtpSpendingDate.Value = new System.DateTime(2025, 1, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "İşlem Tarihi:";
            // 
            // TxtSpendingId
            // 
            this.TxtSpendingId.Location = new System.Drawing.Point(247, 22);
            this.TxtSpendingId.Name = "TxtSpendingId";
            this.TxtSpendingId.Size = new System.Drawing.Size(181, 30);
            this.TxtSpendingId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Harcama ID:";
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
            this.panel1.Controls.Add(this.BtnBanks);
            this.panel1.Controls.Add(this.BtnCategories);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 523);
            this.panel1.TabIndex = 12;
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
            this.BtnBankProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(232)))));
            this.BtnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBankProcesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBankProcesses.Location = new System.Drawing.Point(35, 263);
            this.BtnBankProcesses.Name = "BtnBankProcesses";
            this.BtnBankProcesses.Size = new System.Drawing.Size(192, 39);
            this.BtnBankProcesses.TabIndex = 4;
            this.BtnBankProcesses.Text = "Banka Hareketleri";
            this.BtnBankProcesses.UseVisualStyleBackColor = false;
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
            this.BtnBillForm.Text = "Faturalar";
            this.BtnBillForm.UseVisualStyleBackColor = true;
            this.BtnBillForm.Click += new System.EventHandler(this.BtnBillForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(36, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Giderler";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BtnBanks
            // 
            this.BtnBanks.BackColor = System.Drawing.Color.Transparent;
            this.BtnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBanks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBanks.Location = new System.Drawing.Point(36, 128);
            this.BtnBanks.Name = "BtnBanks";
            this.BtnBanks.Size = new System.Drawing.Size(192, 39);
            this.BtnBanks.TabIndex = 1;
            this.BtnBanks.Text = "Bankalar";
            this.BtnBanks.UseVisualStyleBackColor = false;
            this.BtnBanks.Click += new System.EventHandler(this.BtnBanks_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCategories.Location = new System.Drawing.Point(35, 83);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(192, 39);
            this.BtnCategories.TabIndex = 0;
            this.BtnCategories.Text = "Kategoriler";
            this.BtnCategories.UseVisualStyleBackColor = true;
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(1111, 3);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(57, 43);
            this.PbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMinimize.TabIndex = 11;
            this.PbMinimize.TabStop = false;
            this.PbMinimize.Click += new System.EventHandler(this.PbMinimize_Click);
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
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faturalar";
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1172, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBills";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdateSpending;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Button BtnListSpending;
        private System.Windows.Forms.Button BtnAddSpending;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtSpendingId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBankProcesses;
        private System.Windows.Forms.Button BtnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnBanks;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpSpendingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRemoveSpending;
        private System.Windows.Forms.TextBox TxtSpendingTitle;
        private System.Windows.Forms.Label label4;
    }
}