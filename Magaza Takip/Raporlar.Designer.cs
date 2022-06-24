namespace Proje2._0
{
    partial class Raporlar
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGelir = new System.Windows.Forms.Button();
            this.btnGider = new System.Windows.Forms.Button();
            this.pnlGider = new System.Windows.Forms.Panel();
            this.lblGiderSonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVGiderRapor = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlGelir = new System.Windows.Forms.Panel();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVGelir = new System.Windows.Forms.DataGridView();
            this.btnGeri1 = new System.Windows.Forms.Button();
            this.btnGeriP = new System.Windows.Forms.Button();
            this.lblSiparisSayi = new System.Windows.Forms.Label();
            this.lblSiparisSay = new System.Windows.Forms.Label();
            this.pnlGider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiderRapor)).BeginInit();
            this.pnlGelir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnGelir
            // 
            this.btnGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGelir.Location = new System.Drawing.Point(291, 264);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(170, 89);
            this.btnGelir.TabIndex = 1;
            this.btnGelir.Text = "Gelir";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // btnGider
            // 
            this.btnGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGider.Location = new System.Drawing.Point(568, 264);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(170, 89);
            this.btnGider.TabIndex = 1;
            this.btnGider.Text = "Gider";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // pnlGider
            // 
            this.pnlGider.Controls.Add(this.lblGiderSonuc);
            this.pnlGider.Controls.Add(this.label2);
            this.pnlGider.Controls.Add(this.dGVGiderRapor);
            this.pnlGider.Controls.Add(this.btnGeri);
            this.pnlGider.Location = new System.Drawing.Point(2, 0);
            this.pnlGider.Name = "pnlGider";
            this.pnlGider.Size = new System.Drawing.Size(1138, 651);
            this.pnlGider.TabIndex = 6;
            // 
            // lblGiderSonuc
            // 
            this.lblGiderSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGiderSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGiderSonuc.Location = new System.Drawing.Point(239, 604);
            this.lblGiderSonuc.Name = "lblGiderSonuc";
            this.lblGiderSonuc.Size = new System.Drawing.Size(164, 29);
            this.lblGiderSonuc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toplam Gider:";
            // 
            // dGVGiderRapor
            // 
            this.dGVGiderRapor.AllowUserToAddRows = false;
            this.dGVGiderRapor.AllowUserToDeleteRows = false;
            this.dGVGiderRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGiderRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiderRapor.Location = new System.Drawing.Point(33, 66);
            this.dGVGiderRapor.Name = "dGVGiderRapor";
            this.dGVGiderRapor.ReadOnly = true;
            this.dGVGiderRapor.RowHeadersWidth = 20;
            this.dGVGiderRapor.RowTemplate.Height = 24;
            this.dGVGiderRapor.Size = new System.Drawing.Size(1102, 517);
            this.dGVGiderRapor.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGeri.Location = new System.Drawing.Point(10, 9);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(95, 40);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pnlGelir
            // 
            this.pnlGelir.Controls.Add(this.lblToplamGelir);
            this.pnlGelir.Controls.Add(this.label3);
            this.pnlGelir.Controls.Add(this.dGVGelir);
            this.pnlGelir.Controls.Add(this.btnGeri1);
            this.pnlGelir.Controls.Add(this.lblSiparisSay);
            this.pnlGelir.Controls.Add(this.lblSiparisSayi);
            this.pnlGelir.Location = new System.Drawing.Point(12, 12);
            this.pnlGelir.Name = "pnlGelir";
            this.pnlGelir.Size = new System.Drawing.Size(1118, 642);
            this.pnlGelir.TabIndex = 7;
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToplamGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblToplamGelir.Location = new System.Drawing.Point(239, 604);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(164, 29);
            this.lblToplamGelir.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toplam Gelir:";
            // 
            // dGVGelir
            // 
            this.dGVGelir.AllowUserToAddRows = false;
            this.dGVGelir.AllowUserToDeleteRows = false;
            this.dGVGelir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGelir.Location = new System.Drawing.Point(33, 66);
            this.dGVGelir.Name = "dGVGelir";
            this.dGVGelir.ReadOnly = true;
            this.dGVGelir.RowHeadersWidth = 20;
            this.dGVGelir.RowTemplate.Height = 24;
            this.dGVGelir.Size = new System.Drawing.Size(1102, 517);
            this.dGVGelir.TabIndex = 6;
            // 
            // btnGeri1
            // 
            this.btnGeri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGeri1.Location = new System.Drawing.Point(10, 9);
            this.btnGeri1.Name = "btnGeri1";
            this.btnGeri1.Size = new System.Drawing.Size(95, 40);
            this.btnGeri1.TabIndex = 5;
            this.btnGeri1.Text = "Geri";
            this.btnGeri1.UseVisualStyleBackColor = true;
            this.btnGeri1.Click += new System.EventHandler(this.btnGeri1_Click);
            // 
            // btnGeriP
            // 
            this.btnGeriP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGeriP.Location = new System.Drawing.Point(12, 12);
            this.btnGeriP.Name = "btnGeriP";
            this.btnGeriP.Size = new System.Drawing.Size(95, 40);
            this.btnGeriP.TabIndex = 8;
            this.btnGeriP.Text = "Geri";
            this.btnGeriP.UseVisualStyleBackColor = true;
            this.btnGeriP.Click += new System.EventHandler(this.btnGeriP_Click);
            // 
            // lblSiparisSayi
            // 
            this.lblSiparisSayi.AutoSize = true;
            this.lblSiparisSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSiparisSayi.Location = new System.Drawing.Point(524, 604);
            this.lblSiparisSayi.Name = "lblSiparisSayi";
            this.lblSiparisSayi.Size = new System.Drawing.Size(174, 29);
            this.lblSiparisSayi.TabIndex = 9;
            this.lblSiparisSayi.Text = "Sipariş Sayısı:";
            // 
            // lblSiparisSay
            // 
            this.lblSiparisSay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSiparisSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSiparisSay.Location = new System.Drawing.Point(704, 603);
            this.lblSiparisSay.Name = "lblSiparisSay";
            this.lblSiparisSay.Size = new System.Drawing.Size(164, 29);
            this.lblSiparisSay.TabIndex = 7;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.pnlGelir);
            this.Controls.Add(this.pnlGider);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnGelir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGeriP);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Raporlar_FormClosing);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.pnlGider.ResumeLayout(false);
            this.pnlGider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiderRapor)).EndInit();
            this.pnlGelir.ResumeLayout(false);
            this.pnlGelir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGelir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGelir;
        private System.Windows.Forms.Button btnGider;
        private System.Windows.Forms.Panel pnlGider;
        private System.Windows.Forms.Label lblGiderSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVGiderRapor;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel pnlGelir;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVGelir;
        private System.Windows.Forms.Button btnGeri1;
        private System.Windows.Forms.Button btnGeriP;
        private System.Windows.Forms.Label lblSiparisSay;
        private System.Windows.Forms.Label lblSiparisSayi;
    }
}