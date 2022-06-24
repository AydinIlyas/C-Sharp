/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: İlyas Aydın
**				ÖĞRENCİ NUMARASI.......: B211210101
**                         DERSİN ALINDIĞI GRUP...: 1/B
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodlu_odev
{
    public partial class Form1 : Form
    {
        TextBox txtSayi = new TextBox();
        Label lblYazi = new Label();
        Button btnHesapla = new Button();
        public Form1()
        {

            InitializeComponent();
            Load += new EventHandler(Form1_Load);

            this.BackColor = Color.LightGray;
            btnHesapla.Font = new Font("Arial", 16);
            btnHesapla.Text = "Hesapla";
            btnHesapla.Left = 180;
            btnHesapla.Top = 230;
            btnHesapla.Size = new Size(100,40);
            this.Controls.Add(btnHesapla);
            btnHesapla.Click += new EventHandler(btnHesapla_Click);

            Label lblX=new Label();
            lblX.Text = "X";
            lblX.Left = 100;
            lblX.Top = 40;
            lblX.Font = new Font("Arial",15);
            lblX.AutoSize=true;
            this.Controls.Add(lblX);


            txtSayi.Left = 160;
            txtSayi.Top = 40;
            txtSayi.BorderStyle = BorderStyle.Fixed3D;
            txtSayi.KeyDown += new KeyEventHandler(txtSayi_KeyDown);
            this.Controls.Add(txtSayi);


            Label lblY = new Label();
            lblY.Text = "Y";
            lblY.Location = new Point(100, 140);
            lblY.Font = new Font("Arial", 15);
            lblY.AutoSize = true;
            this.Controls.Add(lblY);


            lblYazi.Location = new Point(160, 140);
            lblYazi.AutoSize = true;
            lblYazi.MinimumSize = new Size(100, 25);
            lblYazi.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(lblYazi);
        }

        void txtSayi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHesapla.PerformClick();
            }
        }
        void btnHesapla_Click(object sender,EventArgs e)
        {

            string sayi = txtSayi.Text.Replace('.',',');
            string bas = string.Empty;
            string son=string.Empty;
            bool istisnaerr = false;
            bas = sayi.Split(',')[0];
            if (sayi.Contains(','))
            {
                son = sayi.Split(',')[1];
                if(son==String.Empty)
                {
                    istisnaerr = true;
                }
            }

            if (double.TryParse(sayi, out double dsayi)&&dsayi>=0)
            {
                    if (bas.Length <= 5 && son.Length <= 2&&bas.Length>0&&!istisnaerr)
                    {

                    lblYazi.ForeColor = Color.Black;
                    lblYazi.Text = Hesapla();

                    }
                    else
                    {
                    lblYazi.ForeColor = Color.Red;
                    lblYazi.Text = "ERROR";

                        MessageBox.Show("SAYININ TAM KISMI EN FAZLA 5, ONDALIK KISMI İSE VIRGUL VARSA EN AZ 1,EN FAZLA 2 HANELİ OLMALIDIR.");
                    }
                
                
            }
            else
            {
                lblYazi.ForeColor = Color.Red;
                lblYazi.Text = "ERROR";
                MessageBox.Show("ERROR. LÜTFEN SIFIRDAN BÜYÜK BİR SAYI GİRİN.");
            }
        }

        string Hesapla()
        {
            string sonuc = string.Empty;
            string[] birler = new string[] { "", " BİR", " İKİ", " ÜÇ", " DÖRT", " BEŞ", " ALTI", " YEDİ", " SEKİZ", " DOKUZ" };

            string[] onlar = new string[] { "", " ON", " YİRMİ", " OTUZ", " KIRK", " ELLİ", " ALTMIŞ", " YETMİŞ", " SEKSEN", " DOKSAN" };

            string sayi = txtSayi.Text.Replace('.', ',');

            string tamkisim = sayi.Split(',')[0];
            string ondalikkesim = string.Empty;
            if (double.Parse(sayi) == 0)
            {
                sonuc = "SIFIR TL";
            }
            else
            {
                if (int.Parse(tamkisim) != 0)
                {
                    if (sayi.Length == 0 || double.Parse(tamkisim) == 0)
                    {
                        sonuc += "SIFIR";
                    }

                    double dtam = double.Parse(tamkisim);
                    int onbinler = (int)(dtam / 10000);
                    int binler = (int)(dtam % 10000) / 1000;
                    int yuzler = (int)((dtam % 1000) / 100);
                    int onluk = (int)(dtam % 100) / 10;
                    int birlik = (int)((dtam % 10));

                    if (onbinler != 0)
                    {
                        sonuc += onlar[onbinler];

                        if (binler == 0)
                        {
                            sonuc += " BİN";
                        }
                        else
                        {
                            sonuc += birler[binler] + " BİN";
                        }
                    }
                    else
                    {
                        if (binler != 0)
                        {
                            if (binler == 1)
                            {
                                sonuc += " BİN";
                            }
                            else
                            {
                                sonuc += birler[binler] + " BİN";
                            }
                        }

                    }

                    if (yuzler != 0)
                    {
                        if (yuzler == 1)
                        {
                            sonuc += (" YÜZ");
                        }
                        else
                        {
                            sonuc += (birler[yuzler] + " YÜZ");
                        }
                    }
                    sonuc += (onlar[onluk]) + (birler[birlik]);

                    sonuc += " TL";
                }

                if (sayi.Contains(','))
                {
                    ondalikkesim = sayi.Split(',')[1];

                    if (ondalikkesim.Length == 2)
                    {
                        int ondalik_1Hane;
                        int ondalik_2Hane;
                        int on = (int.Parse(ondalikkesim));
                        ondalik_1Hane = on / 10;
                        ondalik_2Hane = on % 10;


                        if (ondalik_1Hane != 0 || ondalik_2Hane != 0)
                        {
                            if (ondalik_1Hane != 0)
                            {
                                sonuc += (onlar[ondalik_1Hane]);
                            }

                            if (ondalik_2Hane != 0)
                            {
                                sonuc += (birler[ondalik_2Hane]);
                            }
                            sonuc += (" KURUŞ");
                        }

                    }
                    else if (ondalikkesim.Length == 1)
                    {
                        int on = int.Parse(ondalikkesim);
                        if (on != 0)
                        {
                            sonuc += ((onlar[on] + " KURUŞ"));
                        }
                    }
                }
            }
            return sonuc;
        }
        
        private void Form1_Load(object sender,EventArgs e)
        {
            this.ActiveControl = txtSayi;
        }

    }
}
