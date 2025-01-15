namespace FinancialCrm
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBankProcesses = new System.Windows.Forms.Button();
            this.BtnBillForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSpendings = new System.Windows.Forms.Button();
            this.BtnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PbMinimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCategoryId = new System.Windows.Forms.TextBox();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.BtnListCategory = new System.Windows.Forms.Button();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(232)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Location = new System.Drawing.Point(35, 353);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(192, 39);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Ayarlar";
            this.BtnSettings.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnBankProcesses);
            this.panel1.Controls.Add(this.BtnBillForm);
            this.panel1.Controls.Add(this.BtnSpendings);
            this.panel1.Controls.Add(this.BtnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 524);
            this.panel1.TabIndex = 24;
            // 
            // BtnSpendings
            // 
            this.BtnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpendings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSpendings.Location = new System.Drawing.Point(36, 173);
            this.BtnSpendings.Name = "BtnSpendings";
            this.BtnSpendings.Size = new System.Drawing.Size(192, 39);
            this.BtnSpendings.TabIndex = 2;
            this.BtnSpendings.Text = "Giderler";
            this.BtnSpendings.UseVisualStyleBackColor = true;
            this.BtnSpendings.Click += new System.EventHandler(this.BtnSpendings_Click);
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(35, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PbMinimize
            // 
            this.PbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMinimize.Image = global::FinancialCrm.Properties.Resources.icons8_minimize_50;
            this.PbMinimize.Location = new System.Drawing.Point(884, 3);
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
            this.panel2.Size = new System.Drawing.Size(944, 46);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategoriler";
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.TxtCategoryName.Location = new System.Drawing.Point(161, 103);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(181, 30);
            this.TxtCategoryName.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kategori Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kategori ID:";
            // 
            // TxtCategoryId
            // 
            this.TxtCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.TxtCategoryId.Enabled = false;
            this.TxtCategoryId.Location = new System.Drawing.Point(161, 64);
            this.TxtCategoryId.Name = "TxtCategoryId";
            this.TxtCategoryId.Size = new System.Drawing.Size(181, 30);
            this.TxtCategoryId.TabIndex = 28;
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.BackColor = System.Drawing.Color.Lavender;
            this.BtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCategory.Location = new System.Drawing.Point(518, 55);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(149, 39);
            this.BtnAddCategory.TabIndex = 30;
            this.BtnAddCategory.Text = "Kaydet";
            this.BtnAddCategory.UseVisualStyleBackColor = false;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.panel3.Controls.Add(this.BtnDeleteCategory);
            this.panel3.Controls.Add(this.BtnListCategory);
            this.panel3.Controls.Add(this.BtnUpdateCategory);
            this.panel3.Controls.Add(this.TxtCategoryName);
            this.panel3.Controls.Add(this.BtnAddCategory);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtCategoryId);
            this.panel3.Location = new System.Drawing.Point(265, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 189);
            this.panel3.TabIndex = 31;
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.BackColor = System.Drawing.Color.Lavender;
            this.BtnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCategory.Location = new System.Drawing.Point(518, 100);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(149, 39);
            this.BtnDeleteCategory.TabIndex = 33;
            this.BtnDeleteCategory.Text = "Sil";
            this.BtnDeleteCategory.UseVisualStyleBackColor = false;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnListCategory
            // 
            this.BtnListCategory.BackColor = System.Drawing.Color.Lavender;
            this.BtnListCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListCategory.Location = new System.Drawing.Point(363, 55);
            this.BtnListCategory.Name = "BtnListCategory";
            this.BtnListCategory.Size = new System.Drawing.Size(149, 39);
            this.BtnListCategory.TabIndex = 32;
            this.BtnListCategory.Text = "Listele";
            this.BtnListCategory.UseVisualStyleBackColor = false;
            this.BtnListCategory.Click += new System.EventHandler(this.BtnListCategory_Click);
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.BackColor = System.Drawing.Color.Lavender;
            this.BtnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCategory.Location = new System.Drawing.Point(363, 100);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(149, 39);
            this.BtnUpdateCategory.TabIndex = 31;
            this.BtnUpdateCategory.Text = "Güncelle";
            this.BtnUpdateCategory.UseVisualStyleBackColor = false;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(265, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 328);
            this.panel4.TabIndex = 34;
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
            this.dataGridView1.Size = new System.Drawing.Size(679, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBankProcesses;
        private System.Windows.Forms.Button BtnBillForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSpendings;
        private System.Windows.Forms.Button BtnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PbMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCategoryId;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnListCategory;
        private System.Windows.Forms.Button BtnUpdateCategory;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}