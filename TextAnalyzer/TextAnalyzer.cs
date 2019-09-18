using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public class TextAnalyzer
    {
        public DateTime DataUtworzenia { get; }
        public string Tekst { get; }
        public Stopwatch Stopwatch { get; }
        public TextAnalyzer(string tekst)
        {
            Tekst = tekst;
            DataUtworzenia = DateTime.Now;
            Stopwatch = new Stopwatch();
        }
        public void Flip()
        {
            Console.WriteLine($"\n\n{Tekst.Flip()}\n\n");
        }
        public void Shorten()
        {
            if(Tekst.Length<=10)
                Console.WriteLine($"Podany tekst o treści:\n\n{Tekst}\n\njest za krótki, by go skracać");
            else
                Console.WriteLine($"Skrócony tekst to:\n\n{Tekst.Shorter()}\n\n");
        }
        public void Analize()
        {
            Stopwatch.Start();
            Console.WriteLine(Tekst.AddStars());
            Console.WriteLine($"Data utworzenia: {DataUtworzenia}");
            Console.WriteLine($"Ilość spacji:{Tekst.SpaceCount()}");
            Console.WriteLine($"Ilość dużych liter:{Tekst.UpperCount()}");
            Console.WriteLine($"Ilość małych liter:{Tekst.LowerCount()}");
            Console.WriteLine($"Długość tekstu:{Tekst.Length}");
            Stopwatch.Stop();
            Console.WriteLine($"Czas analizy:{Stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
