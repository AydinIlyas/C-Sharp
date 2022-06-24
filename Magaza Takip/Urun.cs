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
    internal class Urun
    {

        public static void UrunEkle(string Id, string UrunAdi,string UrunFiyati,string UrunKategori,string StoktakiAdet,string RaftakiAdet)
        {
            string[] urunformat = new string[] {UrunAdi, UrunFiyati,UrunKategori, StoktakiAdet, RaftakiAdet};




            using (StreamWriter writer = new StreamWriter("urun.txt", true))
            {

                string result = string.Empty;
                //result = GenerateId();
                result = Id;
                foreach (string a in urunformat)
                {
                    result += "|" + a;

                }
                writer.WriteLine(result);
            }
        }
        static bool first = true;
        static DataTable table = new DataTable();
        public static DataTable UrunListele()
        {
            table.Clear();
            if (first == true)
            {
                table.Columns.Add("ID", typeof(string));
                table.Columns.Add("Urun", typeof(string));
                table.Columns.Add("Fiyat", typeof(string));
                table.Columns.Add("Kategori", typeof(string));
                table.Columns.Add("Stok", typeof(string));
                table.Columns.Add("Raf", typeof(string));
            }


            first = false;
            try
            {

                string[] lines = File.ReadAllLines("urun.txt");
                
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

        public static DataTable UrunAra(int kaynak,string column,string aranan)
        {
            try
            {
                if (kaynak != 1)
                {
                    if (aranan == "Erkek" || aranan == "Bayan" || aranan == "Cocuk")
                    { table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", column, aranan); }
                    else
                    {
                        table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%'", column, aranan);
                    }

                    
                }
                else
                {
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", column, aranan);
                }
                return table;

            }
            catch
            {
                return table;
            }
        }

        public static DataTable UrunAktar(string yontem,string ID, string Adet)
        {
            string[] lines = File.ReadAllLines("urun.txt");
            if(yontem=="StoktanRafa")
            {
                using (StreamWriter writer = new StreamWriter("urun.txt"))
                {
                    foreach(string line in lines)
                    {
                        if(line.Split('|')[0]!=ID)
                        {
                            writer.WriteLine(line);
                        }
                        else
                        {
                            string []columns=line.Split('|');
                            columns[4] =(Convert.ToInt32(columns[4])-Convert.ToInt32( Adet)).ToString();
                            columns[5] = (Convert.ToInt32(columns[5]) + Convert.ToInt32(Adet)).ToString();
                            string row=columns[0]+"|"+columns[1]+ "|" + columns[2]+ "|" + columns[3]+ "|" + columns[4]+ "|" + columns[5];
                            writer.WriteLine(row);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("urun.txt"))
                {
                    foreach (string line in lines)
                    {
                        if (line.Split('|')[0] != ID)
                        {
                            writer.WriteLine(line);
                        }
                        else
                        {
                            string[] columns = line.Split('|');
                            columns[4] = (Convert.ToInt32(columns[4]) + Convert.ToInt32(Adet)).ToString();
                            columns[5] = (Convert.ToInt32(columns[5]) - Convert.ToInt32(Adet)).ToString();
                            string row = columns[0] + "|" + columns[1] + "|" + columns[2] + "|" + columns[3] + "|" + columns[4] + "|" + columns[5];
                            writer.WriteLine(row);
                        }
                    }
                }
            }
            return UrunListele();
        }
        public static DataTable UrunFiyatYenile(string ID,string Fiyat)
        {
            string[] lines = File.ReadAllLines("urun.txt");
            
                using (StreamWriter writer = new StreamWriter("urun.txt"))
                {
                    foreach (string line in lines)
                    {
                        if (line.Split('|')[0] != ID)
                        {
                            writer.WriteLine(line);
                        }
                        else
                        {
                            string[] columns = line.Split('|');
                            string row = columns[0] + "|" + columns[1] + "|" + Fiyat + "|" + columns[3] + "|" + columns[4] + "|" + columns[5];
                            writer.WriteLine(row);
                        }
                    }
                }
            
            return UrunListele();
        }


    }
}
