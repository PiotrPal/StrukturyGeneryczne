
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
                queue.Dequeue();
            }
        }

        public override bool JestPelny {
            get {
                return queue.Count == _size;
            }
        }
    }
}