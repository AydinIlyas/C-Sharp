namespace Proje2._0
{
    partial class TedarikciListe
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
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.dGVTedarikci = new System.Windows.Forms.DataGridView();
            this.pnlAlimlar = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.DataGridView();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnTedarikciler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.cmbFilter1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.pnlTedarikciEkle = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmailK = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGeriEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTedarikci)).BeginInit();
            this.pnlAlimlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.pnlTedarikciEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAra.Location = new System.Drawing.Point(213, 18);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(55, 29);
            this.lblAra.TabIndex = 44;
            this.lblAra.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(274, 22);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(139, 22);
            this.txtAra.TabIndex = 43;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGeri.Location = new System.Drawing.Point(12, 7);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(108, 42);
            this.btnGeri.TabIndex = 41;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(337, 561);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(124, 45);
            this.btnSatinAl.TabIndex = 45;
            this.btnSatinAl.Text = "Satin Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // dGVTedarikci
            // 
            this.dGVTedarikci.AllowUserToAddRows = false;
            this.dGVTedarikci.AllowUserToDeleteRows = false;
            this.dGVTedarikci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTedarikci.Location = new System.Drawing.Point(12, 55);
            this.dGVTedarikci.MultiSelect = false;
            this.dGVTedarikci.Name = "dGVTedarikci";
            this.dGVTedarikci.ReadOnly = true;
            this.dGVTedarikci.RowHeadersWidth = 14;
            this.dGVTedarikci.RowTemplate.Height = 24;
            this.dGVTedarikci.Size = new System.Drawing.Size(1138, 491);
            this.dGVTedarikci.TabIndex = 47;
            // 
            // pnlAlimlar
            // 
            this.pnlAlimlar.Controls.Add(this.cmbFilter);
            this.pnlAlimlar.Location = new System.Drawing.Point(12, 52);
            this.pnlAlimlar.Name = "pnlAlimlar";
            this.pnlAlimlar.Size = new System.Drawing.Size(1158, 606);
            this.pnlAlimlar.TabIndex = 48;
            // 
            // cmbFilter
            // 
            this.cmbFilter.AllowUserToAddRows = false;
            this.cmbFilter.AllowUserToDeleteRows = false;
            this.cmbFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmbFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmbFilter.Location = new System.Drawing.Point(0, 0);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.ReadOnly = true;
            this.cmbFilter.RowHeadersWidth = 14;
            this.cmbFilter.RowTemplate.Height = 24;
            this.cmbFilter.Size = new System.Drawing.Size(1155, 478);
            this.cmbFilter.TabIndex = 0;
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSiparisler.Location = new System.Drawing.Point(931, 7);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(124, 35);
            this.btnSiparisler.TabIndex = 49;
            this.btnSiparisler.Text = "Siparisler";
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTedarikciler.Location = new System.Drawing.Point(752, 9);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(161, 37);
            this.btnTedarikciler.TabIndex = 49;
            this.btnTedarikciler.Text = "Tedarikciler";
            this.btnTedarikciler.UseVisualStyleBackColor = true;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikciler_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Location = new System.Drawing.Point(419, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 40);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Email",
            "Telefon",
            "Urun ID",
            "Urun",
            "Kategori",
            "Birim Fiyati",
            "Adet",
            "Toplam Fiyat",
            "Tarih",
            "Saat"});
            this.comboBoxFilter.Location = new System.Drawing.Point(12, 10);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(126, 24);
            this.comboBoxFilter.TabIndex = 49;
            this.comboBoxFilter.Text = "Ad";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // cmbFilter1
            // 
            this.cmbFilter1.FormattingEnabled = true;
            this.cmbFilter1.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Email",
            "Telefon",
            "Urun ID",
            "Urun",
            "Kategori",
            "Birim Fiyati"});
            this.cmbFilter1.Location = new System.Drawing.Point(419, 22);
            this.cmbFilter1.Name = "cmbFilter1";
            this.cmbFilter1.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter1.TabIndex = 51;
            this.cmbFilter1.Text = "Ad";
            this.cmbFilter1.SelectedIndexChanged += new System.EventHandler(this.cmbFilter1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(16, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Stok icin:";
            // 
            // txtRaf
            // 
            this.txtRaf.Location = new System.Drawing.Point(121, 603);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(100, 22);
            this.txtRaf.TabIndex = 46;
            this.txtRaf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(20, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Raf icin:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(121, 551);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 46;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Location = new System.Drawing.Point(532, 556);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(161, 54);
            this.btnTedarikciEkle.TabIndex = 55;
            this.btnTedarikciEkle.Text = "Tedarikci Ekle";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // pnlTedarikciEkle
            // 
            this.pnlTedarikciEkle.Controls.Add(this.comboBox1);
            this.pnlTedarikciEkle.Controls.Add(this.btnKaydet);
            this.pnlTedarikciEkle.Controls.Add(this.txtFiyat);
            this.pnlTedarikciEkle.Controls.Add(this.txtUrun);
            this.pnlTedarikciEkle.Controls.Add(this.txtTelefon);
            this.pnlTedarikciEkle.Controls.Add(this.txtEmailK);
            this.pnlTedarikciEkle.Controls.Add(this.txtSoyad);
            this.pnlTedarikciEkle.Controls.Add(this.txtAd);
            this.pnlTedarikciEkle.Controls.Add(this.label7);
            this.pnlTedarikciEkle.Controls.Add(this.label6);
            this.pnlTedarikciEkle.Controls.Add(this.label5);
            this.pnlTedarikciEkle.Controls.Add(this.lblTelefon);
            this.pnlTedarikciEkle.Controls.Add(this.label4);
            this.pnlTedarikciEkle.Controls.Add(this.lblSoyad);
            this.pnlTedarikciEkle.Controls.Add(this.lblAd);
            this.pnlTedarikciEkle.Controls.Add(this.btnGeriEkle);
            this.pnlTedarikciEkle.Location = new System.Drawing.Point(1, 2);
            this.pnlTedarikciEkle.Name = "pnlTedarikciEkle";
            this.pnlTedarikciEkle.Size = new System.Drawing.Size(1181, 650);
            this.pnlTedarikciEkle.TabIndex = 56;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cocuk",
            "Bayan",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(559, 402);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 58;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnKaydet.Location = new System.Drawing.Point(441, 514);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(188, 46);
            this.btnKaydet.TabIndex = 57;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFiyat.Location = new System.Drawing.Point(559, 458);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(154, 30);
            this.txtFiyat.TabIndex = 53;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtUrun
            // 
            this.txtUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrun.Location = new System.Drawing.Point(559, 342);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(154, 30);
            this.txtUrun.TabIndex = 53;
            this.txtUrun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrun_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefon.Location = new System.Drawing.Point(559, 287);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 30);
            this.txtTelefon.TabIndex = 53;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtEmailK
            // 
            this.txtEmailK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailK.Location = new System.Drawing.Point(559, 219);
            this.txtEmailK.Name = "txtEmailK";
            this.txtEmailK.Size = new System.Drawing.Size(154, 30);
            this.txtEmailK.TabIndex = 54;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoyad.Location = new System.Drawing.Point(559, 157);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 30);
            this.txtSoyad.TabIndex = 55;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAd.Location = new System.Drawing.Point(559, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(154, 30);
            this.txtAd.TabIndex = 56;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(376, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(376, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(376, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 48;
            this.label5.Text = "Urun:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefon.Location = new System.Drawing.Point(376, 289);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(89, 26);
            this.lblTelefon.TabIndex = 48;
            this.lblTelefon.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(376, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 49;
            this.label4.Text = "Email:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoyad.Location = new System.Drawing.Point(376, 157);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(80, 26);
            this.lblSoyad.TabIndex = 50;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAd.Location = new System.Drawing.Point(376, 91);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(45, 26);
            this.lblAd.TabIndex = 51;
            this.lblAd.Text = "Ad:";
            // 
            // btnGeriEkle
            // 
            this.btnGeriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGeriEkle.Location = new System.Drawing.Point(18, 17);
            this.btnGeriEkle.Name = "btnGeriEkle";
            this.btnGeriEkle.Size = new System.Drawing.Size(108, 42);
            this.btnGeriEkle.TabIndex = 43;
            this.btnGeriEkle.Text = "Geri";
            this.btnGeriEkle.UseVisualStyleBackColor = true;
            this.btnGeriEkle.Click += new System.EventHandler(this.btnGeriEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(729, 556);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(151, 54);
            this.btnDegistir.TabIndex = 56;
            this.btnDegistir.Text = "Degistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(729, 621);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 20);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Degistirmeye izin ver";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(914, 556);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 54);
            this.btnSil.TabIndex = 58;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TedarikciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlAlimlar);
            this.Controls.Add(this.pnlTedarikciEkle);
            this.Controls.Add(this.btnTedarikciEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTedarikciler);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.dGVTedarikci);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbFilter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.checkBox1);
            this.Name = "TedarikciListe";
            this.Text = "TedarikciListe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TedarikciListe_FormClosing);
            this.Load += new System.EventHandler(this.TedarikciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTedarikci)).EndInit();
            this.pnlAlimlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.pnlTedarikciEkle.ResumeLayout(false);
            this.pnlTedarikciEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.DataGridView dGVTedarikci;
        private System.Windows.Forms.Panel pnlAlimlar;
        private System.Windows.Forms.DataGridView cmbFilter;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnTedarikciler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ComboBox cmbFilter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Panel pnlTedarikciEkle;
        private System.Windows.Forms.Button btnGeriEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmailK;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDegistir;
    }
}