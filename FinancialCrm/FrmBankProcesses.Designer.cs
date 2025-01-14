namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankProcesses));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnBanks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBankProcessId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbBank = new System.Windows.Forms.ComboBox();
            this.BtnListProcesses = new System.Windows.Forms.Button();
            this.BtnAddProcess = new System.Windows.Forms.Button();
            this.RchDescription = new System.Windows.Forms.RichTextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtProcessType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpProcessDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banka Hareketleri";
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
            this.PbMinimize.Location = new System.Drawing.Point(1111, 3);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(35, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.BtnBillForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnBanks);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 529);
            this.panel1.TabIndex = 6;
            // 
            // TxtBankProcessId
            // 
            this.TxtBankProcessId.Location = new System.Drawing.Point(176, 16);
            this.TxtBankProcessId.Name = "TxtBankProcessId";
            this.TxtBankProcessId.Size = new System.Drawing.Size(181, 30);
            this.TxtBankProcessId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Banka İşlem ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CmbBank);
            this.panel3.Controls.Add(this.BtnListProcesses);
            this.panel3.Controls.Add(this.BtnAddProcess);
            this.panel3.Controls.Add(this.RchDescription);
            this.panel3.Controls.Add(this.TxtAmount);
            this.panel3.Controls.Add(this.TxtProcessType);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.DtpProcessDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtBankProcessId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(271, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 217);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Banka:";
            // 
            // CmbBank
            // 
            this.CmbBank.FormattingEnabled = true;
            this.CmbBank.Location = new System.Drawing.Point(176, 172);
            this.CmbBank.Name = "CmbBank";
            this.CmbBank.Size = new System.Drawing.Size(181, 33);
            this.CmbBank.TabIndex = 22;
            // 
            // BtnListProcesses
            // 
            this.BtnListProcesses.Location = new System.Drawing.Point(602, 175);
            this.BtnListProcesses.Name = "BtnListProcesses";
            this.BtnListProcesses.Size = new System.Drawing.Size(165, 39);
            this.BtnListProcesses.TabIndex = 21;
            this.BtnListProcesses.Text = "İşlemleri Listele";
            this.BtnListProcesses.UseVisualStyleBackColor = true;
            this.BtnListProcesses.Click += new System.EventHandler(this.BtnListProcesses_Click);
            // 
            // BtnAddProcess
            // 
            this.BtnAddProcess.Location = new System.Drawing.Point(602, 132);
            this.BtnAddProcess.Name = "BtnAddProcess";
            this.BtnAddProcess.Size = new System.Drawing.Size(165, 39);
            this.BtnAddProcess.TabIndex = 20;
            this.BtnAddProcess.Text = "İşlem Ekle";
            this.BtnAddProcess.UseVisualStyleBackColor = true;
            this.BtnAddProcess.Click += new System.EventHandler(this.BtnAddProcess_Click);
            // 
            // RchDescription
            // 
            this.RchDescription.Location = new System.Drawing.Point(504, 16);
            this.RchDescription.Name = "RchDescription";
            this.RchDescription.Size = new System.Drawing.Size(263, 112);
            this.RchDescription.TabIndex = 19;
            this.RchDescription.Text = "";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(176, 133);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(181, 30);
            this.TxtAmount.TabIndex = 18;
            // 
            // TxtProcessType
            // 
            this.TxtProcessType.Location = new System.Drawing.Point(176, 94);
            this.TxtProcessType.Name = "TxtProcessType";
            this.TxtProcessType.Size = new System.Drawing.Size(181, 30);
            this.TxtProcessType.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Miktar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "İşlem Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Açıklama:";
            // 
            // DtpProcessDate
            // 
            this.DtpProcessDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpProcessDate.Location = new System.Drawing.Point(176, 55);
            this.DtpProcessDate.Name = "DtpProcessDate";
            this.DtpProcessDate.Size = new System.Drawing.Size(181, 30);
            this.DtpProcessDate.TabIndex = 12;
            this.DtpProcessDate.Value = new System.DateTime(2025, 1, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "İşlem Tarihi:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(271, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 296);
            this.panel4.TabIndex = 11;
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
            this.dataGridView1.Size = new System.Drawing.Size(900, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1172, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcesses";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnBanks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBankProcessId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpProcessDate;
        private System.Windows.Forms.RichTextBox RchDescription;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.TextBox TxtProcessType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddProcess;
        private System.Windows.Forms.Button BtnListProcesses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbBank;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}