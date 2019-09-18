using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool czyNullorEmpty;
            string input;
            do
            {
                Console.WriteLine("Wprowadź tekst do analizy.\nTekst musi mieć co najmniej jeden znak:");
                input = Console.ReadLine();
                czyNullorEmpty = string.IsNullOrEmpty(input);

            } while (czyNullorEmpty);
            TextAnalyzer analizator = new TextAnalyzer(input);
            Console.WriteLine(analizator.DataUtworzenia);
            Console.WriteLine(analizator.Tekst);
            Console.WriteLine(input.Flip());
            Console.WriteLine(input.Shorter());
            Console.WriteLine(input.UpperCount());
            Console.WriteLine(input.LowerCount());
            Console.WriteLine(input.SpaceCount());
            Console.ReadLine();
        }
    }
}
