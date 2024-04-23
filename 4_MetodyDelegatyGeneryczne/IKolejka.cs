using System.Collections.Generic;

namespace _4_MetodyDelegatyGeneryczne { 
    public interface IKolejka<T> : IEnumerable<T> {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Odczytaj();
        void Zapisz(T wartosc);
    }
}