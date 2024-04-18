
namespace _1_TypyGeneryczne {
    public class KolejkaKolowa<T> {
        private T[] bufor;
        private int poczatek;
        private int koniec;

        public KolejkaKolowa() : this(pojemnosc: 5) {

        }
        public KolejkaKolowa(int pojemnosc) {
            bufor = new T[pojemnosc + 1];
            poczatek = 0;
            koniec = 0;
        }
        public void Zapisz(T wartosc) {
            bufor[koniec] = wartosc;
            koniec = (koniec + 1) % bufor.Length;
            if (koniec == poczatek) {
                poczatek = (poczatek + 1) % bufor.Length;
            }
        }
        public T Odczytaj() {
            var wynik = bufor[poczatek];
            poczatek = (poczatek + 1) % bufor.Length;
            return wynik;
        }
        //public double OdczytajMoje() {
        //    return bufor[poczatek]; //jestm glupi
        //}
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

    //public class KolejkaKolowaStr {
    //    private string[] bufor;
    //    private int poczatek;
    //    private int koniec;

    //    public KolejkaKolowaStr() : this(pojemnosc: 5) {

    //    }
    //    public KolejkaKolowaStr(int pojemnosc) {
    //        bufor = new string[pojemnosc + 1];
    //        poczatek = 0;
    //        koniec = 0;
    //    }
    //    public void Zapisz(string wartosc) {
    //        bufor[koniec] = wartosc;
    //        koniec = (koniec + 1) % bufor.Length;
    //        if (koniec == poczatek) {
    //            poczatek = (poczatek + 1) % bufor.Length;
    //        }
    //    }
    //    public string Odczytaj() {
    //        var wynik = bufor[poczatek];
    //        poczatek = (poczatek + 1) % bufor.Length;
    //        return wynik;
    //    }
    //    public int Pojemnosc {
    //        get {
    //            return bufor.Length;
    //        }
    //    }
    //    public bool JestPusty {
    //        get {
    //            return koniec == poczatek;
    //        }
    //    }
    //    public bool JesyPelny {
    //        get {
    //            return (koniec + 1) % bufor.Length == poczatek;
    //        }
    //    }
    //}
}
