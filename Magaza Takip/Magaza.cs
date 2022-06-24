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
    public partial class Magaza : Form
    {
        public Magaza()
        {
            InitializeComponent();
        }

        private void Magaza_Load(object sender, EventArgs e)
        {
            dGVUrunler.DataSource = Urun.UrunListele();
                dGVUrunler.Columns["Stok"].Visible = false;
        }

        private void Magaza_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if(dGVUrunler.SelectedRows.Count==0)
            {
                MessageBox.Show("Hata! Urun secmelisiniz!");
            }
            else
            {
                if(txtAdres.Text!=String.Empty||checkBox1.Checked)
                {
                    SiparisV();
                }
                else
                {
                    MessageBox.Show("Adres secilmedi!");
                }
            }



        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa ana = new Anasayfa();
            ana.Show();
        }
        void SiparisV()
        {
            int selectedrowindex = dGVUrunler.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dGVUrunler.Rows[selectedrowindex];
            int adet = int.Parse(numericUpDown1.Value.ToString());
            if (int.Parse(selectedRow.Cells["Raf"].Value.ToString()) < adet)
            {
                MessageBox.Show("Stokta yeterince urun yok");
            }
            else
            {

                string yazilacak = string.Empty;
                string[] lines = File.ReadAllLines("musteri.txt");
                bool error = true;
                if (lines.Length > 0)
                {
                    foreach (string line in lines)
                    {
                        if (line.Split('|')[2] == txtEmailSiparis.Text)
                        {
                            string[] columns = line.Split('|');
                            if (!checkBox1.Checked)
                            {
                                columns[4] = txtAdres.Text;
                                foreach (string column in columns)
                                {
                                    yazilacak += column + "|";
                                }
                            }
                            else
                            {
                                yazilacak = line + "|";
                            }
                            error = true;
                            break;

                        }
                        else
                        {
                            error = false;
                        }
                    }
                }
                else
                {
                    error = false;
                }
                if (dGVUrunler.SelectedRows.Count > 0 && int.Parse(numericUpDown1.Value.ToString()) > 0 && error != false)
                {
                    errorProvider1.Clear();




                    for (int i = 0; i <= 3; i++)
                    {
                        yazilacak += selectedRow.Cells[i].Value.ToString() + "|";
                    }

                    yazilacak += adet + "|";

                    double Fiyat = double.Parse(selectedRow.Cells["Fiyat"].Value.ToString());
                    yazilacak += adet * Fiyat + "|";
                    DateTime now = DateTime.Now;
                    yazilacak += now.Date.ToShortDateString() + "|";
                    yazilacak += now.ToString("HH:mm:ss");

                    using (StreamWriter writer = new StreamWriter(@"UrunSatis.txt", true))
                    {
                        writer.WriteLine(yazilacak);
                    }
                    string UrunId = selectedRow.Cells["ID"].Value.ToString();
                    try
                    {
                        string[] linesurun = File.ReadAllLines("urun.txt");
                        foreach (string line in linesurun)
                        {
                            string[] columns = line.Split('|');

                            if (UrunId == columns[0])
                            {

                                using (StreamWriter writer1 = new StreamWriter("urun.tmp"))
                                {
                                    foreach (string line1 in linesurun)
                                    {
                                        if (columns[0] == line1.Split('|')[0])
                                        {
                                            int Stok = int.Parse(columns[4]);
                                            int Raf = int.Parse(columns[5]) - adet;
                                            writer1.WriteLine(columns[0] + "|" + columns[1] + "|" + columns[2] + "|" + columns[3] + "|" + Stok + "|" + Raf);
                                        }
                                        else
                                        {
                                            writer1.WriteLine(line1);
                                        }
                                    }
                                }
                                File.Delete("urun.txt");
                                File.Move("urun.tmp", "urun.txt");
                                MessageBox.Show("Islem basarili!");
                                dGVUrunler.DataSource = Urun.UrunListele();
                            }

                        }
                    }
                    catch
                    {

                    }
                }
                else
                {

                    if (dGVUrunler.SelectedRows.Count == 0)
                    {
                        dGVUrunler.Focus();
                        MessageBox.Show("Urunu satir olarak seciniz.");
                        //errorProvider1.SetError(dGVUrunler, "Bir Urun seciniz!");
                    }
                    if (error == false)
                    {
                        MessageBox.Show("Musteri bulunamadi");
                    }

                }
            }


        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGVUrunler.DataSource = Urun.UrunAra(2,"Kategori", cmbKategori.Text);
        }
    }
   
}
