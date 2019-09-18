using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public class TextAnalyzer
    {
        public DateTime DataUtworzenia { get; }
        public string Tekst { get; }
        public TextAnalyzer(string tekst)
        {
            Tekst = tekst;
            DataUtworzenia = DateTime.Now;
        }
    }
}
