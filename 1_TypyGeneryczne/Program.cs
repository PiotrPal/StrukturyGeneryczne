using System;

namespace _1_TypyGeneryczne {
    internal class Program {
        static void Main(string[] args) {
            var kolejka = new KolejkaKolowa(3);

            while (true) {
                var result = 0.0;
                var wejscie = Console.ReadLine();
                if (double.TryParse(wejscie, out result)) {
                    kolejka.Zapisz(result);
                    continue;
                }
                break;
            }

            Console.WriteLine("W naszej kolejce jest: ");
            while (!kolejka.JestPusty) {
                Console.WriteLine("\t\t" + kolejka.Odczytaj());
            }
        }
    }
}
