namespace Proje2._0
{
    partial class Anasayfa
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
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnMagaza = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblGiris.Location = new System.Drawing.Point(143, 136);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(243, 33);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Giriş Şekli giriniz:";
            // 
            // btnMagaza
            // 
            this.btnMagaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnMagaza.Location = new System.Drawing.Point(235, 231);
            this.btnMagaza.Name = "btnMagaza";
            this.btnMagaza.Size = new System.Drawing.Size(205, 113);
            this.btnMagaza.TabIndex = 2;
            this.btnMagaza.Text = "Mağaza";
            this.btnMagaza.UseVisualStyleBackColor = true;
            this.btnMagaza.Click += new System.EventHandler(this.btnMagaza_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnMusteri.Location = new System.Drawing.Point(596, 231);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(205, 113);
            this.btnMusteri.TabIndex = 3;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnMagaza);
            this.Controls.Add(this.btnMusteri);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnMagaza;
        private System.Windows.Forms.Button btnMusteri;
    }
}

