using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public static class Extensions
    {
        public static string Flip(this string tekst)
        {
            var charTab = tekst.ToCharArray();
            for(int i=0;i<charTab.Length;i++)
            {
                if ((byte)charTab[i] > 64 && (byte)charTab[i] < 91)
                {
                    charTab[i] = (char)((byte)charTab[i] + 32);
                }
                else if ((byte)charTab[i] > 96 && (byte)charTab[i] < 123)
                {
                    charTab[i] = (char)((byte)charTab[i] - 32);
                }
                else
                    continue;
            }
            string wynik="";
            for (int i = 0; i < charTab.Length; i++)
            {
                wynik += charTab[i];
            }
            return wynik;
        }
        public static string Shorter(this string tekst)
        {
            string wynik;
            if (tekst.Length > 10)
            {
                wynik = tekst.Substring(0, 10) + "...";
            }
            else
                wynik = tekst;
            return wynik;
        }
        public static int UpperCount(this string tekst)
        {
            int wynik = 0;
            var tab = tekst.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
            {
                if ((byte)tab[i] > 64 && (byte)tab[i] < 91)
                    wynik++;
            }
            return wynik;
        }
        public static int LowerCount(this string tekst)
        {
            int wynik = 0;
            var tab = tekst.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
            {
                if ((byte)tab[i] > 96 && (byte)tab[i] < 123)
                    wynik++;
            }
            return wynik;
        }
        public static int SpaceCount(this string tekst)
        {
            int wynik = 0;
            var tab = tekst.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
            {
                if ((byte)tab[i] == 32)
                    wynik++;
            }
            return wynik;
        }
    }
}
