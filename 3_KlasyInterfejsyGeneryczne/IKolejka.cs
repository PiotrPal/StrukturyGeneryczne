using System.Collections.Generic;

namespace _3_KlasyInterfejsyGeneryczne { //automatyczne generowanie
    public interface IKolejka<T> : IEnumerable<T> {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Odczytaj();
        void Zapisz(T wartosc);
        //IEnumerable<Tout> ElementJakoInt<Tout>();
        //IEnumerable<string> ElementJakoStr();
    }
}