
namespace _3_KlasyInterfejsyGeneryczne {
    //public interface IKolejka<T> {
    //    bool JestPusty {  get; }
    //    bool JestPelny { get; }
    //    void Zapisz(T value);
    //    T Odczytaj();
    //}

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