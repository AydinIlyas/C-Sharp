using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Proje2._0
{
    internal class Tedarikci
    {

        static bool first = true;
        static DataTable table = new DataTable();
        public static DataTable TedarikciListele()
        {
            table.Clear();
            if (first == true)
            {
                table.Columns.Add("Ad", typeof(string));
                table.Columns.Add("Soyad", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Telefon", typeof(string));
                table.Columns.Add("Urun ID", typeof(string));
                table.Columns.Add("Urun", typeof(string));
                table.Columns.Add("Kategori", typeof(string));
                table.Columns.Add("Birim Fiyati", typeof(string));
            }
            first = false;
            try
            {

                string[] lines = File.ReadAllLines("tedarikci.txt");
               
                foreach (string line in lines)
                {
                    string[] columns = line.Split('|');
                    table.Rows.Add(columns);
                }

                
                return table;


            }
            catch
            {
                return table;
            }
        }
        public static DataTable SiparisAra()
        {
            try
            {
                ComboBox combo = Application.OpenForms["TedarikciListe"].Controls["comboBoxFilter"] as ComboBox;
                TextBox textBox = Application.OpenForms["TedarikciListe"].Controls["txtFilter"] as TextBox;

                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", combo.Text, textBox.Text);

                return table;

            }
            catch
            {
                return table;
            }
        }
        public static DataTable TedarikciAra(string combo,string text)
        {
            try
            {
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", combo, text);

                return table;

            }
            catch
            {
                return table;
            }
        }
        public static void TedarikciEkle(string Name, string Surname, string Telefon, string Email,string Urun,string Kategori,string Fiyat)
        {
            int id=1;
            string UrunId = id.ToString();
            try
            {
                string[] lines = File.ReadAllLines("urun.txt");
                int tmpMax = Convert.ToInt32(lines[0].Split('|')[0]);
                foreach (string line in lines)
                {
                    if (Convert.ToInt32(line.Split('|')[0]) > tmpMax)
                    {
                        tmpMax = Convert.ToInt32(line.Split('|')[0]);
                    }



                }
                id = tmpMax + 1;
                UrunId = id.ToString();
            }
            catch { }
            string[] tedarikciformat = new string[] { Surname, Email,Telefon, UrunId, Urun, Kategori, Fiyat };




            using (StreamWriter writer = new StreamWriter("tedarikci.txt", true))
            {

                string result = string.Empty;
                result = Name;
                foreach (string a in tedarikciformat)
                {
                    result += "|" + a;

                }
                writer.WriteLine(result);
            }

        }

        public static DataTable TedarikciSil(string email)
        {
            string[] lines = File.ReadAllLines("tedarikci.txt");
            using (StreamWriter writer = new StreamWriter("tedarikci.txt"))
            {
                foreach (string line in lines)
                {

                    if (line.Split('|')[2] != email)
                    {


                        writer.WriteLine(line);
                    }
                }
            }
            return TedarikciListele();
        }

    }
}
