using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne {
    public class PracownikComparer : IEqualityComparer<Pracownik>, IComparer<Pracownik> {
        public int Compare(Pracownik x, Pracownik y) {
            return String.Compare(x.Surname, y.Surname);
        }

        public bool Equals(Pracownik x, Pracownik y) {
            return String.Equals(x.Surname, y.Surname);
        }

        public int GetHashCode(Pracownik obj) {
            return obj.Surname.GetHashCode();
        }
    }
}
