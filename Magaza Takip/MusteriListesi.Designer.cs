namespace Proje2._0
{
    partial class MusteriListesi
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.dGVMusteri = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.pnlKayit = new System.Windows.Forms.Panel();
            this.btnGeriP = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmailK = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.checkBoxDegistir = new System.Windows.Forms.CheckBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblMusteriler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMusteri)).BeginInit();
            this.pnlKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGeri.Location = new System.Drawing.Point(12, 5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(101, 39);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGuncelle.Location = new System.Drawing.Point(407, 5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 41);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(262, 16);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(139, 22);
            this.txtAra.TabIndex = 38;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAra.Location = new System.Drawing.Point(201, 11);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(55, 29);
            this.lblAra.TabIndex = 39;
            this.lblAra.Text = "Ara:";
            // 
            // dGVMusteri
            // 
            this.dGVMusteri.AllowUserToAddRows = false;
            this.dGVMusteri.AllowUserToDeleteRows = false;
            this.dGVMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMusteri.Location = new System.Drawing.Point(281, 76);
            this.dGVMusteri.Name = "dGVMusteri";
            this.dGVMusteri.ReadOnly = true;
            this.dGVMusteri.RowHeadersWidth = 51;
            this.dGVMusteri.RowTemplate.Height = 24;
            this.dGVMusteri.Size = new System.Drawing.Size(800, 494);
            this.dGVMusteri.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Telefon",
            "Email",
            "Adres"});
            this.comboBox1.Location = new System.Drawing.Point(551, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "Ad";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMusteriEkle.Location = new System.Drawing.Point(23, 97);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(144, 59);
            this.btnMusteriEkle.TabIndex = 42;
            this.btnMusteriEkle.Text = "Musteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // pnlKayit
            // 
            this.pnlKayit.Controls.Add(this.btnGeriP);
            this.pnlKayit.Controls.Add(this.btnKaydet);
            this.pnlKayit.Controls.Add(this.txtAdres);
            this.pnlKayit.Controls.Add(this.txtTelefon);
            this.pnlKayit.Controls.Add(this.txtEmailK);
            this.pnlKayit.Controls.Add(this.txtSoyad);
            this.pnlKayit.Controls.Add(this.txtAd);
            this.pnlKayit.Controls.Add(this.lblAdres);
            this.pnlKayit.Controls.Add(this.lblTelefon);
            this.pnlKayit.Controls.Add(this.label1);
            this.pnlKayit.Controls.Add(this.lblSoyad);
            this.pnlKayit.Controls.Add(this.lblAd);
            this.pnlKayit.Location = new System.Drawing.Point(-1, -1);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(1160, 651);
            this.pnlKayit.TabIndex = 43;
            // 
            // btnGeriP
            // 
            this.btnGeriP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGeriP.Location = new System.Drawing.Point(28, 11);
            this.btnGeriP.Name = "btnGeriP";
            this.btnGeriP.Size = new System.Drawing.Size(111, 44);
            this.btnGeriP.TabIndex = 47;
            this.btnGeriP.Text = "Geri";
            this.btnGeriP.UseVisualStyleBackColor = true;
            this.btnGeriP.Click += new System.EventHandler(this.btnGeriP_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnKaydet.Location = new System.Drawing.Point(442, 520);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(188, 46);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdres.Location = new System.Drawing.Point(560, 361);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(247, 30);
            this.txtAdres.TabIndex = 42;
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefon.Location = new System.Drawing.Point(560, 293);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 30);
            this.txtTelefon.TabIndex = 42;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtEmailK
            // 
            this.txtEmailK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailK.Location = new System.Drawing.Point(560, 225);
            this.txtEmailK.Name = "txtEmailK";
            this.txtEmailK.Size = new System.Drawing.Size(154, 30);
            this.txtEmailK.TabIndex = 43;
            this.txtEmailK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailK_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoyad.Location = new System.Drawing.Point(560, 163);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 30);
            this.txtSoyad.TabIndex = 44;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAd.Location = new System.Drawing.Point(560, 95);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(154, 30);
            this.txtAd.TabIndex = 45;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAdres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdres.Location = new System.Drawing.Point(377, 361);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(75, 26);
            this.lblAdres.TabIndex = 36;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefon.Location = new System.Drawing.Point(377, 295);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(89, 26);
            this.lblTelefon.TabIndex = 37;
            this.lblTelefon.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(377, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Email:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoyad.Location = new System.Drawing.Point(377, 163);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(80, 26);
            this.lblSoyad.TabIndex = 39;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAd.Location = new System.Drawing.Point(377, 97);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(45, 26);
            this.lblAd.TabIndex = 40;
            this.lblAd.Text = "Ad:";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSil.Location = new System.Drawing.Point(23, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 60);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Secili Musteriyi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDegistir.Location = new System.Drawing.Point(23, 277);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(144, 57);
            this.btnDegistir.TabIndex = 45;
            this.btnDegistir.Text = "Degisiklikleri Kaydet";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // checkBoxDegistir
            // 
            this.checkBoxDegistir.AutoSize = true;
            this.checkBoxDegistir.Location = new System.Drawing.Point(23, 358);
            this.checkBoxDegistir.Name = "checkBoxDegistir";
            this.checkBoxDegistir.Size = new System.Drawing.Size(153, 20);
            this.checkBoxDegistir.TabIndex = 46;
            this.checkBoxDegistir.Text = "Degistirmeye izin ver";
            this.checkBoxDegistir.UseVisualStyleBackColor = true;
            this.checkBoxDegistir.CheckedChanged += new System.EventHandler(this.checkBoxDegistir_CheckedChanged);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMusteri.Location = new System.Drawing.Point(18, 413);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(134, 25);
            this.lblMusteri.TabIndex = 48;
            this.lblMusteri.Text = "Müşteri Sayısı";
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMusteriler.Location = new System.Drawing.Point(18, 449);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(0, 25);
            this.lblMusteriler.TabIndex = 48;
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dGVMusteri);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.checkBoxDegistir);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblMusteriler);
            this.Name = "MusteriListesi";
            this.Text = "MusteriListesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusteriListesi_FormClosing);
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMusteri)).EndInit();
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.DataGridView dGVMusteri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Panel pnlKayit;
        private System.Windows.Forms.Button btnGeriP;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmailK;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.CheckBox checkBoxDegistir;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblMusteriler;
    }
}