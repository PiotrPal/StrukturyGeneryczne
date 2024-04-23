using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne {
    internal class Program {
        static void Konsolawypisz(double dane) {
            Console.WriteLine(dane);
        }
        static void Main(string[] args) {

            var kolejka = new KolejkaKolowa2<double>();
            WprowadzanieDanych(kolejka);
            kolejka.Drukuj(Konsolawypisz);
            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka) {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty) {
                var wartosc = kolejka.Odczytaj();
                suma += wartosc;
            }
            Console.WriteLine("suma: " + suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka) {
            while (true) {
                var result = 0.0;
                var wejscie = Console.ReadLine();
                if (double.TryParse(wejscie, out result)) {
                    kolejka.Zapisz(result);
                    continue;
                }
                break;
            }
        }
    }
}
