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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            pnlGider.Visible = false;
            pnlGelir.Visible = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            pnlGider.Visible = false;
        }

        private void Raporlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            pnlGider.Visible = true;
            dGVGiderRapor.DataSource = Rapor.Gider(dateTimePicker1);
            dGVGiderRapor.Columns["Soyad"].Width = 50;
            dGVGiderRapor.Columns["Email"].Width = 100;
            dGVGiderRapor.Columns["Urun ID"].Width = 50;
            lblGiderSonuc.Text = Rapor.toplamGider.ToString();
            Rapor.toplamGider = 0;
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            pnlGelir.Visible = true;
            dGVGelir.DataSource = Rapor.Gelir(dateTimePicker1);
            dGVGelir.Columns["Soyad"].Width = 50;
            dGVGelir.Columns["Email"].Width = 100;
            dGVGelir.Columns["Urun ID"].Width = 50;
            lblToplamGelir.Text = Rapor.toplamGelir.ToString();
            Rapor.toplamGelir = 0;
            lblSiparisSay.Text = Rapor.siparisSayisi.ToString();
        }

        private void btnGeri1_Click(object sender, EventArgs e)
        {
            pnlGelir.Visible = false;
        }

        private void btnGeriP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagazaIslemleri magaza = new MagazaIslemleri();
            magaza.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
