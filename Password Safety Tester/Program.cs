/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: İlyas Aydın
**				ÖĞRENCİ NUMARASI.......: B211210101
**                         DERSİN ALINDIĞI GRUP...: 1/B
****************************************************************************/


using System;
using System.Linq;

namespace NDP_Ödev_.net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            char repeat;
            do
            {

                int score = 0;
                Console.Write("Şifre giriniz: ");
                PasswordCheck.password = Console.ReadLine();
                if (!PasswordCheck.password.Any(char.IsWhiteSpace))
                {
                    if (PasswordCheck.password.Length >= 9)
                    {
                        Console.WriteLine("Büyük Harf Sayısı: " + PasswordCheck.UpLetter());
                        Console.WriteLine("Küçük Harf Sayısı: " + PasswordCheck.LowLetter());
                        Console.WriteLine("Rakam Sayısı: " + PasswordCheck.Digit());
                        Console.WriteLine("Sembol Sayısı: " + PasswordCheck.Symbol());

                        score += PasswordCheck.low == 1 ? 10 : PasswordCheck.low > 1 ? 20 : 0;
                        score += PasswordCheck.up == 1 ? 10 : PasswordCheck.up > 1 ? 20 : 0;
                        score += PasswordCheck.digit == 1 ? 10 : PasswordCheck.digit > 1 ? 20 : 0;
                        score += PasswordCheck.symbol == 1 ? 10 : PasswordCheck.symbol > 1 ? 10 * PasswordCheck.symbol : 0;
                        score += PasswordCheck.password.Length == 9 ? 10 : 0;

                        if (PasswordCheck.low != 0 && PasswordCheck.up != 0 && PasswordCheck.digit != 0 && PasswordCheck.symbol != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (score >= 90)
                            {
                                Console.WriteLine("({0} puan)Şifre kabul edilebilir ve güçlü!", score);
                            }
                            else if (score >= 70)
                            {
                                Console.WriteLine("({0} puan)Şifre kabul edilebiir.", score);
                            }
                            else
                            {
                                Console.WriteLine("({0} puan)Şifre kabul edilemez.", score);
                            }
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Şifrede en az bir rakam, bir küçük harf, bir büyük harf ve bir sembol bulunmalıdır.");
                            Console.ForegroundColor = ConsoleColor.Black;

                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifre en az 9 karakterli olmalıdır!");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Şifre boşluksuz olmalıdır!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("Başka şifre denemek için (e)'ye, sonlandırmak için herhangi farklı bir tuşa basınız.");
                repeat = char.ToUpper(Console.ReadKey().KeyChar);
                Console.Clear();
            } while (repeat == 'E');
        }
    }
}
