using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3_KlasyInterfejsyGeneryczne {
    public class DuzaKolejka<T> : IKolejka<T> {

        protected Queue<T> queue;

        public DuzaKolejka()
        {
            queue = new Queue<T>();
        }
        public virtual bool JestPelny => throw new System.NotImplementedException();//nigdy nie bedzie pelna

        public virtual bool JestPusty {
            get {
                return queue.Count == 0;
            }
        }

        public virtual T Odczytaj() {
            return queue.Dequeue();
        }

        public virtual void Zapisz(T wartosc) {
            queue.Enqueue(wartosc);
        }

        public IEnumerator<T> GetEnumerator() {
            //return queue.GetEnumerator();

            foreach (var item in queue) {
                //jakis kod np filtrowanie
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() { //sztuczka 
            return queue.GetEnumerator();
            //foreach (var item in queue) {
            //    //jakis kod np filtrowanie
            //    yield return item;
            //}
        }
    }
}