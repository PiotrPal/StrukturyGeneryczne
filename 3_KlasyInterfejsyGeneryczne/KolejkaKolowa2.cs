
namespace _3_KlasyInterfejsyGeneryczne{
    //public interface IKolejka<T> {
    //    bool JestPusty {  get; }
    //    bool JestPelny { get; }
    //    void Zapisz(T value);
    //    T Odczytaj();
    //}

    public class KolejkaKolowa2<T> : IKolejka<T> {
        private T[] bufor;
        private int poczatek;
        private int koniec;

        public KolejkaKolowa2() : this(pojemnosc: 5) {

        }
        public KolejkaKolowa2(int pojemnosc) {
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
        public bool JestPelny {
            get {
                return (koniec + 1) % bufor.Length == poczatek;
            }
        }
    }
}
