using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczneTest {
    [TestClass]
    public class KolejkaTest {
        [TestMethod]
        public void UzyciePeek() {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(5);

            Assert.AreEqual(1, kolejka.Peek());
            Assert.AreEqual(1, kolejka.Dequeue());
            Assert.AreEqual(2, kolejka.Dequeue());
        }

        [TestMethod]
        public void UzycieContains() {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(5);

            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void UzycieToArray() {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(5);
            
            var tab = kolejka.ToArray();
            kolejka.Dequeue();

            Assert.AreEqual(1, tab[0]);
            Assert.AreEqual(3, kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear() {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(5);

            kolejka.Clear();

            Assert.AreEqual(0,kolejka.Count);
        }
    }
}
