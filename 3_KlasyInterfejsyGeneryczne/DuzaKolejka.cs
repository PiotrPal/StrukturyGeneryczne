namespace _3_KlasyInterfejsyGeneryczne {
    internal class DuzaKolejka<T> : IKolejka<T> {
        public bool JestPelny => throw new System.NotImplementedException();

        public bool JestPusty => throw new System.NotImplementedException();

        public T Odczytaj() {
            throw new System.NotImplementedException();
        }

        public void Zapisz(T wartosc) {
            throw new System.NotImplementedException();
        }
    }
}