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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Ödev_.net5
{
    static class PasswordCheck
    {
        public static int low=0, up=0, digit=0, symbol=0;
        public static string password = string.Empty;
        public static int UpLetter()
        {
            up = 0;
            foreach (char s in password)
            {
                if (char.IsUpper(s))
                {
                    up++;
                }

            }
            return up;
        }
        public static int LowLetter()
        {
            low = 0;
            foreach (char s in password)
            {
                if (char.IsLower(s))
                {
                    low++;
                }

            }
            return low;
        }

        
        public static int Digit()
        {
            digit = 0;
            foreach (char s in password)
            {
                if (char.IsDigit(s))
                {
                    digit++;
                }

            }
            return digit;
        }
        public static int Symbol()
        {
            symbol = 0;
            foreach (char s in password)
            {
                if (!char.IsLetterOrDigit(s))
                {
                    symbol++;
                }

            }
            return symbol;
        }
    }
}
