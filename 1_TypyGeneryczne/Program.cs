using System;

namespace _1_TypyGeneryczne {
    internal class Program {
        static void Main(string[] args) {
            var kolejka = new KolejkaKolowa<double>(4);
            var kolejkaInt = new KolejkaKolowa<int>();
            var kolejkaStr = new KolejkaKolowa<string>(1000);

            var kolejkaPerson = new KolejkaKolowa<Osoba>();
            kolejkaPerson.Zapisz(new Osoba { name = "Pior", surname = "Skowyrski" });
            kolejkaPerson.Zapisz(new Osoba { name = "Jarek", surname = "Pasha" });
            kolejkaPerson.Zapisz(new Osoba { name = "Hades", surname = "Idol" });

            while (!kolejkaPerson.JestPusty) {
                Console.WriteLine(">> " + kolejkaPerson.Odczytaj().name);
            }

            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka) {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty) {
                //Console.WriteLine("\t\t" + kolejka.Odczytaj());
                var wartosc = kolejka.Odczytaj();
                suma += wartosc;
            }
            Console.WriteLine("suma: " + suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka) {
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

    public class Osoba {
        public string name { get; set; }
        public string surname { get; set; }
    }
}
