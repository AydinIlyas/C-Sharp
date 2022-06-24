using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proje2._0
{
    internal class Rapor
    {
        static bool first = true;
        public static double toplamGider = 0;
        public static double toplamGelir = 0;
        public static DataTable Gider(DateTimePicker date)
        {
            DataTable dt = new DataTable();
            if(first==true)
            {
                dt.Columns.Add("Ad", typeof(string));
                dt.Columns.Add("Soyad", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Telefon", typeof(string));
                dt.Columns.Add("Urun ID", typeof(string));
                dt.Columns.Add("Urun", typeof(string));
                dt.Columns.Add("Kategori", typeof(string));
                dt.Columns.Add("Birim Fiyati", typeof(double));
                dt.Columns.Add("Adet", typeof(int));
                dt.Columns.Add("Toplam Fiyat", typeof(double));
                dt.Columns.Add("Tarih", typeof(string));
                dt.Columns.Add("Saat", typeof(string));

            }
            try
            {
                string[] lines = File.ReadAllLines("TedarikciAlim.txt");
                foreach (string line in lines)
                {
                    string[] columns = line.Split('|');
                    if (columns[10] == date.Value.ToShortDateString())
                    {
                        toplamGider += double.Parse(columns[9]);
                        dt.Rows.Add(columns);
                    }


                }
            }
            catch { }
            return dt;


        }
        public static int siparisSayisi;
        public static DataTable Gelir(DateTimePicker date)
        {
            DataTable dt = new DataTable();
            if (first == true)
            {
                dt.Columns.Add("Ad", typeof(string));
                dt.Columns.Add("Soyad", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Telefon", typeof(string));
                dt.Columns.Add("Adres", typeof(string));
                dt.Columns.Add("Urun ID", typeof(string));
                dt.Columns.Add("Urun", typeof(string));
                dt.Columns.Add("Birim Fiyati", typeof(double));
                dt.Columns.Add("Kategori", typeof(string));
                dt.Columns.Add("Adet", typeof(int));
                dt.Columns.Add("Toplam Fiyat", typeof(double));
                dt.Columns.Add("Tarih", typeof(string));
                dt.Columns.Add("Saat", typeof(string));

            }
            try
            {
                string[] lines = File.ReadAllLines("UrunSatis.txt");
                siparisSayisi = 0;
                foreach (string line in lines)
                {
                    
                    string[] columns = line.Split('|');
                    if (columns[11] == date.Value.ToShortDateString())
                    {
                        siparisSayisi++;
                        toplamGelir += double.Parse(columns[10]);
                        dt.Rows.Add(columns);
                    }


                }
            }
            catch{ }
            return dt;


        }
    }
}
