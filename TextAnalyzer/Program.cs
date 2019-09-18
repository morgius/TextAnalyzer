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
            
            bool ifProceed;
            do
            {
                bool ifyNullorEmpty;
                string input;
                do
                {
                    Console.WriteLine("Wprowadź tekst do analizy.\nTekst musi mieć co najmniej jeden znak:");
                    input = Console.ReadLine();
                    ifyNullorEmpty = string.IsNullOrEmpty(input);
                    Console.Clear();

                } while (ifyNullorEmpty);
                TextAnalyzer analizator = new TextAnalyzer(input);
                bool ifActionChosen;
                do
                {
                    Console.WriteLine("Wybierz opcję wciskając 1, 2 lub 3 na klawiaturze:\n1 - Flip\n2 - Skróć\n3 - Analizuj");
                    var keyInput = Console.ReadKey();
                    ifActionChosen = (keyInput.Key == ConsoleKey.D1) || (keyInput.Key == ConsoleKey.D2) || (keyInput.Key == ConsoleKey.D3);
                    Console.Clear();
                    switch (keyInput.Key)
                    {
                        case ConsoleKey.D1:
                            analizator.Flip();
                            break;
                        case ConsoleKey.D2:
                            analizator.Shorten();
                            break;
                        case ConsoleKey.D3:
                            analizator.Analize();
                            break;
                    }
                         

                } while (!ifActionChosen);
                Console.WriteLine("Aby zakończyć, wciśnij \"ESC\", aby rozpocząć od nowa wciśnij dowolny klawisz.");
                var keyInput2 = Console.ReadKey();
                ifProceed = (keyInput2.Key == ConsoleKey.Escape);
                Console.Clear();

            } while (!ifProceed);
            return;
        }
    }
}
