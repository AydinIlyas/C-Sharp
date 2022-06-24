using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2._0
{
    public partial class MagazaIslemleri : Form
    {
        public MagazaIslemleri()
        {
            InitializeComponent();
        }

        private void btnGeriGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa=new Anasayfa();
            anasayfa.Show();
        }

        private void MagazaIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriListesi musteri = new MusteriListesi();
            musteri.Show();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            this.Hide();
            StokList stok = new StokList();
            stok.Show();
        }

        private void btnTedarik_Click(object sender, EventArgs e)
        {
            this.Hide();
            TedarikciListe tedarikci = new TedarikciListe();
            tedarikci.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }
    }
}
