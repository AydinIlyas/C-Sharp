using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proje2._0
{
    public partial class TedarikciListe : Form
    {
        public TedarikciListe()
        {
            InitializeComponent();
        }

        private void TedarikciListe_Load(object sender, EventArgs e)
        {
            dGVTedarikci.DataSource=Tedarikci.TedarikciListele();
            dGVTedarikci.Columns[2].Width = 150;
            pnlAlimlar.Visible = false;
            pnlTedarikciEkle.Visible = false;
            panel1.Hide();
        }

        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{
        //    Tedarikci.TedarikciAra();
        //}

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"TedarikciAlim.txt", true))
            {
                if(dGVTedarikci.SelectedRows.Count>0&&txtStok.Text!=string.Empty&&txtRaf.Text!=string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    errorProvider3.Clear();
                    int selectedrowindex = dGVTedarikci.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dGVTedarikci.Rows[selectedrowindex];
                    foreach(DataGridViewCell cell in selectedRow.Cells)
                    {
                        writer.Write(cell.Value.ToString()+"|");
                    }
                    int adet = int.Parse(txtStok.Text) + int.Parse(txtRaf.Text);
                    writer.Write(adet+"|");
                    //string CFiyat=string.Empty;
                    //if (selectedRow.Cells["Birim Fiyati"].Value.ToString().Contains('.'))
                    //{
                    //    CFiyat = selectedRow.Cells["Birim Fiyati"].Value.ToString().Replace('.', ',');
                    //}
                    //else
                    //{
                    //    CFiyat = selectedRow.Cells["Birim Fiyati"].Value.ToString();
                    //}
                    double Fiyat = Convert.ToDouble(selectedRow.Cells["Birim Fiyati"].Value.ToString());
                    writer.Write(adet * Fiyat+"|");
                    DateTime now=DateTime.Now;
                    writer.Write(now.Date.ToShortDateString()+"|");
                    writer.WriteLine(now.ToString("HH:mm:ss"));

                    
                    bool bulundu = false;
                    string UrunId = selectedRow.Cells["Urun ID"].Value.ToString();
                    string UrunAd = selectedRow.Cells["Urun"].Value.ToString();
                    string Kategori = selectedRow.Cells["Kategori"].Value.ToString();
                    string strFiyat = selectedRow.Cells["Birim Fiyati"].Value.ToString();
                    string StokAdet = txtStok.Text;
                    string RafAdet = txtRaf.Text;
                    try
                    {
                        string[] lines = File.ReadAllLines("urun.txt");
                        foreach (string line in lines)
                        {
                            string[] columns = line.Split('|');

                            if (UrunId == columns[0])
                            {
                                bulundu = true;
                                using (StreamWriter writer1 = new StreamWriter("urun.tmp"))
                                {
                                    foreach (string line1 in lines)
                                    {
                                        if (columns[0] == line1.Split('|')[0])
                                        {
                                            int Stok = int.Parse(columns[4]) + int.Parse(txtStok.Text);
                                            int Raf = int.Parse(columns[5]) + int.Parse(txtRaf.Text);
                                            writer1.WriteLine(columns[0] + "|" + columns[1] + "|" + columns[2] + "|" + columns[3] + "|" + Stok + "|" + Raf);
                                        }
                                        else
                                        {
                                            writer1.WriteLine(line1);
                                        }
                                    }
                                }
                            }

                        }
                    }catch
                    {

                    }
                    if (bulundu == true)
                    {
                        File.Delete("urun.txt");
                        File.Move("urun.tmp", "urun.txt");
                    }
                    else
                    {
                        Urun.UrunEkle(UrunId,UrunAd,strFiyat, Kategori, StokAdet,RafAdet);
                    }
                    MessageBox.Show("Islem basarili!");
                }
                else
                {
                    MessageBox.Show("Islem Basarisiz.");
                    if (dGVTedarikci.SelectedRows.Count == 0)
                    {
                        dGVTedarikci.Focus();
                        errorProvider1.SetError(dGVTedarikci, "Bir tedarikci seciniz!");
                    }
                    if (string.IsNullOrEmpty(txtStok.Text))
                    {
                        txtStok.Focus();
                        errorProvider1.SetError(txtStok, "Stoka eklenecek urun adetini girmelisiniz!");
                    }
                    if (string.IsNullOrEmpty(txtRaf.Text))
                    {
                        txtRaf.Focus();
                        errorProvider2.SetError(txtRaf, "Rafa eklenecek urun adetini girmelisiniz!");
                    }
                }
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
        DataTable dt = new DataTable();
        public bool first=true;
        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            pnlAlimlar.Visible = true;
            panel1.Visible = true;
            dt.Clear();
            
            if (first == true)
            {

                dt.Columns.Add("Ad", typeof(string));
                dt.Columns.Add("Soyad", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Telefon", typeof(string));
                dt.Columns.Add("Urun ID", typeof(string));
                dt.Columns.Add("Urun", typeof(string));
                dt.Columns.Add("Kategori", typeof(string));
                dt.Columns.Add("Birim Fiyati", typeof(string));
                dt.Columns.Add("Adet", typeof(string));
                dt.Columns.Add("Toplam Fiyat", typeof(string));
                dt.Columns.Add("Tarih", typeof(string));
                dt.Columns.Add("Saat", typeof(string));
            }
            first = false;
            try
            {
                string[] lines = File.ReadAllLines("TedarikciAlim.txt");
                foreach (string line in lines)
                {
                    string[] columns = line.Split('|');

                    dt.Rows.Add(columns);
                }
                

                
            }
            catch { }
            cmbFilter.DataSource = dt;




        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pnlAlimlar.Visible=false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagazaIslemleri magaza = new MagazaIslemleri();
            magaza.Show();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (pnlAlimlar.Visible == false)
            { 
                dGVTedarikci.DataSource = Tedarikci.TedarikciAra(cmbFilter1.Text,txtAra.Text); 
            }
            else
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", comboBoxFilter.Text, txtAra.Text);
                cmbFilter.DataSource = dt;
            }
        }

        private void TedarikciListe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAra.Focus();
        }

        private void cmbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAra.Focus();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            pnlTedarikciEkle.Show();
        }
        private void btnGeriEkle_Click(object sender, EventArgs e)
        {
            pnlTedarikciEkle.Hide();
            dGVTedarikci.DataSource = Tedarikci.TedarikciListele();

        }
        public void BoxlariTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmailK.Clear();
            txtTelefon.Clear();
            txtEmailK.Clear();
            txtUrun.Clear();
            txtFiyat.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
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
            if (txtAd.Text != string.Empty && txtSoyad.Text != string.Empty && txtTelefon.Text != string.Empty 
                && txtEmailK.Text != string.Empty && txtUrun.Text != string.Empty &&comboBox1.Text!=string.Empty&& txtFiyat.Text!=string.Empty)
            {
                if (IsValidEmail(txtEmailK.Text)&&noRepeat)
                {
                    Tedarikci.TedarikciEkle(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtEmailK.Text, txtUrun.Text, comboBox1.Text, txtFiyat.Text);
                    BoxlariTemizle();
                    MessageBox.Show("Islem Tamamlandi");
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
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    &&e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (txtFiyat.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtFiyat.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtFiyat.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtFiyat.SelectionStart != txtFiyat.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtFiyat.Text.Substring(txtFiyat.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(txtFiyat.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtFiyat.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtFiyat.Text.Substring(sepratorPosition + 1);
                    if (txtFiyat.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            //if (_text.IndexOf('.') > -1)
            //{
            //    KeyChar = '.';
            //    return true;
            //}
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\|"))
                e.Handled = true;
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("tedarikci.txt"))
            {

                foreach (DataGridViewRow dr in dGVTedarikci.Rows)
                {
                    string sonuc = string.Empty;
                    for (int i = 0; i <= 7; i++)
                    {

                        sonuc += dr.Cells[i].Value.ToString();
                        if (i != 7)
                        {
                            sonuc += "|";
                        }
                    }
                    writer.WriteLine(sonuc);
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dGVTedarikci.SelectedRows.Count > 0)
            {
                int selectedrowindex = dGVTedarikci.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dGVTedarikci.Rows[selectedrowindex];
                dGVTedarikci.DataSource = Tedarikci.TedarikciSil(selectedRow.Cells["Email"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Lutfen Satir Seciniz!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                dGVTedarikci.ReadOnly = false;
            }
            else
            {
                dGVTedarikci.ReadOnly = true;
            }
        }
    }
}
