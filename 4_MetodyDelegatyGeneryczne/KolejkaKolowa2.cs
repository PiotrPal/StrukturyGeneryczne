
using System;
using System.Collections;

namespace _4_MetodyDelegatyGeneryczne {

    public class KolejkaKolowa2<T> : DuzaKolejka<T> {
        private int _size;
        public KolejkaKolowa2(int size = 5) {
            _size = size;
        }

        public override void Zapisz(T wartosc) {
            base.Zapisz(wartosc);
            if (queue.Count > _size) {
                var usuniety = queue.Dequeue();
                PoUsunieciuElementu(usuniety, wartosc);
            }
        }

        private void PoUsunieciuElementu(T usuniety, T wartosc) {
            if (elementUsuniety != null) {
                var args = new ElementUsunietyEventArgs<T>(usuniety, wartosc);
                elementUsuniety(this, args);
            }
        }

        public override bool JestPelny {
            get {
                return queue.Count == _size;
            }
        }

        public event EventHandler<ElementUsunietyEventArgs<T>> elementUsuniety;
    }

    public class ElementUsunietyEventArgs<T> : EventArgs {
        public T ElementUsuniety { get; set; }
        public T ElementDodany { get; set; }

        public ElementUsunietyEventArgs(T usuniety, T nowy) {
            ElementUsuniety = usuniety;
            ElementDodany = nowy;
        }
    }
}