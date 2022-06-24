using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Proje2._0
{
    internal class Musteri
    {
        static bool first = true;
         
        public static void MusteriEkle(string Name, string Surname, string Telefon, string Email, string Adres)
        {
            string[] musteriformat = new string[] {Surname, Telefon, Email, Adres};




            using (StreamWriter writer = new StreamWriter("musteri.txt", true))
            {
                string result = string.Empty;
                result = Name;
                
                foreach (string a in musteriformat)
                {
                    result += "|" + a;

                }
                writer.WriteLine(result);
            }
        }
        public static DataTable MusteriSil(string email)
        {
            string[] lines = File.ReadAllLines("musteri.txt");
            using (StreamWriter writer = new StreamWriter("musteri.txt"))
            {
                musteriSayisi = -1;
                foreach (string line in lines)
                {
                    musteriSayisi++;
                
                    if (line.Split('|')[2]!=email)
                    {

                    
                        writer.WriteLine(line);
                    }
                }
            }
            return MusteriListele();
        }
        static DataTable table = new DataTable();

        public static int musteriSayisi=0;
        public static DataTable MusteriListele()
        {
            
            try
            {
                
                string[] lines = File.ReadAllLines("musteri.txt");
                table.Clear();
                if (first == true)
                {
                    table.Columns.Add("Ad", typeof(string));
                    table.Columns.Add("Soyad", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Telefon", typeof(string));
                    table.Columns.Add("Adres", typeof(string));
                }
                musteriSayisi = 0;
                foreach (string line in lines)
                {
                    musteriSayisi++;
                    string[] columns = line.Split('|');
                    table.Rows.Add(columns);
                }
                
                first = false;
                return table;
                

            }
            catch
            {
                return table;
            }
            
        }
        public static DataTable MusteriAra()
        {
            try
            {
                ComboBox combo = Application.OpenForms["MusteriListesi"].Controls["ComboBox1"] as ComboBox;
                TextBox textBox= Application.OpenForms["MusteriListesi"].Controls["txtAra"] as TextBox;
                
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", combo.Text, textBox.Text);

                return table;

            }
            catch 
            {
                return table;
            }
        }
    }
}

