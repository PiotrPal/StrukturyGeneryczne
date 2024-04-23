using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne {
    internal class Program {
        static void Main(string[] args) {

            //Action<double> drukuj2 = KonsolaWypisz;
            ////drukuj2(6.5);

            //Action<double> drukuj2 = delegate (double dane) { // metoda anonimowa
            //    Console.WriteLine(dane);
            //};

            //Action<double> drukuj2 = d => Console.WriteLine(d); // lambda?
            #region delegaty
            Console.WriteLine("\t--Action--");
            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a + b + c);
            test(1, 2, 3);

            Console.WriteLine("\t--Func--");
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;

            Console.WriteLine(potegowanie(5));
            Console.WriteLine(dodaj(2, 6));

            Console.WriteLine("\t--Predicate--");
            Predicate<double> mniejszeODsto = d => d < 100;
            //Func<double, bool> mniejszeODstoFunc = d => d < 100;//test czy to to samo

            Console.WriteLine(mniejszeODsto(30));
            //Console.WriteLine(mniejszeODstoFunc(30));
            #endregion

            Console.WriteLine("\t--Program--");
            var kolejka = new KolejkaKolowa2<double>();
            WprowadzanieDanych(kolejka);

            Console.WriteLine("\t--Converter--");
            //Converter<double, DateTime> konwerter = d => new DateTime(2024, 1, 1).AddDays(d); //skrocenie zapisu tez

            var jakoData = kolejka.Mapuj(d => new DateTime(2024, 1, 1).AddDays(d)); // skrocony zapis z kolejka.Mapuj<double,DateTime>(konwerter);
            foreach (var item in jakoData) { 
                Console.WriteLine(item);
            }

            kolejka.Drukuj(d => Console.WriteLine(d));// lambda bezposredio przy wywolaniu
            
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
