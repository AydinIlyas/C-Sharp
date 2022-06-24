namespace Proje2._0
{
    partial class MagazaIslemleri
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
            this.btnGeriGiris = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnTedarik = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeriGiris
            // 
            this.btnGeriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGeriGiris.Location = new System.Drawing.Point(12, 12);
            this.btnGeriGiris.Name = "btnGeriGiris";
            this.btnGeriGiris.Size = new System.Drawing.Size(104, 43);
            this.btnGeriGiris.TabIndex = 6;
            this.btnGeriGiris.Text = "Geri";
            this.btnGeriGiris.UseVisualStyleBackColor = true;
            this.btnGeriGiris.Click += new System.EventHandler(this.btnGeriGiris_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUrun.Location = new System.Drawing.Point(604, 110);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(189, 103);
            this.btnUrun.TabIndex = 7;
            this.btnUrun.Text = "Urunler";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnTedarik
            // 
            this.btnTedarik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTedarik.Location = new System.Drawing.Point(221, 280);
            this.btnTedarik.Name = "btnTedarik";
            this.btnTedarik.Size = new System.Drawing.Size(196, 110);
            this.btnTedarik.TabIndex = 7;
            this.btnTedarik.Text = "Tedarik";
            this.btnTedarik.UseVisualStyleBackColor = true;
            this.btnTedarik.Click += new System.EventHandler(this.btnTedarik_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRapor.Location = new System.Drawing.Point(604, 280);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(189, 110);
            this.btnRapor.TabIndex = 7;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMusteri.Location = new System.Drawing.Point(221, 110);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(196, 103);
            this.btnMusteri.TabIndex = 7;
            this.btnMusteri.Text = "Musteriler";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // MagazaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnTedarik);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnGeriGiris);
            this.Name = "MagazaIslemleri";
            this.Text = "MagazaIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MagazaIslemleri_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeriGiris;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnTedarik;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnMusteri;
    }
}