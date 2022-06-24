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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        
        private void btnMagaza_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagazaIslemleri magazaIslemleri = new MagazaIslemleri();
            magazaIslemleri.Show();

        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MusteriLogin musteriLogin = new MusteriLogin();
            //musteriLogin.Show();
            Magaza magaza =new Magaza();
            magaza.Show();
        }
    }
}
