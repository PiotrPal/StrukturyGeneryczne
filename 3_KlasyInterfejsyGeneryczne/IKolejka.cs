namespace _3_KlasyInterfejsyGeneryczne { //automatyczne generowanie
    public interface IKolejka<T> {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Odczytaj();
        void Zapisz(T wartosc);
    }
}