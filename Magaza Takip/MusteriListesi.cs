using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2._0
{
    public partial class MusteriListesi : Form
    {
        DataTable table=new DataTable();
        public MusteriListesi()
        {
            InitializeComponent();
            
            
        }
        bool closeAll = true;
        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            closeAll= false;
            this.Close();
            MagazaIslemleri magaza= new MagazaIslemleri();
            magaza.Show();
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            pnlKayit.Visible = false;
           dGVMusteri.DataSource=Musteri.MusteriListele();
            lblMusteriler.Text = Musteri.musteriSayisi.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dGVMusteri.DataSource = Musteri.MusteriAra();
        }

        private void MusteriListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeAll==true)
            {
                Application.Exit();
            }
            closeAll= true;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void BoxlariTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmailK.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            //txtSifre.Clear();
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            pnlKayit.Visible = true;
        }
        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != string.Empty && txtSoyad.Text != string.Empty && txtEmailK.Text != string.Empty
                && txtTelefon.Text != string.Empty&&txtAdres.Text!=string.Empty)
            {
                bool noRepeat = true;
                try
                {
                    string[] lines = File.ReadAllLines("musteri.txt");
                    foreach (string line in lines)
                    {
                        if (line.Split('|')[2] == txtEmailK.Text)
                        {
                            noRepeat = false;
                            break;
                        }
                    }
                }
                catch { }
                if (IsValidEmail(txtEmailK.Text) && noRepeat)
                {
                    Musteri.MusteriEkle(txtAd.Text, txtSoyad.Text, txtEmailK.Text, txtTelefon.Text, txtAdres.Text);
                    lblMusteriler.Text = Musteri.musteriSayisi.ToString();
                    BoxlariTemizle();
                    MessageBox.Show("Kayit basarili");
                }
                else
                {
                    if (noRepeat == false)
                    {
                        MessageBox.Show("Mevcut musteri farkli mail deneyiniz");
                    }
                    else
                    {
                        MessageBox.Show("Gecersiz Email!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz!");
            }
        }

        private void btnGeriP_Click(object sender, EventArgs e)
        {
            pnlKayit.Visible = false;
            dGVMusteri.DataSource = Musteri.MusteriListele();
            lblMusteriler.Text=Musteri.musteriSayisi.ToString();
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmailK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\|"))
                e.Handled = true;
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\|"))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAra.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dGVMusteri.SelectedRows.Count > 0)
            {
                int selectedrowindex = dGVMusteri.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dGVMusteri.Rows[selectedrowindex];
                dGVMusteri.DataSource = Musteri.MusteriSil(selectedRow.Cells["Email"].Value.ToString());
                lblMusteriler.Text = Musteri.musteriSayisi.ToString();
            }
            else
            {
                MessageBox.Show("Lutfen bir satir secciniz!");
            }


        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("musteri.txt"))
            {
                
                foreach (DataGridViewRow dr in dGVMusteri.Rows)
                {
                    string sonuc = string.Empty;
                    for (int i =0;i<=4;i++)
                    {
                        
                        sonuc+=dr.Cells[i].Value.ToString();
                        if (i != 4)
                        {
                            sonuc += "|";
                        }
                    }
                    writer.WriteLine(sonuc);
                }


            }
        }

        private void checkBoxDegistir_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDegistir.Checked)
            {
                dGVMusteri.ReadOnly = false;
            }
            else
            {
                dGVMusteri.ReadOnly=true;
            }
        }
    }
}
