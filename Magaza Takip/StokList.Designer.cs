namespace Proje2._0
{
    partial class StokList
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
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dGVUrun = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStoktan = new System.Windows.Forms.Button();
            this.rdBStoktan = new System.Windows.Forms.RadioButton();
            this.rdBRaftan = new System.Windows.Forms.RadioButton();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYeniFiyat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGeri.Location = new System.Drawing.Point(12, 8);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(101, 44);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAra.Location = new System.Drawing.Point(203, 17);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(55, 29);
            this.lblAra.TabIndex = 42;
            this.lblAra.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(264, 22);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(139, 22);
            this.txtAra.TabIndex = 41;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGuncelle.Location = new System.Drawing.Point(427, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 36);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dGVUrun
            // 
            this.dGVUrun.AllowUserToAddRows = false;
            this.dGVUrun.AllowUserToDeleteRows = false;
            this.dGVUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUrun.Location = new System.Drawing.Point(12, 62);
            this.dGVUrun.Name = "dGVUrun";
            this.dGVUrun.ReadOnly = true;
            this.dGVUrun.RowHeadersWidth = 51;
            this.dGVUrun.RowTemplate.Height = 24;
            this.dGVUrun.Size = new System.Drawing.Size(1126, 406);
            this.dGVUrun.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Urun",
            "Fiyat",
            "Kategori",
            "Stok",
            "Raf"});
            this.comboBox1.Location = new System.Drawing.Point(578, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.Text = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStok.Location = new System.Drawing.Point(227, 495);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(61, 29);
            this.lblStok.TabIndex = 45;
            this.lblStok.Text = "Stok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(307, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "==>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(360, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Raf";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(40, 529);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 22);
            this.txtAdet.TabIndex = 46;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(360, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(227, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Raf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(307, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "==>";
            // 
            // btnStoktan
            // 
            this.btnStoktan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStoktan.Location = new System.Drawing.Point(458, 519);
            this.btnStoktan.Name = "btnStoktan";
            this.btnStoktan.Size = new System.Drawing.Size(104, 35);
            this.btnStoktan.TabIndex = 47;
            this.btnStoktan.Text = "Aktar";
            this.btnStoktan.UseVisualStyleBackColor = true;
            this.btnStoktan.Click += new System.EventHandler(this.btnStoktan_Click);
            // 
            // rdBStoktan
            // 
            this.rdBStoktan.AutoSize = true;
            this.rdBStoktan.Location = new System.Drawing.Point(181, 505);
            this.rdBStoktan.Name = "rdBStoktan";
            this.rdBStoktan.Size = new System.Drawing.Size(17, 16);
            this.rdBStoktan.TabIndex = 48;
            this.rdBStoktan.TabStop = true;
            this.rdBStoktan.UseVisualStyleBackColor = true;
            // 
            // rdBRaftan
            // 
            this.rdBRaftan.AutoSize = true;
            this.rdBRaftan.Location = new System.Drawing.Point(181, 564);
            this.rdBRaftan.Name = "rdBRaftan";
            this.rdBRaftan.Size = new System.Drawing.Size(17, 16);
            this.rdBRaftan.TabIndex = 48;
            this.rdBRaftan.TabStop = true;
            this.rdBRaftan.UseVisualStyleBackColor = true;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(765, 532);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(114, 22);
            this.txtFiyat.TabIndex = 49;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(676, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fiyat:";
            // 
            // btnYeniFiyat
            // 
            this.btnYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnYeniFiyat.Location = new System.Drawing.Point(914, 519);
            this.btnYeniFiyat.Name = "btnYeniFiyat";
            this.btnYeniFiyat.Size = new System.Drawing.Size(98, 38);
            this.btnYeniFiyat.TabIndex = 51;
            this.btnYeniFiyat.Text = "Belirle";
            this.btnYeniFiyat.UseVisualStyleBackColor = true;
            this.btnYeniFiyat.Click += new System.EventHandler(this.btnYeniFiyat_Click);
            // 
            // StokList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.btnYeniFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.rdBRaftan);
            this.Controls.Add(this.rdBStoktan);
            this.Controls.Add(this.btnStoktan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dGVUrun);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Name = "StokList";
            this.Text = "StokList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokList_FormClosing);
            this.Load += new System.EventHandler(this.StokList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dGVUrun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStoktan;
        private System.Windows.Forms.RadioButton rdBStoktan;
        private System.Windows.Forms.RadioButton rdBRaftan;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnYeniFiyat;
    }
}