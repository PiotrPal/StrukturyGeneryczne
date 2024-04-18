﻿
namespace _1_TypyGeneryczne {
    internal class KolejkaKolowa {
        private double[] bufor;
        private int poczatek;
        private int koniec;

        public KolejkaKolowa() : this(pojemnosc: 5) {

        }
        public KolejkaKolowa(int pojemnosc) {
            bufor = new double[pojemnosc + 1];
            poczatek = 0;
            koniec = 0;
        }
        public void Zapisz(double wartosc) {
            bufor[koniec] = wartosc;
            koniec = (koniec + 1) % bufor.Length;
            if (koniec == poczatek) { // na poczatek oba sa 0 wiec wejdzie w to
                poczatek = (poczatek + 1) % bufor.Length;
            }
        }
        public double Odczytaj() {
            var wynik = bufor[poczatek];
            poczatek = (poczatek + 1) % bufor.Length; // #problem bo pocatek idzie dalej a koniec zostaje liczba zostaje i tworzy sie puste miejsce?
            return wynik;
        }
        public int Pojemnosc {
            get {
                return bufor.Length;
            }
        }
        public bool JestPusty {
            get {
                return koniec == poczatek;
            }
        }
        public bool JesyPelny {
            get {
                return (koniec + 1) % bufor.Length == poczatek;
            }
        }

    }
}