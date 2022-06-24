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
    public partial class StokList : Form
    {
        public StokList()
        {
            InitializeComponent();
        }

        private void StokList_Load(object sender, EventArgs e)
        {
            dGVUrun.DataSource = Urun.UrunListele();
        }
        bool closeall = true;
        private void btnGeri_Click(object sender, EventArgs e)
        {
            closeall = false;
            this.Close();
            MagazaIslemleri magaza = new MagazaIslemleri();
            magaza.Show();


        }

        private void StokList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeall == true)
            { Application.Exit(); }
            closeall = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dGVUrun.DataSource = Urun.UrunAra(1,comboBox1.Text,txtAra.Text);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAra.Focus();
        }

        private void btnStoktan_Click(object sender, EventArgs e)
        {
            if (dGVUrun.SelectedRows.Count == 1 && txtAdet.Text != string.Empty)
            {
                string secim = string.Empty;
                int selectedrowindex = dGVUrun.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dGVUrun.Rows[selectedrowindex];
                if (rdBRaftan.Checked)
                {
                    secim = "RaftanStoka";
                    if (int.Parse(selectedRow.Cells[5].Value.ToString()) >= int.Parse(txtAdet.Text))
                    { dGVUrun.DataSource = Urun.UrunAktar(secim, selectedRow.Cells["ID"].Value.ToString(), txtAdet.Text); }
                    else
                    {
                        MessageBox.Show("Yeterince Urun Yok!");
                    }
                }
                else if (rdBStoktan.Checked)
                {
                    secim = "StoktanRafa";
                    if (int.Parse(selectedRow.Cells[4].Value.ToString()) >= int.Parse(txtAdet.Text))
                    { dGVUrun.DataSource = Urun.UrunAktar(secim, selectedRow.Cells["ID"].Value.ToString(), txtAdet.Text); }
                    else
                    {
                        MessageBox.Show("Yeterince Urun Yok!");
                    }
                }
                else
                {
                    MessageBox.Show("Yontem seciniz");
                }
            }
            else
            {
                MessageBox.Show("Urun Secip Adet Giriniz!");
            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != ',')
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
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void btnYeniFiyat_Click(object sender, EventArgs e)
        {
            if (dGVUrun.SelectedRows.Count == 1 && txtFiyat.Text != string.Empty)
            {
                int selectedrowindex = dGVUrun.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dGVUrun.Rows[selectedrowindex];
                dGVUrun.DataSource = Urun.UrunFiyatYenile( selectedRow.Cells["ID"].Value.ToString(), txtFiyat.Text);
                
            }
            else
            {
                MessageBox.Show("Urun Secip Adet Giriniz!");
            }
        }
    }
}
