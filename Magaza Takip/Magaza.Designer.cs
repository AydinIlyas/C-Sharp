namespace Proje2._0
{
    partial class Magaza
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
            this.dGVUrunler = new System.Windows.Forms.DataGridView();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEmailSiparis = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVUrunler
            // 
            this.dGVUrunler.AllowUserToAddRows = false;
            this.dGVUrunler.AllowUserToDeleteRows = false;
            this.dGVUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUrunler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUrunler.Location = new System.Drawing.Point(184, 37);
            this.dGVUrunler.Name = "dGVUrunler";
            this.dGVUrunler.ReadOnly = true;
            this.dGVUrunler.RowHeadersWidth = 51;
            this.dGVUrunler.RowTemplate.Height = 24;
            this.dGVUrunler.Size = new System.Drawing.Size(899, 377);
            this.dGVUrunler.TabIndex = 0;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(740, 582);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(111, 36);
            this.btnSiparisVer.TabIndex = 1;
            this.btnSiparisVer.Text = "Siparis Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(538, 596);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtEmailSiparis
            // 
            this.txtEmailSiparis.Location = new System.Drawing.Point(169, 489);
            this.txtEmailSiparis.Name = "txtEmailSiparis";
            this.txtEmailSiparis.Size = new System.Drawing.Size(156, 22);
            this.txtEmailSiparis.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMail.Location = new System.Drawing.Point(65, 486);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(66, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Email:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(169, 544);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(156, 22);
            this.txtAdres.TabIndex = 3;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdres.Location = new System.Drawing.Point(65, 540);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(70, 25);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(169, 582);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Kayitli Adresi Kullan";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(101, 44);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Hepsi",
            "Erkek",
            "Bayan",
            "Cocuk"});
            this.cmbKategori.Location = new System.Drawing.Point(205, 440);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(130, 24);
            this.cmbKategori.TabIndex = 10;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(91, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kategori:";
            // 
            // Magaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmailSiparis);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.dGVUrunler);
            this.Name = "Magaza";
            this.Text = "Magaza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Magaza_FormClosing);
            this.Load += new System.EventHandler(this.Magaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVUrunler;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmailSiparis;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}